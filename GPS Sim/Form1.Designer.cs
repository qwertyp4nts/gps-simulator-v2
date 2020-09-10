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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.replayBrowseButton = new System.Windows.Forms.Button();
            this.fileToReplayBox = new System.Windows.Forms.ComboBox();
            this.selectFileLbl = new System.Windows.Forms.Label();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.fileToConvertOutputDir = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.generateTab.SuspendLayout();
            this.replayTabHeader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.i2ApiTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.replayButton);
            this.panel1.Controls.Add(this.generateButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.i2ApiButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // i2ApiButton
            // 
            resources.ApplyResources(this.i2ApiButton, "i2ApiButton");
            this.i2ApiButton.FlatAppearance.BorderSize = 0;
            this.i2ApiButton.Image = global::GPS_Sim.Properties.Resources._007_cars_15percent_2;
            this.i2ApiButton.Name = "i2ApiButton";
            this.i2ApiButton.UseVisualStyleBackColor = true;
            this.i2ApiButton.Click += new System.EventHandler(this.i2ApiButton_Click);
            // 
            // replayButton
            // 
            resources.ApplyResources(this.replayButton, "replayButton");
            this.replayButton.FlatAppearance.BorderSize = 0;
            this.replayButton.Image = global::GPS_Sim.Properties.Resources._007_cars_15percent_2;
            this.replayButton.Name = "replayButton";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // generateButton
            // 
            resources.ApplyResources(this.generateButton, "generateButton");
            this.generateButton.FlatAppearance.BorderSize = 0;
            this.generateButton.Image = global::GPS_Sim.Properties.Resources._007_cars_15percent_2;
            this.generateButton.Name = "generateButton";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(132)))), ((int)(((byte)(168)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.label1.Name = "label1";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            resources.ApplyResources(this.panelLeft, "panelLeft");
            this.panelLeft.Name = "panelLeft";
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.replayTabHeader);
            this.mainTab.Controls.Add(this.generateTab);
            this.mainTab.Controls.Add(this.i2ApiTab);
            resources.ApplyResources(this.mainTab, "mainTab");
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.TabStop = false;
            // 
            // generateTab
            // 
            this.generateTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            resources.ApplyResources(this.generateTab, "generateTab");
            this.generateTab.Controls.Add(this.fileToConvertOutputDir);
            this.generateTab.Controls.Add(this.label5);
            this.generateTab.Controls.Add(this.label4);
            this.generateTab.Controls.Add(this.consoleTextBox);
            this.generateTab.Controls.Add(this.generateFileButton);
            this.generateTab.Controls.Add(this.browseButton);
            this.generateTab.Controls.Add(this.fileToConvertPathBox);
            this.generateTab.Controls.Add(this.label3);
            this.generateTab.Controls.Add(this.generateHeading);
            this.generateTab.Name = "generateTab";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            resources.ApplyResources(this.consoleTextBox, "consoleTextBox");
            this.consoleTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.consoleTextBox.Name = "consoleTextBox";
            // 
            // generateFileButton
            // 
            resources.ApplyResources(this.generateFileButton, "generateFileButton");
            this.generateFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.generateFileButton.Name = "generateFileButton";
            this.generateFileButton.UseVisualStyleBackColor = true;
            this.generateFileButton.Click += new System.EventHandler(this.generateFileButton_Click);
            // 
            // browseButton
            // 
            resources.ApplyResources(this.browseButton, "browseButton");
            this.browseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.browseButton.Name = "browseButton";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileToConvertPathBox
            // 
            resources.ApplyResources(this.fileToConvertPathBox, "fileToConvertPathBox");
            this.fileToConvertPathBox.Name = "fileToConvertPathBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // generateHeading
            // 
            resources.ApplyResources(this.generateHeading, "generateHeading");
            this.generateHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.generateHeading.Name = "generateHeading";
            // 
            // replayTabHeader
            // 
            this.replayTabHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.replayTabHeader.Controls.Add(this.replayBrowseButton);
            this.replayTabHeader.Controls.Add(this.fileToReplayBox);
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
            resources.ApplyResources(this.replayTabHeader, "replayTabHeader");
            this.replayTabHeader.Name = "replayTabHeader";
            // 
            // replayBrowseButton
            // 
            resources.ApplyResources(this.replayBrowseButton, "replayBrowseButton");
            this.replayBrowseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.replayBrowseButton.Name = "replayBrowseButton";
            this.replayBrowseButton.UseVisualStyleBackColor = true;
            this.replayBrowseButton.Click += new System.EventHandler(this.replayBrowseButton_Click);
            // 
            // fileToReplayBox
            // 
            resources.ApplyResources(this.fileToReplayBox, "fileToReplayBox");
            this.fileToReplayBox.FormattingEnabled = true;
            this.fileToReplayBox.Name = "fileToReplayBox";
            // 
            // selectFileLbl
            // 
            resources.ApplyResources(this.selectFileLbl, "selectFileLbl");
            this.selectFileLbl.Name = "selectFileLbl";
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.btnSend.Name = "btnSend";
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
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cmbSpeed
            // 
            this.cmbSpeed.FormattingEnabled = true;
            this.cmbSpeed.Items.AddRange(new object[] {
            resources.GetString("cmbSpeed.Items"),
            resources.GetString("cmbSpeed.Items1"),
            resources.GetString("cmbSpeed.Items2"),
            resources.GetString("cmbSpeed.Items3"),
            resources.GetString("cmbSpeed.Items4"),
            resources.GetString("cmbSpeed.Items5")});
            resources.ApplyResources(this.cmbSpeed, "cmbSpeed");
            this.cmbSpeed.Name = "cmbSpeed";
            // 
            // txtSpeed
            // 
            resources.ApplyResources(this.txtSpeed, "txtSpeed");
            this.txtSpeed.Name = "txtSpeed";
            // 
            // lblSpeed
            // 
            resources.ApplyResources(this.lblSpeed, "lblSpeed");
            this.lblSpeed.Name = "lblSpeed";
            // 
            // lblRepeats
            // 
            resources.ApplyResources(this.lblRepeats, "lblRepeats");
            this.lblRepeats.Name = "lblRepeats";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lblConnected
            // 
            resources.ApplyResources(this.lblConnected, "lblConnected");
            this.lblConnected.Name = "lblConnected";
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBaud);
            this.groupBox1.Controls.Add(this.cmbCOMPort);
            this.groupBox1.Controls.Add(this.lblBaud);
            this.groupBox1.Controls.Add(this.lblCOMPort);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            resources.GetString("cmbBaud.Items"),
            resources.GetString("cmbBaud.Items1"),
            resources.GetString("cmbBaud.Items2"),
            resources.GetString("cmbBaud.Items3"),
            resources.GetString("cmbBaud.Items4"),
            resources.GetString("cmbBaud.Items5"),
            resources.GetString("cmbBaud.Items6"),
            resources.GetString("cmbBaud.Items7")});
            resources.ApplyResources(this.cmbBaud, "cmbBaud");
            this.cmbBaud.Name = "cmbBaud";
            // 
            // cmbCOMPort
            // 
            this.cmbCOMPort.FormattingEnabled = true;
            resources.ApplyResources(this.cmbCOMPort, "cmbCOMPort");
            this.cmbCOMPort.Name = "cmbCOMPort";
            // 
            // lblBaud
            // 
            resources.ApplyResources(this.lblBaud, "lblBaud");
            this.lblBaud.Name = "lblBaud";
            // 
            // lblCOMPort
            // 
            resources.ApplyResources(this.lblCOMPort, "lblCOMPort");
            this.lblCOMPort.Name = "lblCOMPort";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rtxtDataArea
            // 
            this.rtxtDataArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            resources.ApplyResources(this.rtxtDataArea, "rtxtDataArea");
            this.rtxtDataArea.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxtDataArea.Name = "rtxtDataArea";
            this.rtxtDataArea.ReadOnly = true;
            this.rtxtDataArea.TextChanged += new System.EventHandler(this.rtxtDataArea_TextChanged);
            // 
            // replayHeading
            // 
            resources.ApplyResources(this.replayHeading, "replayHeading");
            this.replayHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.replayHeading.Name = "replayHeading";
            // 
            // i2ApiTab
            // 
            this.i2ApiTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.i2ApiTab.Controls.Add(this.moteci2ApiHeading);
            resources.ApplyResources(this.i2ApiTab, "i2ApiTab");
            this.i2ApiTab.Name = "i2ApiTab";
            // 
            // moteci2ApiHeading
            // 
            resources.ApplyResources(this.moteci2ApiHeading, "moteci2ApiHeading");
            this.moteci2ApiHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.moteci2ApiHeading.Name = "moteci2ApiHeading";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // fileToConvertOutputDir
            // 
            resources.ApplyResources(this.fileToConvertOutputDir, "fileToConvertOutputDir");
            this.fileToConvertOutputDir.Name = "fileToConvertOutputDir";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainTab);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(216)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label generateHeading;
        private System.Windows.Forms.Label replayHeading;
        private System.Windows.Forms.Label moteci2ApiHeading;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblRepeats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.Label lblCOMPort;
        private System.Windows.Forms.Button btnClear;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label selectFileLbl;
        protected internal System.Windows.Forms.ComboBox cmbCOMPort;
        protected internal System.ComponentModel.BackgroundWorker backgroundWorker1;
        protected internal System.Windows.Forms.ComboBox cmbBaud;
        protected internal System.Windows.Forms.Button btnSend;
        protected internal System.Windows.Forms.Button btnStop;
        protected internal System.Windows.Forms.Button btnConnect;
        protected internal System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button replayBrowseButton;
        protected internal System.Windows.Forms.TextBox txtSpeed;
        protected internal System.Windows.Forms.RichTextBox rtxtDataArea;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.MaskedTextBox fileToConvertPathBox;
        protected internal System.Windows.Forms.MaskedTextBox fileToConvertOutputDir;
        protected internal System.Windows.Forms.RichTextBox consoleTextBox;
        protected internal System.Windows.Forms.Button generateFileButton;
        protected internal System.Windows.Forms.ComboBox fileToReplayBox;
    }
}

