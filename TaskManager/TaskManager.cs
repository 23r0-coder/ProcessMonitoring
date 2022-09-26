using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
using System.Dynamic;
using System.Diagnostics;


namespace TaskManager
{
    public partial class TaskManager : Form
    {

        #region//Declaracion e implementacion de contadores para los graficos de rendimiento - Eddison Payes
        #region//Performance Counters
        PerformanceCounter perfCPU = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfRAM = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfSystemTime = new PerformanceCounter("System", "System Up Time");
        PerformanceCounter perfDisk = new PerformanceCounter("PhysicalDisk", "% Idle Time", "_Total");
        #endregion

        //Timer event 
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        //Matriz para guardar los procesos del equipo local
        Process[] processList = Process.GetProcesses();

        //Variable global de tipo string
        string pName = "";

        #region//Declarando una estructura para informacion del disco duro
        [DllImport("kernel32.dll")]
        private static extern bool GetProcessIoCounters(IntPtr ProcessHandle, out IO_COUNTERS IoCounters);
        IO_COUNTERS counters;

        struct IO_COUNTERS
        {
            public long ReadOperationCount;
            public long WriteOperationCount;
            public long OtherOperationCount;
            public long ReadTransferCount;
            public long WriteTransferCount;
            public long OtherTransferCount;
        }
        #endregion

        //Main function
        public TaskManager()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(Timer_Tick);
            TimeSpan t = new TimeSpan(0, 0, 1);
            timer.Interval = int.Parse(t.TotalMilliseconds.ToString());
            timer.Start();

            #region//Obtener informacion del sistema
            getBattery();
            getCPUInfo();
            getAccount();
            #endregion
        }
        #endregion


        #region//Para mover el form con estilo 'None' y diseno del formulario - Victor Vasquez
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion


        #region//Obtener informacion del equipo - Oscar Javier

        #region //Battery Status
        private void getBattery()
        {
            System.Management.ManagementClass wmi = new System.Management.ManagementClass("Win32_Battery");
            var providers = wmi.GetInstances();

            foreach (var provider in providers)
            {
                int batteryStatus = Convert.ToInt16(provider["BatteryStatus"]);

                if (batteryStatus == 0)
                {
                    lblBattery.Text = "Battery Status :" + "   " + "Other";
                }
                if (batteryStatus == 1)
                {
                    lblBattery.Text = "Battery Status :" + "   " + "Unknown";
                }
                if (batteryStatus == 2)
                {
                    lblBattery.Text = "Battery Status :" + "   " + "Fully Charged";
                }
                if (batteryStatus == 3)
                {
                    lblBattery.Text = "Battery Status :" + "   " + "Low";
                }
                if (batteryStatus == 4)
                {
                    lblBattery.Text = "Battery Status :" + "   " + "Critical";
                }
                if (batteryStatus == 5)
                {
                    lblBattery.Text = "Battery Status :" + "   " + "Charging";
                }
                if (batteryStatus == 6)
                {
                    lblBattery.Text = "Battery Status :" + "   " + "Charging and High";
                }
                if (batteryStatus == 7)
                {
                    lblBattery.Text = "Battery Status :" + "   " + "Charging and Low";
                }
                if (batteryStatus == 8)
                {
                    lblBattery.Text = "Battery Status :" + "   " + "Charging and Critical";
                }
                if (batteryStatus == 9)
                {
                    lblBattery.Text = "Battery Status :" + "   " + "Undefind";
                }
                if (batteryStatus == 10)
                {
                    lblBattery.Text = "Battery Status :" + "   " + "Partially Charged";
                }
            }

        }
        #endregion

        #region //Processor Info
        private void getCPUInfo()
        {
            System.Management.ManagementClass wmi = new System.Management.ManagementClass("Win32_Processor");
            var providers = wmi.GetInstances();

            foreach (var provider in providers)
            {
                int procFamily = Convert.ToInt16(provider["Family"]);
                int procSpeed = Convert.ToInt32(provider["CurrentClockSpeed"]);
                string procStatus = provider["Status"].ToString();

                //Nombre del procesador especifico del equipo donde fue creado el programa
                //Para el nombre de todos lo procesadores se requieren mas de 1000 nombres
                lblCPU.Text = "Processor:  Unknown";

                lblClockSpeed.Text = "Clock Speed:   " + procSpeed + " MHz   ";
                lblProcStatus.Text = "Processor Status:   " + procStatus;
            }
        }
        #endregion

        #region//User Account
        private void getAccount()
        {
            ManagementObjectSearcher s = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_UserAccount");
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    lblUser.Text = "User Account Name :    " + wmi.GetPropertyValue("Domain").ToString();
                }
                catch
                {

                }
                lblUser.Text = "User Account Name :    Unknown";
            }
        }
        #endregion

        #region//Envorinment

        #endregion
        #endregion


        #region//Mandar y mostrar la informacion al formulario - Gustavo Zepeda
        public void renderProcessesOnListView()
        {
            listView1.Items.Clear();


            ImageList Imagelist = new ImageList();
            foreach (Process process in processList)
            {
                try
                {
                    GetProcessIoCounters(process.Handle, out counters);
                }
                catch { }

                string status = (process.Responding == true ? "Responding" : "Not responding");
                dynamic extraProcessInfo = GetProcessExtraInformation(process.Id);

                string[] row = {

                    process.ProcessName,  //1
                    process.Id.ToString(), //2
                    status, //3
                    extraProcessInfo.Username, //4
                    BytesToReadableValue(process.PrivateMemorySize64), //5
                    extraProcessInfo.Description,
                    process.SessionId.ToString() + " thread",
                    BytesToReadableValue(counters.ReadTransferCount)
            };

                try
                {
                    Imagelist.Images.Add(
                        process.Id.ToString(),
                        Icon.ExtractAssociatedIcon(process.MainModule.FileName).ToBitmap()
                    );
                }
                catch { }

                // Crea un nuevo elemento para agregar a la vista de lista que espera la fila de información como primer argumento
                ListViewItem item = new ListViewItem(row)

                {
                    // Establezca el ImageIndex del elemento como el mismo definido en el try-catch anterior
                    ImageIndex = Imagelist.Images.IndexOfKey(process.Id.ToString())

                };

                // Agrega el artículo
                listView1.Items.Add(item);
            }

            // Configura la lista de imágenes de su lista para ver la lista creada anteriormente :)
            listView1.LargeImageList = Imagelist;
            listView1.SmallImageList = Imagelist;

        }

        #region //Devuelve un objeto Expando con la descripción y el nombre de usuario de un proceso del ID del proceso
        public ExpandoObject GetProcessExtraInformation(int processId)
        {
            // Consultar el proceso Win32
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            // Crea un objeto dinámico para almacenar algunas propiedades en él.
            dynamic response = new ExpandoObject();
            response.Description = "";
            response.Username = "Unknown";

            foreach (ManagementObject obj in processList)
            {
                // Retornar el nombre de usuario
                string[] argList = new string[] { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0)
                {
                    // Retornar Username
                    response.Username = argList[0];

                }

                // Retornar la descripción del proceso (si existe)
                if (obj["ExecutablePath"] != null)
                {
                    try
                    {
                        FileVersionInfo info = FileVersionInfo.GetVersionInfo(obj["ExecutablePath"].ToString());
                        response.Description = info.FileDescription;
                    }
                    catch { }
                }
            }

            return response;

        }
        #endregion
        #endregion


        #region//Eventos y funcion conventir valores - Danny Perez
        #region//Método que convierte bytes a su valor legible por humanos

        public string BytesToReadableValue(long number)
        {
            List<string> suffixes = new List<string> { " B", " KB", " MB", " GB", " TB", " PB" };

            for (int i = 0; i < suffixes.Count; i++)
            {
                long temp = number / (int)Math.Pow(1024, i + 1);

                if (temp == 0)
                {
                    return (number / (int)Math.Pow(1024, i)) + suffixes[i];
                }
            }

            return number.ToString();
        }
        #endregion

        #region//Eventos del formulario

        private void Timer_Tick(object sender, EventArgs e)
        {
            cpuPB.Value = (int)perfCPU.NextValue();
            cpuPB.Text = cpuPB.Value.ToString() + "%";
            ramPB.Value = (int)perfRAM.NextValue();
            ramPB.Text = ramPB.Value.ToString() + "MB";
            diskPB.Value = (int)perfDisk.NextValue();
            diskPB.Text = diskPB.Value.ToString() + "%";
            lblTime.Text = "System Time Up:   " + (int)perfSystemTime.NextValue() / 60 / 60 + " Hours";
            getTime();
        }

        private void getTime()
        {
            DateTime date;
            date = DateTime.Now;
            lblClock.Text = date.ToLongTimeString() + "    " + date.ToLongDateString();

        }
        private void TaskManager_Load(object sender, EventArgs e)
        {
            renderProcessesOnListView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BTNProcesos_MouseHover(object sender, EventArgs e)
        {
            panelBTNProcesos.Visible = true;
        }

        private void BTNProcesos_MouseLeave(object sender, EventArgs e)
        {
            panelBTNProcesos.Visible = false;
        }

        private void BTNRendimiento_Click(object sender, EventArgs e)
        {
            BTNRefresh.Visible = false;
            BTNEndTask.Visible = false;
            listView1.Visible = false;
            lblBattery.Visible = true;
            lblClock.Visible = true;
            lblClockSpeed.Visible = true;
            lblCPU.Visible = true;
            lblProcStatus.Visible = true;
            lblTime.Visible = true;
            lblUser.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            cpuPB.Visible = true;
            diskPB.Visible = true;
            ramPB.Visible = true;   

        }

        private void BTNRendimiento_MouseHover(object sender, EventArgs e)
        {
            panelBTNRendimiento.Visible = true;
        }

        private void BTNRendimiento_MouseLeave(object sender, EventArgs e)
        {
            panelBTNRendimiento.Visible = false;
        }

        private void BTNMenu_Click(object sender, EventArgs e)
        {
            BTNProcesos.Visible = !BTNProcesos.Visible;
            BTNRendimiento.Visible = !BTNRendimiento.Visible;
        }

        private void BTNMenu_MouseHover(object sender, EventArgs e)
        {
            panelBTNMenu.Visible = true;
        }

        private void BTNMenu_MouseLeave(object sender, EventArgs e)
        {
            panelBTNMenu.Visible = false;
        }

        public void BTNEndTask_Click(object sender, EventArgs e)
        {
            pName = listView1.FocusedItem.Text.ToString();

            try
            {
                foreach (Process process in processList)
                {
                    if (process.ProcessName == pName)
                    {
                        process.Kill();
                        listView1.FocusedItem.Remove();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNRefresh_Click(object sender, EventArgs e)
        {
            renderProcessesOnListView();
        }

        private void BTNProcesos_Click_1(object sender, EventArgs e)
        {
            
            listView1.Visible = true;
            lblBattery.Visible = false;
            lblClock.Visible = false;
            lblClockSpeed.Visible = false;
            lblCPU.Visible = false;
            lblProcStatus.Visible = false;
            lblTime.Visible = false;
            lblUser.Visible = false;
            BTNEndTask.Visible = true;
            BTNRefresh.Visible = true;
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            cpuPB.Visible = false;
            diskPB.Visible = false;
            ramPB.Visible = false;
        }
        #endregion
        #endregion
    }
}