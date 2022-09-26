namespace TaskManager
{
    partial class TaskManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManager));
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barraMenu = new System.Windows.Forms.Panel();
            this.panelBTNMenu = new System.Windows.Forms.Panel();
            this.BTNMenu = new System.Windows.Forms.Button();
            this.panelBTNRendimiento = new System.Windows.Forms.Panel();
            this.panelBTNProcesos = new System.Windows.Forms.Panel();
            this.BTNRendimiento = new System.Windows.Forms.Button();
            this.BTNProcesos = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblClock = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.lblProcStatus = new System.Windows.Forms.Label();
            this.lblClockSpeed = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblBattery = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cpuPB = new CircularProgressBar.CircularProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.ramPB = new CircularProgressBar.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.diskPB = new CircularProgressBar.CircularProgressBar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.processName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.disk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTNRefresh = new System.Windows.Forms.Button();
            this.BTNEndTask = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelBTNS = new System.Windows.Forms.Panel();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.barraMenu.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.panelBTNS.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.barraSuperior.Controls.Add(this.label1);
            this.barraSuperior.Controls.Add(this.pictureBox2);
            this.barraSuperior.Controls.Add(this.pictureBox1);
            this.barraSuperior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(1067, 54);
            this.barraSuperior.TabIndex = 0;
            this.barraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task Manager";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1028, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // barraMenu
            // 
            this.barraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.barraMenu.Controls.Add(this.panelBTNMenu);
            this.barraMenu.Controls.Add(this.BTNMenu);
            this.barraMenu.Controls.Add(this.panelBTNRendimiento);
            this.barraMenu.Controls.Add(this.panelBTNProcesos);
            this.barraMenu.Controls.Add(this.BTNRendimiento);
            this.barraMenu.Controls.Add(this.BTNProcesos);
            this.barraMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraMenu.Location = new System.Drawing.Point(0, 54);
            this.barraMenu.Margin = new System.Windows.Forms.Padding(4);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(241, 561);
            this.barraMenu.TabIndex = 1;
            // 
            // panelBTNMenu
            // 
            this.panelBTNMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.panelBTNMenu.Location = new System.Drawing.Point(3, 0);
            this.panelBTNMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelBTNMenu.Name = "panelBTNMenu";
            this.panelBTNMenu.Size = new System.Drawing.Size(4, 39);
            this.panelBTNMenu.TabIndex = 3;
            this.panelBTNMenu.Visible = false;
            // 
            // BTNMenu
            // 
            this.BTNMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.BTNMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNMenu.FlatAppearance.BorderSize = 0;
            this.BTNMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.BTNMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNMenu.Image = ((System.Drawing.Image)(resources.GetObject("BTNMenu.Image")));
            this.BTNMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMenu.Location = new System.Drawing.Point(7, 0);
            this.BTNMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BTNMenu.Name = "BTNMenu";
            this.BTNMenu.Size = new System.Drawing.Size(184, 39);
            this.BTNMenu.TabIndex = 2;
            this.BTNMenu.UseVisualStyleBackColor = false;
            this.BTNMenu.Click += new System.EventHandler(this.BTNMenu_Click);
            this.BTNMenu.MouseLeave += new System.EventHandler(this.BTNMenu_MouseLeave);
            this.BTNMenu.MouseHover += new System.EventHandler(this.BTNMenu_MouseHover);
            // 
            // panelBTNRendimiento
            // 
            this.panelBTNRendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.panelBTNRendimiento.Location = new System.Drawing.Point(3, 85);
            this.panelBTNRendimiento.Margin = new System.Windows.Forms.Padding(4);
            this.panelBTNRendimiento.Name = "panelBTNRendimiento";
            this.panelBTNRendimiento.Size = new System.Drawing.Size(4, 39);
            this.panelBTNRendimiento.TabIndex = 1;
            this.panelBTNRendimiento.Visible = false;
            // 
            // panelBTNProcesos
            // 
            this.panelBTNProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.panelBTNProcesos.Location = new System.Drawing.Point(3, 43);
            this.panelBTNProcesos.Margin = new System.Windows.Forms.Padding(4);
            this.panelBTNProcesos.Name = "panelBTNProcesos";
            this.panelBTNProcesos.Size = new System.Drawing.Size(4, 39);
            this.panelBTNProcesos.TabIndex = 0;
            this.panelBTNProcesos.Visible = false;
            // 
            // BTNRendimiento
            // 
            this.BTNRendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.BTNRendimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNRendimiento.FlatAppearance.BorderSize = 0;
            this.BTNRendimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.BTNRendimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRendimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRendimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNRendimiento.Image = ((System.Drawing.Image)(resources.GetObject("BTNRendimiento.Image")));
            this.BTNRendimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNRendimiento.Location = new System.Drawing.Point(7, 85);
            this.BTNRendimiento.Margin = new System.Windows.Forms.Padding(4);
            this.BTNRendimiento.Name = "BTNRendimiento";
            this.BTNRendimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTNRendimiento.Size = new System.Drawing.Size(184, 39);
            this.BTNRendimiento.TabIndex = 1;
            this.BTNRendimiento.Text = "Rendimiento";
            this.BTNRendimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNRendimiento.UseVisualStyleBackColor = false;
            this.BTNRendimiento.Visible = false;
            this.BTNRendimiento.Click += new System.EventHandler(this.BTNRendimiento_Click);
            this.BTNRendimiento.MouseLeave += new System.EventHandler(this.BTNRendimiento_MouseLeave);
            this.BTNRendimiento.MouseHover += new System.EventHandler(this.BTNRendimiento_MouseHover);
            // 
            // BTNProcesos
            // 
            this.BTNProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.BTNProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNProcesos.FlatAppearance.BorderSize = 0;
            this.BTNProcesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.BTNProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNProcesos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNProcesos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNProcesos.Image = ((System.Drawing.Image)(resources.GetObject("BTNProcesos.Image")));
            this.BTNProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNProcesos.Location = new System.Drawing.Point(7, 43);
            this.BTNProcesos.Margin = new System.Windows.Forms.Padding(4);
            this.BTNProcesos.Name = "BTNProcesos";
            this.BTNProcesos.Size = new System.Drawing.Size(184, 39);
            this.BTNProcesos.TabIndex = 0;
            this.BTNProcesos.Text = " Procesos";
            this.BTNProcesos.UseVisualStyleBackColor = false;
            this.BTNProcesos.Visible = false;
            this.BTNProcesos.Click += new System.EventHandler(this.BTNProcesos_Click_1);
            this.BTNProcesos.MouseLeave += new System.EventHandler(this.BTNProcesos_MouseLeave);
            this.BTNProcesos.MouseHover += new System.EventHandler(this.BTNProcesos_MouseHover);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panelInfo.Controls.Add(this.lblClock);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(241, 54);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(826, 105);
            this.panelInfo.TabIndex = 2;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(233, 30);
            this.lblClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(59, 23);
            this.lblClock.TabIndex = 8;
            this.lblClock.Text = "label7";
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelCentral.Controls.Add(this.panelBTNS);
            this.panelCentral.Controls.Add(this.lblProcStatus);
            this.panelCentral.Controls.Add(this.lblClockSpeed);
            this.panelCentral.Controls.Add(this.lblCPU);
            this.panelCentral.Controls.Add(this.lblTime);
            this.panelCentral.Controls.Add(this.lblUser);
            this.panelCentral.Controls.Add(this.lblBattery);
            this.panelCentral.Controls.Add(this.label6);
            this.panelCentral.Controls.Add(this.cpuPB);
            this.panelCentral.Controls.Add(this.label5);
            this.panelCentral.Controls.Add(this.ramPB);
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Controls.Add(this.diskPB);
            this.panelCentral.Controls.Add(this.listView1);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(241, 159);
            this.panelCentral.Margin = new System.Windows.Forms.Padding(4);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(826, 456);
            this.panelCentral.TabIndex = 3;
            // 
            // lblProcStatus
            // 
            this.lblProcStatus.AutoSize = true;
            this.lblProcStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcStatus.ForeColor = System.Drawing.Color.White;
            this.lblProcStatus.Location = new System.Drawing.Point(29, 400);
            this.lblProcStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcStatus.Name = "lblProcStatus";
            this.lblProcStatus.Size = new System.Drawing.Size(70, 28);
            this.lblProcStatus.TabIndex = 15;
            this.lblProcStatus.Text = "label7";
            this.lblProcStatus.Visible = false;
            // 
            // lblClockSpeed
            // 
            this.lblClockSpeed.AutoSize = true;
            this.lblClockSpeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockSpeed.ForeColor = System.Drawing.Color.White;
            this.lblClockSpeed.Location = new System.Drawing.Point(29, 356);
            this.lblClockSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClockSpeed.Name = "lblClockSpeed";
            this.lblClockSpeed.Size = new System.Drawing.Size(70, 28);
            this.lblClockSpeed.TabIndex = 16;
            this.lblClockSpeed.Text = "label7";
            this.lblClockSpeed.Visible = false;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.White;
            this.lblCPU.Location = new System.Drawing.Point(29, 311);
            this.lblCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(70, 28);
            this.lblCPU.TabIndex = 17;
            this.lblCPU.Text = "label7";
            this.lblCPU.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(456, 311);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 28);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "label7";
            this.lblTime.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(456, 268);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(70, 28);
            this.lblUser.TabIndex = 19;
            this.lblUser.Text = "label7";
            this.lblUser.Visible = false;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattery.ForeColor = System.Drawing.Color.White;
            this.lblBattery.Location = new System.Drawing.Point(29, 268);
            this.lblBattery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(70, 28);
            this.lblBattery.TabIndex = 20;
            this.lblBattery.Text = "label7";
            this.lblBattery.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(404, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "CPU";
            this.label6.Visible = false;
            // 
            // cpuPB
            // 
            this.cpuPB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpuPB.AnimationSpeed = 500;
            this.cpuPB.BackColor = System.Drawing.Color.Transparent;
            this.cpuPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuPB.ForeColor = System.Drawing.Color.White;
            this.cpuPB.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.cpuPB.InnerMargin = 2;
            this.cpuPB.InnerWidth = -1;
            this.cpuPB.Location = new System.Drawing.Point(348, 84);
            this.cpuPB.Margin = new System.Windows.Forms.Padding(4);
            this.cpuPB.MarqueeAnimationSpeed = 2000;
            this.cpuPB.Name = "cpuPB";
            this.cpuPB.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.cpuPB.OuterMargin = -25;
            this.cpuPB.OuterWidth = 26;
            this.cpuPB.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.cpuPB.ProgressWidth = 6;
            this.cpuPB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuPB.Size = new System.Drawing.Size(150, 150);
            this.cpuPB.StartAngle = 270;
            this.cpuPB.SubscriptColor = System.Drawing.Color.White;
            this.cpuPB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpuPB.SubscriptText = "";
            this.cpuPB.SuperscriptColor = System.Drawing.Color.White;
            this.cpuPB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpuPB.SuperscriptText = "";
            this.cpuPB.TabIndex = 13;
            this.cpuPB.Text = "%";
            this.cpuPB.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpuPB.Value = 68;
            this.cpuPB.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(124, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "RAM";
            this.label5.Visible = false;
            // 
            // ramPB
            // 
            this.ramPB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ramPB.AnimationSpeed = 500;
            this.ramPB.BackColor = System.Drawing.Color.Transparent;
            this.ramPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramPB.ForeColor = System.Drawing.Color.White;
            this.ramPB.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ramPB.InnerMargin = 2;
            this.ramPB.InnerWidth = -1;
            this.ramPB.Location = new System.Drawing.Point(78, 84);
            this.ramPB.Margin = new System.Windows.Forms.Padding(4);
            this.ramPB.MarqueeAnimationSpeed = 2000;
            this.ramPB.Maximum = 16385;
            this.ramPB.Name = "ramPB";
            this.ramPB.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.ramPB.OuterMargin = -25;
            this.ramPB.OuterWidth = 26;
            this.ramPB.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.ramPB.ProgressWidth = 6;
            this.ramPB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramPB.Size = new System.Drawing.Size(138, 138);
            this.ramPB.StartAngle = 270;
            this.ramPB.SubscriptColor = System.Drawing.Color.White;
            this.ramPB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ramPB.SubscriptText = "";
            this.ramPB.SuperscriptColor = System.Drawing.Color.White;
            this.ramPB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ramPB.SuperscriptText = "";
            this.ramPB.TabIndex = 11;
            this.ramPB.Text = "%";
            this.ramPB.TextMargin = new System.Windows.Forms.Padding(0);
            this.ramPB.Value = 6800;
            this.ramPB.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(656, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "DISK";
            this.label3.Visible = false;
            // 
            // diskPB
            // 
            this.diskPB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.diskPB.AnimationSpeed = 500;
            this.diskPB.BackColor = System.Drawing.Color.Transparent;
            this.diskPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskPB.ForeColor = System.Drawing.Color.White;
            this.diskPB.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.diskPB.InnerMargin = 2;
            this.diskPB.InnerWidth = -1;
            this.diskPB.Location = new System.Drawing.Point(612, 84);
            this.diskPB.Margin = new System.Windows.Forms.Padding(4);
            this.diskPB.MarqueeAnimationSpeed = 2000;
            this.diskPB.Maximum = 125;
            this.diskPB.Name = "diskPB";
            this.diskPB.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.diskPB.OuterMargin = -25;
            this.diskPB.OuterWidth = 26;
            this.diskPB.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.diskPB.ProgressWidth = 6;
            this.diskPB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskPB.Size = new System.Drawing.Size(138, 138);
            this.diskPB.StartAngle = 270;
            this.diskPB.SubscriptColor = System.Drawing.Color.White;
            this.diskPB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.diskPB.SubscriptText = "";
            this.diskPB.SuperscriptColor = System.Drawing.Color.White;
            this.diskPB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.diskPB.SuperscriptText = "";
            this.diskPB.TabIndex = 9;
            this.diskPB.Text = "%";
            this.diskPB.TextMargin = new System.Windows.Forms.Padding(0);
            this.diskPB.Value = 68;
            this.diskPB.Visible = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processName,
            this.id,
            this.status,
            this.username,
            this.memory,
            this.description,
            this.cpu,
            this.disk});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 42);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(826, 414);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // processName
            // 
            this.processName.Text = "Process Name";
            this.processName.Width = 200;
            // 
            // id
            // 
            this.id.DisplayIndex = 5;
            this.id.Text = "PID";
            // 
            // status
            // 
            this.status.DisplayIndex = 1;
            this.status.Text = "Status";
            this.status.Width = 100;
            // 
            // username
            // 
            this.username.DisplayIndex = 6;
            this.username.Text = "Username";
            // 
            // memory
            // 
            this.memory.DisplayIndex = 3;
            this.memory.Text = "Memory";
            this.memory.Width = 80;
            // 
            // description
            // 
            this.description.DisplayIndex = 7;
            this.description.Text = "Description";
            // 
            // cpu
            // 
            this.cpu.DisplayIndex = 2;
            this.cpu.Text = "CPU";
            this.cpu.Width = 80;
            // 
            // disk
            // 
            this.disk.DisplayIndex = 4;
            this.disk.Text = "Disk";
            this.disk.Width = 80;
            // 
            // BTNRefresh
            // 
            this.BTNRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNRefresh.FlatAppearance.BorderSize = 0;
            this.BTNRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.BTNRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRefresh.ForeColor = System.Drawing.Color.White;
            this.BTNRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BTNRefresh.Image")));
            this.BTNRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNRefresh.Location = new System.Drawing.Point(5, 2);
            this.BTNRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.BTNRefresh.Name = "BTNRefresh";
            this.BTNRefresh.Size = new System.Drawing.Size(129, 28);
            this.BTNRefresh.TabIndex = 0;
            this.BTNRefresh.Text = "Refresh";
            this.BTNRefresh.UseVisualStyleBackColor = false;
            this.BTNRefresh.Click += new System.EventHandler(this.BTNRefresh_Click);
            // 
            // BTNEndTask
            // 
            this.BTNEndTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNEndTask.FlatAppearance.BorderSize = 0;
            this.BTNEndTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.BTNEndTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEndTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEndTask.ForeColor = System.Drawing.Color.White;
            this.BTNEndTask.Image = ((System.Drawing.Image)(resources.GetObject("BTNEndTask.Image")));
            this.BTNEndTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEndTask.Location = new System.Drawing.Point(143, 2);
            this.BTNEndTask.Margin = new System.Windows.Forms.Padding(4);
            this.BTNEndTask.Name = "BTNEndTask";
            this.BTNEndTask.Size = new System.Drawing.Size(135, 28);
            this.BTNEndTask.TabIndex = 1;
            this.BTNEndTask.Text = "End Task";
            this.BTNEndTask.UseVisualStyleBackColor = false;
            this.BTNEndTask.Click += new System.EventHandler(this.BTNEndTask_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(137, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 28);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelBTNS
            // 
            this.panelBTNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelBTNS.Controls.Add(this.button1);
            this.panelBTNS.Controls.Add(this.BTNEndTask);
            this.panelBTNS.Controls.Add(this.BTNRefresh);
            this.panelBTNS.Location = new System.Drawing.Point(567, 4);
            this.panelBTNS.Margin = new System.Windows.Forms.Padding(4);
            this.panelBTNS.Name = "panelBTNS";
            this.panelBTNS.Size = new System.Drawing.Size(259, 34);
            this.panelBTNS.TabIndex = 0;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.barraMenu);
            this.Controls.Add(this.barraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskManager";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.TaskManager_Load);
            this.barraSuperior.ResumeLayout(false);
            this.barraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.barraMenu.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.panelBTNS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Panel barraMenu;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNProcesos;
        private System.Windows.Forms.Button BTNRendimiento;
        private System.Windows.Forms.Panel panelBTNProcesos;
        private System.Windows.Forms.Panel panelBTNRendimiento;
        private System.Windows.Forms.Button BTNMenu;
        private System.Windows.Forms.Panel panelBTNMenu;
        private System.Windows.Forms.Button BTNRefresh;
        private System.Windows.Forms.Button BTNEndTask;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelBTNS;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblProcStatus;
        private System.Windows.Forms.Label lblClockSpeed;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label label6;
        private CircularProgressBar.CircularProgressBar cpuPB;
        private System.Windows.Forms.Label label5;
        private CircularProgressBar.CircularProgressBar ramPB;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar diskPB;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader processName;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader memory;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader cpu;
        private System.Windows.Forms.ColumnHeader disk;
    }
}

