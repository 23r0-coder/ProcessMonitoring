using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
using System.Dynamic;
using System.Diagnostics;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        Process[] processList = Process.GetProcesses();
        string pName = "";

        [DllImport("kernel32.dll")]
        private static extern bool GetProcessIoCounters(IntPtr ProcessHandle, out IO_COUNTERS IoCounters);

        struct IO_COUNTERS
        {
            public long ReadOperationCount;
            public long WriteOperationCount;
            public long OtherOperationCount;
            public long ReadTransferCount;
            public long WriteTransferCount;
            public long OtherTransferCount;
        }

        public TaskManager()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(Timer_Tick);
            TimeSpan t = new TimeSpan(0, 0, 1);
            timer.Interval = int.Parse(t.TotalSeconds.ToString());
            timer.Start();

            //get PC info
            getBattery();
            getCPUInfo();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            getTime();
        }

        private void getTime()
        {
            DateTime date;
            date = DateTime.Now;
            lblClock.Text = date.ToLongTimeString() + "    " + date.ToLongDateString();

        }

        #region //Battery Status
        private void getBattery()
        {
            System.Management.ManagementClass wmi = new System.Management.ManagementClass("Win32_Battery");
            var providers = wmi.GetInstances();

            foreach(var provider in providers)
            {
                int batteryStatus = Convert.ToInt16(provider["BatteryStatus"]);

                if(batteryStatus == 0)
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

                lblCPU.Text = "Intel(R) Core(TM) i5-2520M";
                lblClockSpeed.Text = "Clock Speed:   " + procSpeed + " MHz   ";
                lblProcStatus.Text = "Processor Status:   " + procStatus;
            }
        }
        #endregion



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        IO_COUNTERS counters;
        Process[] processes = Process.GetProcesses();
        

        private void barraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /// <summary>
        /// Método que convierte bytes a su valor legible por humanos
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
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
        private void TaskManager_Load(object sender, EventArgs e)
        {
            //renderProcessesOnListView();
        }


        /// <summary>
        /// Devuelve un objeto Expando con la descripción y el nombre de usuario de un proceso del ID del proceso.
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
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

        //"SELECT * FROM Win32_PerfFormattedData_PerfProc_Process Where ProcessID = "
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

            
            panel1.Visible = true;
            
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
                    if(process.ProcessName == pName)
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
            //renderProcessesOnListView();
        }

        private void BTNProcesos_Click(object sender, EventArgs e)
        {

            
        }

        private void BTNProcesos_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            BTNEndTask.Visible = true;
            BTNRefresh.Visible = true;
        }
    }
}