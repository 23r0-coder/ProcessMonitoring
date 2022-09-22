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
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cpuPB = new CircularProgressBar.CircularProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.ramPB = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.gpuPB = new CircularProgressBar.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.diskPB = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.netPB = new CircularProgressBar.CircularProgressBar();
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
            this.lblClock = new System.Windows.Forms.Label();
            this.lblBattery = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblClockSpeed = new System.Windows.Forms.Label();
            this.lblProcStatus = new System.Windows.Forms.Label();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.barraMenu.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(800, 35);
            this.barraSuperior.TabIndex = 0;
            this.barraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task Manager";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(771, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
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
            this.barraMenu.Location = new System.Drawing.Point(0, 35);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(145, 465);
            this.barraMenu.TabIndex = 1;
            // 
            // panelBTNMenu
            // 
            this.panelBTNMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.panelBTNMenu.Location = new System.Drawing.Point(2, 0);
            this.panelBTNMenu.Name = "panelBTNMenu";
            this.panelBTNMenu.Size = new System.Drawing.Size(3, 32);
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
            this.BTNMenu.Location = new System.Drawing.Point(5, 0);
            this.BTNMenu.Name = "BTNMenu";
            this.BTNMenu.Size = new System.Drawing.Size(138, 32);
            this.BTNMenu.TabIndex = 2;
            this.BTNMenu.UseVisualStyleBackColor = false;
            this.BTNMenu.Click += new System.EventHandler(this.BTNMenu_Click);
            this.BTNMenu.MouseLeave += new System.EventHandler(this.BTNMenu_MouseLeave);
            this.BTNMenu.MouseHover += new System.EventHandler(this.BTNMenu_MouseHover);
            // 
            // panelBTNRendimiento
            // 
            this.panelBTNRendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.panelBTNRendimiento.Location = new System.Drawing.Point(2, 69);
            this.panelBTNRendimiento.Name = "panelBTNRendimiento";
            this.panelBTNRendimiento.Size = new System.Drawing.Size(3, 32);
            this.panelBTNRendimiento.TabIndex = 1;
            this.panelBTNRendimiento.Visible = false;
            // 
            // panelBTNProcesos
            // 
            this.panelBTNProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.panelBTNProcesos.Location = new System.Drawing.Point(2, 35);
            this.panelBTNProcesos.Name = "panelBTNProcesos";
            this.panelBTNProcesos.Size = new System.Drawing.Size(3, 32);
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
            this.BTNRendimiento.Location = new System.Drawing.Point(5, 69);
            this.BTNRendimiento.Name = "BTNRendimiento";
            this.BTNRendimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTNRendimiento.Size = new System.Drawing.Size(138, 32);
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
            this.BTNProcesos.Location = new System.Drawing.Point(5, 35);
            this.BTNProcesos.Name = "BTNProcesos";
            this.BTNProcesos.Size = new System.Drawing.Size(138, 32);
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
            this.panelInfo.Location = new System.Drawing.Point(145, 35);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(655, 68);
            this.panelInfo.TabIndex = 2;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelCentral.Controls.Add(this.panel1);
            this.panelCentral.Controls.Add(this.listView1);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(145, 103);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(655, 397);
            this.panelCentral.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.lblProcStatus);
            this.panel1.Controls.Add(this.lblClockSpeed);
            this.panel1.Controls.Add(this.lblCPU);
            this.panel1.Controls.Add(this.lblBattery);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cpuPB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ramPB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.gpuPB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.diskPB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.netPB);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 397);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(310, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "CPU";
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
            this.cpuPB.Location = new System.Drawing.Point(274, 43);
            this.cpuPB.MarqueeAnimationSpeed = 2000;
            this.cpuPB.Name = "cpuPB";
            this.cpuPB.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.cpuPB.OuterMargin = -25;
            this.cpuPB.OuterWidth = 26;
            this.cpuPB.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.cpuPB.ProgressWidth = 6;
            this.cpuPB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuPB.Size = new System.Drawing.Size(105, 105);
            this.cpuPB.StartAngle = 270;
            this.cpuPB.SubscriptColor = System.Drawing.Color.White;
            this.cpuPB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpuPB.SubscriptText = "";
            this.cpuPB.SuperscriptColor = System.Drawing.Color.White;
            this.cpuPB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpuPB.SuperscriptText = "";
            this.cpuPB.TabIndex = 4;
            this.cpuPB.Text = "%";
            this.cpuPB.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpuPB.Value = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "RAM";
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
            this.ramPB.Location = new System.Drawing.Point(18, 58);
            this.ramPB.MarqueeAnimationSpeed = 2000;
            this.ramPB.Name = "ramPB";
            this.ramPB.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.ramPB.OuterMargin = -25;
            this.ramPB.OuterWidth = 26;
            this.ramPB.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.ramPB.ProgressWidth = 6;
            this.ramPB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramPB.Size = new System.Drawing.Size(90, 90);
            this.ramPB.StartAngle = 270;
            this.ramPB.SubscriptColor = System.Drawing.Color.White;
            this.ramPB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ramPB.SubscriptText = "";
            this.ramPB.SuperscriptColor = System.Drawing.Color.White;
            this.ramPB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ramPB.SuperscriptText = "";
            this.ramPB.TabIndex = 2;
            this.ramPB.Text = "%";
            this.ramPB.TextMargin = new System.Windows.Forms.Padding(0);
            this.ramPB.Value = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(574, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "GPU";
            // 
            // gpuPB
            // 
            this.gpuPB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.gpuPB.AnimationSpeed = 500;
            this.gpuPB.BackColor = System.Drawing.Color.Transparent;
            this.gpuPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuPB.ForeColor = System.Drawing.Color.White;
            this.gpuPB.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.gpuPB.InnerMargin = 2;
            this.gpuPB.InnerWidth = -1;
            this.gpuPB.Location = new System.Drawing.Point(545, 58);
            this.gpuPB.MarqueeAnimationSpeed = 2000;
            this.gpuPB.Name = "gpuPB";
            this.gpuPB.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.gpuPB.OuterMargin = -25;
            this.gpuPB.OuterWidth = 26;
            this.gpuPB.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.gpuPB.ProgressWidth = 6;
            this.gpuPB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuPB.Size = new System.Drawing.Size(90, 90);
            this.gpuPB.StartAngle = 270;
            this.gpuPB.SubscriptColor = System.Drawing.Color.White;
            this.gpuPB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.gpuPB.SubscriptText = "";
            this.gpuPB.SuperscriptColor = System.Drawing.Color.White;
            this.gpuPB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.gpuPB.SuperscriptText = "";
            this.gpuPB.TabIndex = 0;
            this.gpuPB.Text = "%";
            this.gpuPB.TextMargin = new System.Windows.Forms.Padding(0);
            this.gpuPB.Value = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "DISK";
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
            this.diskPB.Location = new System.Drawing.Point(146, 58);
            this.diskPB.MarqueeAnimationSpeed = 2000;
            this.diskPB.Name = "diskPB";
            this.diskPB.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.diskPB.OuterMargin = -25;
            this.diskPB.OuterWidth = 26;
            this.diskPB.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.diskPB.ProgressWidth = 6;
            this.diskPB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskPB.Size = new System.Drawing.Size(90, 90);
            this.diskPB.StartAngle = 270;
            this.diskPB.SubscriptColor = System.Drawing.Color.White;
            this.diskPB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.diskPB.SubscriptText = "";
            this.diskPB.SuperscriptColor = System.Drawing.Color.White;
            this.diskPB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.diskPB.SuperscriptText = "";
            this.diskPB.TabIndex = 0;
            this.diskPB.Text = "%";
            this.diskPB.TextMargin = new System.Windows.Forms.Padding(0);
            this.diskPB.Value = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(431, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NETWORK";
            // 
            // netPB
            // 
            this.netPB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.netPB.AnimationSpeed = 500;
            this.netPB.BackColor = System.Drawing.Color.Transparent;
            this.netPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netPB.ForeColor = System.Drawing.Color.White;
            this.netPB.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.netPB.InnerMargin = 2;
            this.netPB.InnerWidth = -1;
            this.netPB.Location = new System.Drawing.Point(421, 58);
            this.netPB.MarqueeAnimationSpeed = 2000;
            this.netPB.Name = "netPB";
            this.netPB.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.netPB.OuterMargin = -25;
            this.netPB.OuterWidth = 26;
            this.netPB.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(183)))), ((int)(((byte)(223)))));
            this.netPB.ProgressWidth = 6;
            this.netPB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netPB.Size = new System.Drawing.Size(90, 90);
            this.netPB.StartAngle = 270;
            this.netPB.SubscriptColor = System.Drawing.Color.White;
            this.netPB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.netPB.SubscriptText = "";
            this.netPB.SuperscriptColor = System.Drawing.Color.White;
            this.netPB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.netPB.SuperscriptText = "";
            this.netPB.TabIndex = 0;
            this.netPB.Text = "%";
            this.netPB.TextMargin = new System.Windows.Forms.Padding(0);
            this.netPB.Value = 68;
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
            this.listView1.Location = new System.Drawing.Point(2, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(652, 365);
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
            this.BTNRefresh.Location = new System.Drawing.Point(4, 2);
            this.BTNRefresh.Name = "BTNRefresh";
            this.BTNRefresh.Size = new System.Drawing.Size(97, 23);
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
            this.BTNEndTask.Location = new System.Drawing.Point(107, 2);
            this.BTNEndTask.Name = "BTNEndTask";
            this.BTNEndTask.Size = new System.Drawing.Size(101, 23);
            this.BTNEndTask.TabIndex = 1;
            this.BTNEndTask.Text = "End Task";
            this.BTNEndTask.UseVisualStyleBackColor = false;
            this.BTNEndTask.Click += new System.EventHandler(this.BTNEndTask_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(103, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelBTNS
            // 
            this.panelBTNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelBTNS.Controls.Add(this.button1);
            this.panelBTNS.Controls.Add(this.BTNEndTask);
            this.panelBTNS.Controls.Add(this.BTNRefresh);
            this.panelBTNS.Location = new System.Drawing.Point(606, 104);
            this.panelBTNS.Name = "panelBTNS";
            this.panelBTNS.Size = new System.Drawing.Size(194, 28);
            this.panelBTNS.TabIndex = 0;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(175, 24);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(45, 17);
            this.lblClock.TabIndex = 8;
            this.lblClock.Text = "label7";
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattery.ForeColor = System.Drawing.Color.White;
            this.lblBattery.Location = new System.Drawing.Point(20, 233);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(57, 21);
            this.lblBattery.TabIndex = 8;
            this.lblBattery.Text = "label7";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.White;
            this.lblCPU.Location = new System.Drawing.Point(20, 268);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(57, 21);
            this.lblCPU.TabIndex = 8;
            this.lblCPU.Text = "label7";
            // 
            // lblClockSpeed
            // 
            this.lblClockSpeed.AutoSize = true;
            this.lblClockSpeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockSpeed.ForeColor = System.Drawing.Color.White;
            this.lblClockSpeed.Location = new System.Drawing.Point(20, 304);
            this.lblClockSpeed.Name = "lblClockSpeed";
            this.lblClockSpeed.Size = new System.Drawing.Size(57, 21);
            this.lblClockSpeed.TabIndex = 8;
            this.lblClockSpeed.Text = "label7";
            // 
            // lblProcStatus
            // 
            this.lblProcStatus.AutoSize = true;
            this.lblProcStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcStatus.ForeColor = System.Drawing.Color.White;
            this.lblProcStatus.Location = new System.Drawing.Point(20, 340);
            this.lblProcStatus.Name = "lblProcStatus";
            this.lblProcStatus.Size = new System.Drawing.Size(57, 21);
            this.lblProcStatus.TabIndex = 8;
            this.lblProcStatus.Text = "label7";
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelBTNS);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.barraMenu);
            this.Controls.Add(this.barraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader processName;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader cpu;
        private System.Windows.Forms.ColumnHeader memory;
        private System.Windows.Forms.ColumnHeader disk;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader description;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar netPB;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar gpuPB;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar diskPB;
        private System.Windows.Forms.Label label5;
        private CircularProgressBar.CircularProgressBar ramPB;
        private System.Windows.Forms.Button BTNRefresh;
        private System.Windows.Forms.Button BTNEndTask;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelBTNS;
        private System.Windows.Forms.Label label6;
        private CircularProgressBar.CircularProgressBar cpuPB;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblClockSpeed;
        private System.Windows.Forms.Label lblProcStatus;
    }
}

