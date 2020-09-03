namespace GPS_Sim
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HelpMeButton = new System.Windows.Forms.Button();
            this.i2ApiButton = new System.Windows.Forms.Button();
            this.replayButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.generateTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.generateFileButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileToConvertPathBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generateHeading = new System.Windows.Forms.Label();
            this.replayTabHeader = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSpeed = new System.Windows.Forms.ComboBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblRepeats = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblConnected = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.cmbCOMPort = new System.Windows.Forms.ComboBox();
            this.lblBaud = new System.Windows.Forms.Label();
            this.lblCOMPort = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtxtDataArea = new System.Windows.Forms.RichTextBox();
            this.replayHeading = new System.Windows.Forms.Label();
            this.i2ApiTab = new System.Windows.Forms.TabPage();
            this.moteci2ApiHeading = new System.Windows.Forms.Label();
            this.helpTab = new System.Windows.Forms.TabPage();
            this.helpHeading = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.selectFileLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.generateTab.SuspendLayout();
            this.replayTabHeader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.i2ApiTab.SuspendLayout();
            this.helpTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HelpMeButton);
            this.panel1.Controls.Add(this.i2ApiButton);
            this.panel1.Controls.Add(this.replayButton);
            this.panel1.Controls.Add(this.generateButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 576);
            this.panel1.TabIndex = 0;
            // 
            // HelpMeButton
            // 
            this.HelpMeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelpMeButton.FlatAppearance.BorderSize = 0;
            this.HelpMeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpMeButton.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpMeButton.Image = global::GPS_Sim.Properties.Resources._007_cars_15percent_2;
            this.HelpMeButton.Location = new System.Drawing.Point(0, 358);
            this.HelpMeButton.Name = "HelpMeButton";
            this.HelpMeButton.Size = new System.Drawing.Size(149, 86);
            this.HelpMeButton.TabIndex = 6;
            this.HelpMeButton.Text = "Help";
            this.HelpMeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HelpMeButton.UseVisualStyleBackColor = true;
            this.HelpMeButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // i2ApiButton
            // 
            this.i2ApiButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.i2ApiButton.FlatAppearance.BorderSize = 0;
            this.i2ApiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.i2ApiButton.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i2ApiButton.Image = global::GPS_Sim.Properties.Resources._007_cars_15percent_2;
            this.i2ApiButton.Location = new System.Drawing.Point(0, 272);
            this.i2ApiButton.Name = "i2ApiButton";
            this.i2ApiButton.Size = new System.Drawing.Size(149, 86);
            this.i2ApiButton.TabIndex = 5;
            this.i2ApiButton.Text = "i2 API";
            this.i2ApiButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.i2ApiButton.UseVisualStyleBackColor = true;
            this.i2ApiButton.Click += new System.EventHandler(this.i2ApiButton_Click);
            // 
            // replayButton
            // 
            this.replayButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.replayButton.FlatAppearance.BorderSize = 0;
            this.replayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replayButton.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayButton.Image = global::GPS_Sim.Properties.Resources._007_cars_15percent_2;
            this.replayButton.Location = new System.Drawing.Point(0, 186);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(149, 86);
            this.replayButton.TabIndex = 4;
            this.replayButton.Text = "Replay";
            this.replayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.generateButton.FlatAppearance.BorderSize = 0;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Image = global::GPS_Sim.Properties.Resources._007_cars_15percent_2;
            this.generateButton.Location = new System.Drawing.Point(0, 100);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(149, 86);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(132)))), ((int)(((byte)(168)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 100);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("FuturistFixedWidth", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "SIM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FuturistFixedWidth", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.panelLeft.Location = new System.Drawing.Point(139, 100);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 86);
            this.panelLeft.TabIndex = 2;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.generateTab);
            this.mainTab.Controls.Add(this.replayTabHeader);
            this.mainTab.Controls.Add(this.i2ApiTab);
            this.mainTab.Controls.Add(this.helpTab);
            this.mainTab.Location = new System.Drawing.Point(139, -12);
            this.mainTab.Margin = new System.Windows.Forms.Padding(0);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Drawing.Point(0, 0);
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(666, 592);
            this.mainTab.TabIndex = 3;
            this.mainTab.TabStop = false;
            // 
            // generateTab
            // 
            this.generateTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.generateTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.generateTab.Controls.Add(this.label4);
            this.generateTab.Controls.Add(this.consoleTextBox);
            this.generateTab.Controls.Add(this.generateFileButton);
            this.generateTab.Controls.Add(this.browseButton);
            this.generateTab.Controls.Add(this.fileToConvertPathBox);
            this.generateTab.Controls.Add(this.label3);
            this.generateTab.Controls.Add(this.generateHeading);
            this.generateTab.Location = new System.Drawing.Point(4, 28);
            this.generateTab.Name = "generateTab";
            this.generateTab.Padding = new System.Windows.Forms.Padding(3);
            this.generateTab.Size = new System.Drawing.Size(658, 560);
            this.generateTab.TabIndex = 0;
            this.generateTab.Text = "gen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Console Output:";
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.consoleTextBox.Location = new System.Drawing.Point(73, 207);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(485, 199);
            this.consoleTextBox.TabIndex = 7;
            this.consoleTextBox.Text = "";
            // 
            // generateFileButton
            // 
            this.generateFileButton.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.generateFileButton.Location = new System.Drawing.Point(230, 137);
            this.generateFileButton.Name = "generateFileButton";
            this.generateFileButton.Size = new System.Drawing.Size(148, 37);
            this.generateFileButton.TabIndex = 6;
            this.generateFileButton.Text = "Generate";
            this.generateFileButton.UseVisualStyleBackColor = true;
            this.generateFileButton.Click += new System.EventHandler(this.generateFileButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.browseButton.Location = new System.Drawing.Point(561, 88);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 26);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileToConvertPathBox
            // 
            this.fileToConvertPathBox.Location = new System.Drawing.Point(73, 87);
            this.fileToConvertPathBox.Name = "fileToConvertPathBox";
            this.fileToConvertPathBox.Size = new System.Drawing.Size(472, 27);
            this.fileToConvertPathBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose a file to convert:";
            // 
            // generateHeading
            // 
            this.generateHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateHeading.AutoSize = true;
            this.generateHeading.Font = new System.Drawing.Font("FuturistFixedWidth", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.generateHeading.Location = new System.Drawing.Point(203, 4);
            this.generateHeading.Name = "generateHeading";
            this.generateHeading.Size = new System.Drawing.Size(247, 36);
            this.generateHeading.TabIndex = 2;
            this.generateHeading.Text = "GENERATE";
            this.generateHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // replayTabHeader
            // 
            this.replayTabHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.replayTabHeader.Controls.Add(this.comboBox1);
            this.replayTabHeader.Controls.Add(this.selectFileLbl);
            this.replayTabHeader.Controls.Add(this.btnStop);
            this.replayTabHeader.Controls.Add(this.btnSend);
            this.replayTabHeader.Controls.Add(this.groupBox2);
            this.replayTabHeader.Controls.Add(this.lblConnected);
            this.replayTabHeader.Controls.Add(this.btnConnect);
            this.replayTabHeader.Controls.Add(this.groupBox1);
            this.replayTabHeader.Controls.Add(this.btnClear);
            this.replayTabHeader.Controls.Add(this.rtxtDataArea);
            this.replayTabHeader.Controls.Add(this.replayHeading);
            this.replayTabHeader.Location = new System.Drawing.Point(4, 28);
            this.replayTabHeader.Name = "replayTabHeader";
            this.replayTabHeader.Padding = new System.Windows.Forms.Padding(3);
            this.replayTabHeader.Size = new System.Drawing.Size(658, 560);
            this.replayTabHeader.TabIndex = 1;
            this.replayTabHeader.Text = "rep";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.btnStop.Location = new System.Drawing.Point(41, 451);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 32);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.btnSend.Location = new System.Drawing.Point(162, 451);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 32);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSpeed);
            this.groupBox2.Controls.Add(this.txtSpeed);
            this.groupBox2.Controls.Add(this.lblSpeed);
            this.groupBox2.Controls.Add(this.lblRepeats);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 86);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Settings";
            // 
            // cmbSpeed
            // 
            this.cmbSpeed.FormattingEnabled = true;
            this.cmbSpeed.Items.AddRange(new object[] {
            "1x",
            "1.25x",
            "1.5x",
            "2x",
            "5x",
            "10x"});
            this.cmbSpeed.Location = new System.Drawing.Point(104, 53);
            this.cmbSpeed.Name = "cmbSpeed";
            this.cmbSpeed.Size = new System.Drawing.Size(121, 27);
            this.cmbSpeed.TabIndex = 5;
            this.cmbSpeed.Text = "1x";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(150, 20);
            this.txtSpeed.MaxLength = 32;
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(75, 27);
            this.txtSpeed.TabIndex = 4;
            this.txtSpeed.Text = "0";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(6, 56);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(59, 19);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblRepeats
            // 
            this.lblRepeats.AutoSize = true;
            this.lblRepeats.Location = new System.Drawing.Point(6, 26);
            this.lblRepeats.Name = "lblRepeats";
            this.lblRepeats.Size = new System.Drawing.Size(143, 19);
            this.lblRepeats.TabIndex = 2;
            this.lblRepeats.Text = "Repeats: (0 = Loop)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 2;
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Location = new System.Drawing.Point(26, 318);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(236, 19);
            this.lblConnected.TabIndex = 19;
            this.lblConnected.Text = "Successfully connected to COM1";
            this.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConnected.Visible = false;
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.btnConnect.Location = new System.Drawing.Point(88, 277);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(83, 34);
            this.btnConnect.TabIndex = 18;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBaud);
            this.groupBox1.Controls.Add(this.cmbCOMPort);
            this.groupBox1.Controls.Add(this.lblBaud);
            this.groupBox1.Controls.Add(this.lblCOMPort);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 83);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port Serial Settings";
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaud.Location = new System.Drawing.Point(104, 50);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(121, 27);
            this.cmbBaud.TabIndex = 3;
            this.cmbBaud.Text = "19200";
            // 
            // cmbCOMPort
            // 
            this.cmbCOMPort.FormattingEnabled = true;
            this.cmbCOMPort.Location = new System.Drawing.Point(104, 23);
            this.cmbCOMPort.Name = "cmbCOMPort";
            this.cmbCOMPort.Size = new System.Drawing.Size(121, 27);
            this.cmbCOMPort.TabIndex = 2;
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(6, 55);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(86, 19);
            this.lblBaud.TabIndex = 1;
            this.lblBaud.Text = "Baud Rate:";
            // 
            // lblCOMPort
            // 
            this.lblCOMPort.AutoSize = true;
            this.lblCOMPort.Location = new System.Drawing.Point(6, 26);
            this.lblCOMPort.Name = "lblCOMPort";
            this.lblCOMPort.Size = new System.Drawing.Size(78, 19);
            this.lblCOMPort.TabIndex = 0;
            this.lblCOMPort.Text = "COM Port:";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.btnClear.Location = new System.Drawing.Point(424, 526);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // rtxtDataArea
            // 
            this.rtxtDataArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.rtxtDataArea.Location = new System.Drawing.Point(268, 190);
            this.rtxtDataArea.Name = "rtxtDataArea";
            this.rtxtDataArea.ReadOnly = true;
            this.rtxtDataArea.Size = new System.Drawing.Size(384, 330);
            this.rtxtDataArea.TabIndex = 15;
            this.rtxtDataArea.Text = "";
            // 
            // replayHeading
            // 
            this.replayHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.replayHeading.AutoSize = true;
            this.replayHeading.Font = new System.Drawing.Font("FuturistFixedWidth", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.replayHeading.Location = new System.Drawing.Point(227, 3);
            this.replayHeading.Name = "replayHeading";
            this.replayHeading.Size = new System.Drawing.Size(189, 36);
            this.replayHeading.TabIndex = 2;
            this.replayHeading.Text = "REPLAY";
            this.replayHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // i2ApiTab
            // 
            this.i2ApiTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.i2ApiTab.Controls.Add(this.moteci2ApiHeading);
            this.i2ApiTab.Location = new System.Drawing.Point(4, 28);
            this.i2ApiTab.Name = "i2ApiTab";
            this.i2ApiTab.Size = new System.Drawing.Size(658, 412);
            this.i2ApiTab.TabIndex = 2;
            this.i2ApiTab.Text = "i2";
            // 
            // moteci2ApiHeading
            // 
            this.moteci2ApiHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moteci2ApiHeading.AutoSize = true;
            this.moteci2ApiHeading.Font = new System.Drawing.Font("FuturistFixedWidth", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moteci2ApiHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.moteci2ApiHeading.Location = new System.Drawing.Point(151, -6);
            this.moteci2ApiHeading.Name = "moteci2ApiHeading";
            this.moteci2ApiHeading.Size = new System.Drawing.Size(363, 36);
            this.moteci2ApiHeading.TabIndex = 3;
            this.moteci2ApiHeading.Text = "MoTeC i2 API";
            this.moteci2ApiHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpTab
            // 
            this.helpTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.helpTab.Controls.Add(this.helpHeading);
            this.helpTab.Location = new System.Drawing.Point(4, 28);
            this.helpTab.Name = "helpTab";
            this.helpTab.Size = new System.Drawing.Size(658, 412);
            this.helpTab.TabIndex = 3;
            this.helpTab.Text = "help";
            // 
            // helpHeading
            // 
            this.helpHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpHeading.AutoSize = true;
            this.helpHeading.Font = new System.Drawing.Font("FuturistFixedWidth", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.helpHeading.Location = new System.Drawing.Point(260, -6);
            this.helpHeading.Name = "helpHeading";
            this.helpHeading.Size = new System.Drawing.Size(131, 36);
            this.helpHeading.TabIndex = 4;
            this.helpHeading.Text = "HELP";
            this.helpHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // selectFileLbl
            // 
            this.selectFileLbl.AutoSize = true;
            this.selectFileLbl.Location = new System.Drawing.Point(12, 46);
            this.selectFileLbl.Name = "selectFileLbl";
            this.selectFileLbl.Size = new System.Drawing.Size(151, 19);
            this.selectFileLbl.TabIndex = 23;
            this.selectFileLbl.Text = "Select file to replay:";
            this.selectFileLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectFileLbl.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(472, 27);
            this.comboBox1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainTab);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.mainTab.ResumeLayout(false);
            this.generateTab.ResumeLayout(false);
            this.generateTab.PerformLayout();
            this.replayTabHeader.ResumeLayout(false);
            this.replayTabHeader.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.i2ApiTab.ResumeLayout(false);
            this.i2ApiTab.PerformLayout();
            this.helpTab.ResumeLayout(false);
            this.helpTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HelpMeButton;
        private System.Windows.Forms.Button i2ApiButton;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage generateTab;
        private System.Windows.Forms.TabPage replayTabHeader;
        private System.Windows.Forms.TabPage i2ApiTab;
        private System.Windows.Forms.TabPage helpTab;
        private System.Windows.Forms.Label generateHeading;
        private System.Windows.Forms.Label replayHeading;
        private System.Windows.Forms.Label moteci2ApiHeading;
        private System.Windows.Forms.Label helpHeading;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.MaskedTextBox fileToConvertPathBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.Button generateFileButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSpeed;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblRepeats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.Label lblCOMPort;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtxtDataArea;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label selectFileLbl;
        protected internal System.Windows.Forms.ComboBox cmbCOMPort;
        protected internal System.ComponentModel.BackgroundWorker backgroundWorker1;
        protected internal System.Windows.Forms.ComboBox cmbBaud;
        protected internal System.Windows.Forms.Button btnSend;
        protected internal System.Windows.Forms.Button btnStop;
        protected internal System.Windows.Forms.Button btnConnect;
        protected internal System.Windows.Forms.Label lblConnected;
    }
}

