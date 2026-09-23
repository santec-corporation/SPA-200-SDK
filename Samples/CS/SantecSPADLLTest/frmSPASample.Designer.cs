namespace SantecSPADLLTest
{
    partial class frmMain
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
            this.btnInitialize = new System.Windows.Forms.Button();
            this.btnReference = new System.Windows.Forms.Button();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.btnLoadDSPA = new System.Windows.Forms.Button();
            this.dlgLoadDSPA = new System.Windows.Forms.OpenFileDialog();
            this.plotMain = new ScottPlot.FormsPlot();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSaveDSPA = new System.Windows.Forms.Button();
            this.btnExitStandby = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSPADevice = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbTSLType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTSLDevice = new System.Windows.Forms.ComboBox();
            this.edPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edIPAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edTSLGPIBAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbConnectionFile = new System.Windows.Forms.CheckBox();
            this.plotWDL = new ScottPlot.FormsPlot();
            this.btnProcessWDL = new System.Windows.Forms.Button();
            this.edWDLXMin = new System.Windows.Forms.TextBox();
            this.edWDLXMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDefaultRefractiveIndex = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.edDispCompX2 = new System.Windows.Forms.TextBox();
            this.edDispCompX1 = new System.Windows.Forms.TextBox();
            this.cbDispComp = new System.Windows.Forms.CheckBox();
            this.edDistCorrPos = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.edMeasRangeMax = new System.Windows.Forms.TextBox();
            this.edMeasRangeMin = new System.Windows.Forms.TextBox();
            this.cbMeasRange = new System.Windows.Forms.CheckBox();
            this.cbDistCorrPos = new System.Windows.Forms.CheckBox();
            this.edSPA200WaveLimits = new System.Windows.Forms.TextBox();
            this.btnTSLCloseShutter = new System.Windows.Forms.Button();
            this.btnTSLOpenShutter = new System.Windows.Forms.Button();
            this.btnUpdateSettings = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbDistanceRange = new System.Windows.Forms.ComboBox();
            this.edRefractiveIndex = new System.Windows.Forms.TextBox();
            this.btnLoadSettingsFile = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.edStopWave = new System.Windows.Forms.TextBox();
            this.edStartWave = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.edPeakWidth = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.edPeakThreshold = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.edMaxPeakCount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.edPeakXMax = new System.Windows.Forms.TextBox();
            this.edPeakXMin = new System.Windows.Forms.TextBox();
            this.lstPeaks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnProcessPeaks = new System.Windows.Forms.Button();
            this.dlgSaveDSPA = new System.Windows.Forms.SaveFileDialog();
            this.dlgLoadSettings = new System.Windows.Forms.OpenFileDialog();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbFFTA = new System.Windows.Forms.RadioButton();
            this.rbFFTB = new System.Windows.Forms.RadioButton();
            this.rbFFTC = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(8, 29);
            this.btnInitialize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(156, 42);
            this.btnInitialize.TabIndex = 0;
            this.btnInitialize.Text = "Connect";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // btnReference
            // 
            this.btnReference.Location = new System.Drawing.Point(10, 271);
            this.btnReference.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReference.Name = "btnReference";
            this.btnReference.Size = new System.Drawing.Size(167, 44);
            this.btnReference.TabIndex = 1;
            this.btnReference.Text = "Reference";
            this.btnReference.UseVisualStyleBackColor = true;
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            // 
            // btnMeasure
            // 
            this.btnMeasure.Location = new System.Drawing.Point(185, 271);
            this.btnMeasure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(164, 44);
            this.btnMeasure.TabIndex = 2;
            this.btnMeasure.Text = "Measure";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // btnLoadDSPA
            // 
            this.btnLoadDSPA.Location = new System.Drawing.Point(7, 32);
            this.btnLoadDSPA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadDSPA.Name = "btnLoadDSPA";
            this.btnLoadDSPA.Size = new System.Drawing.Size(144, 42);
            this.btnLoadDSPA.TabIndex = 3;
            this.btnLoadDSPA.Text = "Load DSPA";
            this.btnLoadDSPA.UseVisualStyleBackColor = true;
            this.btnLoadDSPA.Click += new System.EventHandler(this.btnLoadDSPA_Click);
            // 
            // dlgLoadDSPA
            // 
            this.dlgLoadDSPA.FileName = "openFileDialog1";
            // 
            // plotMain
            // 
            this.plotMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotMain.Location = new System.Drawing.Point(10, 321);
            this.plotMain.Margin = new System.Windows.Forms.Padding(1);
            this.plotMain.Name = "plotMain";
            this.plotMain.Size = new System.Drawing.Size(1212, 276);
            this.plotMain.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.btnExitStandby);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.cbConnectionFile);
            this.groupBox1.Controls.Add(this.btnInitialize);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(595, 230);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initialize";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnLoadDSPA);
            this.groupBox6.Controls.Add(this.btnSaveDSPA);
            this.groupBox6.Location = new System.Drawing.Point(422, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(163, 134);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Datafile (DSPA)";
            // 
            // btnSaveDSPA
            // 
            this.btnSaveDSPA.Location = new System.Drawing.Point(7, 79);
            this.btnSaveDSPA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveDSPA.Name = "btnSaveDSPA";
            this.btnSaveDSPA.Size = new System.Drawing.Size(144, 38);
            this.btnSaveDSPA.TabIndex = 15;
            this.btnSaveDSPA.Text = "Save DSPA";
            this.btnSaveDSPA.UseVisualStyleBackColor = true;
            this.btnSaveDSPA.Click += new System.EventHandler(this.btnSaveDSPA_Click);
            // 
            // btnExitStandby
            // 
            this.btnExitStandby.Location = new System.Drawing.Point(423, 174);
            this.btnExitStandby.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExitStandby.Name = "btnExitStandby";
            this.btnExitStandby.Size = new System.Drawing.Size(164, 44);
            this.btnExitStandby.TabIndex = 19;
            this.btnExitStandby.Text = "Exit Standby";
            this.btnExitStandby.UseVisualStyleBackColor = true;
            this.btnExitStandby.Click += new System.EventHandler(this.btnExitStandby_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.cmbSPADevice);
            this.groupBox5.Location = new System.Drawing.Point(7, 113);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(183, 109);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SPA Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "SPA Device";
            // 
            // cmbSPADevice
            // 
            this.cmbSPADevice.FormattingEnabled = true;
            this.cmbSPADevice.Location = new System.Drawing.Point(7, 56);
            this.cmbSPADevice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSPADevice.Name = "cmbSPADevice";
            this.cmbSPADevice.Size = new System.Drawing.Size(116, 28);
            this.cmbSPADevice.TabIndex = 6;
            this.cmbSPADevice.Text = "F0B4EF";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbTSLType);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmbTSLDevice);
            this.groupBox4.Controls.Add(this.edPort);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.edIPAddress);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.edTSLGPIBAddress);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(196, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 195);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TSL Connection";
            // 
            // cmbTSLType
            // 
            this.cmbTSLType.FormattingEnabled = true;
            this.cmbTSLType.Items.AddRange(new object[] {
            "GPIB",
            "USB",
            "LAN"});
            this.cmbTSLType.Location = new System.Drawing.Point(100, 22);
            this.cmbTSLType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTSLType.Name = "cmbTSLType";
            this.cmbTSLType.Size = new System.Drawing.Size(113, 28);
            this.cmbTSLType.TabIndex = 2;
            this.cmbTSLType.Text = "USB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "TSL Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Port";
            // 
            // cmbTSLDevice
            // 
            this.cmbTSLDevice.FormattingEnabled = true;
            this.cmbTSLDevice.Location = new System.Drawing.Point(126, 92);
            this.cmbTSLDevice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTSLDevice.Name = "cmbTSLDevice";
            this.cmbTSLDevice.Size = new System.Drawing.Size(87, 28);
            this.cmbTSLDevice.TabIndex = 14;
            // 
            // edPort
            // 
            this.edPort.Location = new System.Drawing.Point(159, 156);
            this.edPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edPort.Name = "edPort";
            this.edPort.Size = new System.Drawing.Size(50, 26);
            this.edPort.TabIndex = 12;
            this.edPort.Text = "0";
            this.edPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "GPIB Address";
            // 
            // edIPAddress
            // 
            this.edIPAddress.Location = new System.Drawing.Point(7, 156);
            this.edIPAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edIPAddress.Name = "edIPAddress";
            this.edIPAddress.Size = new System.Drawing.Size(144, 26);
            this.edIPAddress.TabIndex = 10;
            this.edIPAddress.Text = "100.100.100.100";
            this.edIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "IP Address";
            // 
            // edTSLGPIBAddress
            // 
            this.edTSLGPIBAddress.Location = new System.Drawing.Point(126, 60);
            this.edTSLGPIBAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edTSLGPIBAddress.Name = "edTSLGPIBAddress";
            this.edTSLGPIBAddress.Size = new System.Drawing.Size(87, 26);
            this.edTSLGPIBAddress.TabIndex = 4;
            this.edTSLGPIBAddress.Text = "0";
            this.edTSLGPIBAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "USB Device";
            // 
            // cbConnectionFile
            // 
            this.cbConnectionFile.AutoSize = true;
            this.cbConnectionFile.Location = new System.Drawing.Point(8, 81);
            this.cbConnectionFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbConnectionFile.Name = "cbConnectionFile";
            this.cbConnectionFile.Size = new System.Drawing.Size(171, 24);
            this.cbConnectionFile.TabIndex = 1;
            this.cbConnectionFile.Text = "Use Connection File";
            this.cbConnectionFile.UseVisualStyleBackColor = true;
            // 
            // plotWDL
            // 
            this.plotWDL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotWDL.Location = new System.Drawing.Point(14, 606);
            this.plotWDL.Margin = new System.Windows.Forms.Padding(2);
            this.plotWDL.Name = "plotWDL";
            this.plotWDL.Size = new System.Drawing.Size(1212, 251);
            this.plotWDL.TabIndex = 6;
            // 
            // btnProcessWDL
            // 
            this.btnProcessWDL.Location = new System.Drawing.Point(730, 271);
            this.btnProcessWDL.Name = "btnProcessWDL";
            this.btnProcessWDL.Size = new System.Drawing.Size(164, 44);
            this.btnProcessWDL.TabIndex = 7;
            this.btnProcessWDL.Text = "Process WDL";
            this.btnProcessWDL.UseVisualStyleBackColor = true;
            this.btnProcessWDL.Click += new System.EventHandler(this.btnProcessWDL_Click);
            // 
            // edWDLXMin
            // 
            this.edWDLXMin.Location = new System.Drawing.Point(959, 292);
            this.edWDLXMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edWDLXMin.Name = "edWDLXMin";
            this.edWDLXMin.Size = new System.Drawing.Size(76, 26);
            this.edWDLXMin.TabIndex = 13;
            this.edWDLXMin.Text = "0";
            this.edWDLXMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edWDLXMax
            // 
            this.edWDLXMax.Location = new System.Drawing.Point(1120, 291);
            this.edWDLXMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edWDLXMax.Name = "edWDLXMax";
            this.edWDLXMax.Size = new System.Drawing.Size(76, 26);
            this.edWDLXMax.TabIndex = 14;
            this.edWDLXMax.Text = "0";
            this.edWDLXMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(901, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "X-Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1058, 295);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "X-Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(901, 264);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "WDL Filter Range";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDefaultRefractiveIndex);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.edDispCompX2);
            this.groupBox2.Controls.Add(this.edDispCompX1);
            this.groupBox2.Controls.Add(this.cbDispComp);
            this.groupBox2.Controls.Add(this.edDistCorrPos);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.edMeasRangeMax);
            this.groupBox2.Controls.Add(this.edMeasRangeMin);
            this.groupBox2.Controls.Add(this.cbMeasRange);
            this.groupBox2.Controls.Add(this.cbDistCorrPos);
            this.groupBox2.Controls.Add(this.edSPA200WaveLimits);
            this.groupBox2.Controls.Add(this.btnTSLCloseShutter);
            this.groupBox2.Controls.Add(this.btnTSLOpenShutter);
            this.groupBox2.Controls.Add(this.btnUpdateSettings);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cmbDistanceRange);
            this.groupBox2.Controls.Add(this.edRefractiveIndex);
            this.groupBox2.Controls.Add(this.btnLoadSettingsFile);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbPort);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.edStopWave);
            this.groupBox2.Controls.Add(this.edStartWave);
            this.groupBox2.Location = new System.Drawing.Point(615, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1012, 230);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // cbDefaultRefractiveIndex
            // 
            this.cbDefaultRefractiveIndex.AutoSize = true;
            this.cbDefaultRefractiveIndex.Location = new System.Drawing.Point(11, 139);
            this.cbDefaultRefractiveIndex.Name = "cbDefaultRefractiveIndex";
            this.cbDefaultRefractiveIndex.Size = new System.Drawing.Size(143, 24);
            this.cbDefaultRefractiveIndex.TabIndex = 50;
            this.cbDefaultRefractiveIndex.Text = "Refractive Index";
            this.cbDefaultRefractiveIndex.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(723, 201);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 20);
            this.label22.TabIndex = 49;
            this.label22.Text = "-";
            // 
            // edDispCompX2
            // 
            this.edDispCompX2.Location = new System.Drawing.Point(745, 198);
            this.edDispCompX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edDispCompX2.Name = "edDispCompX2";
            this.edDispCompX2.Size = new System.Drawing.Size(76, 26);
            this.edDispCompX2.TabIndex = 48;
            this.edDispCompX2.Text = "0";
            this.edDispCompX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edDispCompX1
            // 
            this.edDispCompX1.Location = new System.Drawing.Point(642, 198);
            this.edDispCompX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edDispCompX1.Name = "edDispCompX1";
            this.edDispCompX1.Size = new System.Drawing.Size(76, 26);
            this.edDispCompX1.TabIndex = 47;
            this.edDispCompX1.Text = "0";
            this.edDispCompX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbDispComp
            // 
            this.cbDispComp.AutoSize = true;
            this.cbDispComp.Location = new System.Drawing.Point(373, 200);
            this.cbDispComp.Name = "cbDispComp";
            this.cbDispComp.Size = new System.Drawing.Size(262, 24);
            this.cbDispComp.TabIndex = 46;
            this.cbDispComp.Text = "Dispersion Compensation Range";
            this.cbDispComp.UseVisualStyleBackColor = true;
            // 
            // edDistCorrPos
            // 
            this.edDistCorrPos.Location = new System.Drawing.Point(642, 132);
            this.edDistCorrPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edDistCorrPos.Name = "edDistCorrPos";
            this.edDistCorrPos.Size = new System.Drawing.Size(76, 26);
            this.edDistCorrPos.TabIndex = 39;
            this.edDistCorrPos.Text = "0";
            this.edDistCorrPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(723, 168);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 20);
            this.label21.TabIndex = 38;
            this.label21.Text = "-";
            // 
            // edMeasRangeMax
            // 
            this.edMeasRangeMax.Location = new System.Drawing.Point(745, 165);
            this.edMeasRangeMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edMeasRangeMax.Name = "edMeasRangeMax";
            this.edMeasRangeMax.Size = new System.Drawing.Size(76, 26);
            this.edMeasRangeMax.TabIndex = 37;
            this.edMeasRangeMax.Text = "0";
            this.edMeasRangeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edMeasRangeMin
            // 
            this.edMeasRangeMin.Location = new System.Drawing.Point(642, 165);
            this.edMeasRangeMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edMeasRangeMin.Name = "edMeasRangeMin";
            this.edMeasRangeMin.Size = new System.Drawing.Size(76, 26);
            this.edMeasRangeMin.TabIndex = 35;
            this.edMeasRangeMin.Text = "0";
            this.edMeasRangeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbMeasRange
            // 
            this.cbMeasRange.AutoSize = true;
            this.cbMeasRange.Location = new System.Drawing.Point(493, 165);
            this.cbMeasRange.Name = "cbMeasRange";
            this.cbMeasRange.Size = new System.Drawing.Size(142, 24);
            this.cbMeasRange.TabIndex = 34;
            this.cbMeasRange.Text = "Measure Range";
            this.cbMeasRange.UseVisualStyleBackColor = true;
            // 
            // cbDistCorrPos
            // 
            this.cbDistCorrPos.AutoSize = true;
            this.cbDistCorrPos.Location = new System.Drawing.Point(493, 134);
            this.cbDistCorrPos.Name = "cbDistCorrPos";
            this.cbDistCorrPos.Size = new System.Drawing.Size(150, 24);
            this.cbDistCorrPos.TabIndex = 33;
            this.cbDistCorrPos.Text = "Dist Corr Position";
            this.cbDistCorrPos.UseVisualStyleBackColor = true;
            // 
            // edSPA200WaveLimits
            // 
            this.edSPA200WaveLimits.Enabled = false;
            this.edSPA200WaveLimits.Location = new System.Drawing.Point(493, 20);
            this.edSPA200WaveLimits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edSPA200WaveLimits.Multiline = true;
            this.edSPA200WaveLimits.Name = "edSPA200WaveLimits";
            this.edSPA200WaveLimits.Size = new System.Drawing.Size(251, 107);
            this.edSPA200WaveLimits.TabIndex = 32;
            this.edSPA200WaveLimits.Text = "Wavelength Range Limit by Distance Range\r\n30 m range : 160 nm sweep\r\n70 m range :" +
    " 40 nm sweep\r\n250 m range : 10 nm sweep\r\n";
            this.edSPA200WaveLimits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edSPA200WaveLimits.Visible = false;
            // 
            // btnTSLCloseShutter
            // 
            this.btnTSLCloseShutter.Location = new System.Drawing.Point(840, 183);
            this.btnTSLCloseShutter.Name = "btnTSLCloseShutter";
            this.btnTSLCloseShutter.Size = new System.Drawing.Size(165, 37);
            this.btnTSLCloseShutter.TabIndex = 31;
            this.btnTSLCloseShutter.Text = "TSL Shutter Close";
            this.btnTSLCloseShutter.UseVisualStyleBackColor = true;
            this.btnTSLCloseShutter.Click += new System.EventHandler(this.btnTSLCloseShutter_Click);
            // 
            // btnTSLOpenShutter
            // 
            this.btnTSLOpenShutter.Location = new System.Drawing.Point(840, 144);
            this.btnTSLOpenShutter.Name = "btnTSLOpenShutter";
            this.btnTSLOpenShutter.Size = new System.Drawing.Size(165, 37);
            this.btnTSLOpenShutter.TabIndex = 30;
            this.btnTSLOpenShutter.Text = "TSL Shutter Open";
            this.btnTSLOpenShutter.UseVisualStyleBackColor = true;
            this.btnTSLOpenShutter.Click += new System.EventHandler(this.btnTSLOpenShutter_Click);
            // 
            // btnUpdateSettings
            // 
            this.btnUpdateSettings.Location = new System.Drawing.Point(11, 171);
            this.btnUpdateSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateSettings.Name = "btnUpdateSettings";
            this.btnUpdateSettings.Size = new System.Drawing.Size(205, 51);
            this.btnUpdateSettings.TabIndex = 29;
            this.btnUpdateSettings.Text = "Update Settings";
            this.btnUpdateSettings.UseVisualStyleBackColor = true;
            this.btnUpdateSettings.Click += new System.EventHandler(this.btnUpdateSettings_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 100);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 20);
            this.label20.TabIndex = 28;
            this.label20.Text = "Distance Range (m)";
            // 
            // cmbDistanceRange
            // 
            this.cmbDistanceRange.FormattingEnabled = true;
            this.cmbDistanceRange.Location = new System.Drawing.Point(352, 99);
            this.cmbDistanceRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDistanceRange.Name = "cmbDistanceRange";
            this.cmbDistanceRange.Size = new System.Drawing.Size(116, 28);
            this.cmbDistanceRange.TabIndex = 27;
            this.cmbDistanceRange.SelectedIndexChanged += new System.EventHandler(this.cmbDistanceRange_SelectedIndexChanged);
            // 
            // edRefractiveIndex
            // 
            this.edRefractiveIndex.Location = new System.Drawing.Point(392, 137);
            this.edRefractiveIndex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edRefractiveIndex.Name = "edRefractiveIndex";
            this.edRefractiveIndex.Size = new System.Drawing.Size(76, 26);
            this.edRefractiveIndex.TabIndex = 25;
            this.edRefractiveIndex.Text = "1";
            this.edRefractiveIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLoadSettingsFile
            // 
            this.btnLoadSettingsFile.Location = new System.Drawing.Point(800, 20);
            this.btnLoadSettingsFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadSettingsFile.Name = "btnLoadSettingsFile";
            this.btnLoadSettingsFile.Size = new System.Drawing.Size(205, 51);
            this.btnLoadSettingsFile.TabIndex = 24;
            this.btnLoadSettingsFile.Text = "Load Settings FIle";
            this.btnLoadSettingsFile.UseVisualStyleBackColor = true;
            this.btnLoadSettingsFile.Click += new System.EventHandler(this.btnLoadSettingsFile_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 64);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Measurement Mode";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Items.AddRange(new object[] {
            "Reflection Port 1",
            "Reflection Port 2",
            "Reflection Port 1+2",
            "Transmission (IL)"});
            this.cmbPort.Location = new System.Drawing.Point(290, 63);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(178, 28);
            this.cmbPort.TabIndex = 22;
            this.cmbPort.Text = "Reflection Port 1";
            this.cmbPort.SelectedIndexChanged += new System.EventHandler(this.cmbPort_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sweep Range (nm)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Stop";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Start";
            // 
            // edStopWave
            // 
            this.edStopWave.Location = new System.Drawing.Point(392, 29);
            this.edStopWave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edStopWave.Name = "edStopWave";
            this.edStopWave.Size = new System.Drawing.Size(76, 26);
            this.edStopWave.TabIndex = 19;
            this.edStopWave.Text = "0";
            this.edStopWave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edStartWave
            // 
            this.edStartWave.Location = new System.Drawing.Point(233, 29);
            this.edStartWave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edStartWave.Name = "edStartWave";
            this.edStartWave.Size = new System.Drawing.Size(76, 26);
            this.edStartWave.TabIndex = 17;
            this.edStartWave.Text = "0";
            this.edStartWave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.edPeakWidth);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.edPeakThreshold);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.edMaxPeakCount);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.edPeakXMax);
            this.groupBox3.Controls.Add(this.edPeakXMin);
            this.groupBox3.Controls.Add(this.lstPeaks);
            this.groupBox3.Controls.Add(this.btnProcessPeaks);
            this.groupBox3.Location = new System.Drawing.Point(1229, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 559);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Peak Analysis";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(234, 32);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 20);
            this.label18.TabIndex = 25;
            this.label18.Text = "Peak Width";
            // 
            // edPeakWidth
            // 
            this.edPeakWidth.Location = new System.Drawing.Point(332, 29);
            this.edPeakWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edPeakWidth.Name = "edPeakWidth";
            this.edPeakWidth.Size = new System.Drawing.Size(59, 26);
            this.edPeakWidth.TabIndex = 24;
            this.edPeakWidth.Text = "1";
            this.edPeakWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 32);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "Peak Threshold";
            // 
            // edPeakThreshold
            // 
            this.edPeakThreshold.Location = new System.Drawing.Point(137, 29);
            this.edPeakThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edPeakThreshold.Name = "edPeakThreshold";
            this.edPeakThreshold.Size = new System.Drawing.Size(59, 26);
            this.edPeakThreshold.TabIndex = 22;
            this.edPeakThreshold.Text = "-90";
            this.edPeakThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(267, 76);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Max Count";
            // 
            // edMaxPeakCount
            // 
            this.edMaxPeakCount.Location = new System.Drawing.Point(360, 73);
            this.edMaxPeakCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edMaxPeakCount.Name = "edMaxPeakCount";
            this.edMaxPeakCount.Size = new System.Drawing.Size(31, 26);
            this.edMaxPeakCount.TabIndex = 20;
            this.edMaxPeakCount.Text = "20";
            this.edMaxPeakCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(136, 76);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "X-Max";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 76);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "X-Min";
            // 
            // edPeakXMax
            // 
            this.edPeakXMax.Location = new System.Drawing.Point(198, 73);
            this.edPeakXMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edPeakXMax.Name = "edPeakXMax";
            this.edPeakXMax.Size = new System.Drawing.Size(55, 26);
            this.edPeakXMax.TabIndex = 18;
            this.edPeakXMax.Text = "6000";
            this.edPeakXMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edPeakXMin
            // 
            this.edPeakXMin.Location = new System.Drawing.Point(68, 73);
            this.edPeakXMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edPeakXMin.Name = "edPeakXMin";
            this.edPeakXMin.Size = new System.Drawing.Size(55, 26);
            this.edPeakXMin.TabIndex = 16;
            this.edPeakXMin.Text = "0";
            this.edPeakXMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstPeaks
            // 
            this.lstPeaks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstPeaks.HideSelection = false;
            this.lstPeaks.Location = new System.Drawing.Point(6, 152);
            this.lstPeaks.Name = "lstPeaks";
            this.lstPeaks.Size = new System.Drawing.Size(385, 395);
            this.lstPeaks.TabIndex = 9;
            this.lstPeaks.UseCompatibleStateImageBehavior = false;
            this.lstPeaks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Distance (mm)";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RL (dB)";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "IL (dB)";
            this.columnHeader4.Width = 108;
            // 
            // btnProcessPeaks
            // 
            this.btnProcessPeaks.Location = new System.Drawing.Point(7, 107);
            this.btnProcessPeaks.Name = "btnProcessPeaks";
            this.btnProcessPeaks.Size = new System.Drawing.Size(385, 39);
            this.btnProcessPeaks.TabIndex = 8;
            this.btnProcessPeaks.Text = "Peaks Scan";
            this.btnProcessPeaks.UseVisualStyleBackColor = true;
            this.btnProcessPeaks.Click += new System.EventHandler(this.btnProcessPeaks_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(559, 271);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 44);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rbFFTA
            // 
            this.rbFFTA.AutoSize = true;
            this.rbFFTA.Location = new System.Drawing.Point(7, 24);
            this.rbFFTA.Name = "rbFFTA";
            this.rbFFTA.Size = new System.Drawing.Size(67, 24);
            this.rbFFTA.TabIndex = 21;
            this.rbFFTA.Text = "FFTA";
            this.rbFFTA.UseVisualStyleBackColor = true;
            // 
            // rbFFTB
            // 
            this.rbFFTB.AutoSize = true;
            this.rbFFTB.Location = new System.Drawing.Point(80, 25);
            this.rbFFTB.Name = "rbFFTB";
            this.rbFFTB.Size = new System.Drawing.Size(67, 24);
            this.rbFFTB.TabIndex = 22;
            this.rbFFTB.Text = "FFTB";
            this.rbFFTB.UseVisualStyleBackColor = true;
            // 
            // rbFFTC
            // 
            this.rbFFTC.AutoSize = true;
            this.rbFFTC.Checked = true;
            this.rbFFTC.Location = new System.Drawing.Point(7, 49);
            this.rbFFTC.Name = "rbFFTC";
            this.rbFFTC.Size = new System.Drawing.Size(99, 24);
            this.rbFFTC.TabIndex = 23;
            this.rbFFTC.TabStop = true;
            this.rbFFTC.Text = "Combined";
            this.rbFFTC.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbFFTA);
            this.groupBox7.Controls.Add(this.rbFFTC);
            this.groupBox7.Controls.Add(this.rbFFTB);
            this.groupBox7.Location = new System.Drawing.Point(390, 256);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(162, 79);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Mode";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 868);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edWDLXMax);
            this.Controls.Add(this.edWDLXMin);
            this.Controls.Add(this.btnProcessWDL);
            this.Controls.Add(this.plotWDL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.plotMain);
            this.Controls.Add(this.btnMeasure);
            this.Controls.Add(this.btnReference);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "SPA SDK Sample";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Button btnReference;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Button btnLoadDSPA;
        private System.Windows.Forms.OpenFileDialog dlgLoadDSPA;
        private ScottPlot.FormsPlot plotMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbConnectionFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSPADevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edTSLGPIBAddress;
        private System.Windows.Forms.ComboBox cmbTSLType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edIPAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edPort;
        private ScottPlot.FormsPlot plotWDL;
        private System.Windows.Forms.Button btnProcessWDL;
        private System.Windows.Forms.TextBox edWDLXMin;
        private System.Windows.Forms.TextBox edWDLXMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox edStopWave;
        private System.Windows.Forms.TextBox edStartWave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button btnLoadSettingsFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstPeaks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnProcessPeaks;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox edPeakThreshold;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox edMaxPeakCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox edPeakXMax;
        private System.Windows.Forms.TextBox edPeakXMin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox edPeakWidth;
        private System.Windows.Forms.TextBox edRefractiveIndex;
        private System.Windows.Forms.ComboBox cmbTSLDevice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbDistanceRange;
        private System.Windows.Forms.Button btnSaveDSPA;
        private System.Windows.Forms.SaveFileDialog dlgSaveDSPA;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdateSettings;
        private System.Windows.Forms.OpenFileDialog dlgLoadSettings;
        private System.Windows.Forms.Button btnTSLCloseShutter;
        private System.Windows.Forms.Button btnTSLOpenShutter;
        private System.Windows.Forms.Button btnExitStandby;
        private System.Windows.Forms.TextBox edSPA200WaveLimits;
        private System.Windows.Forms.TextBox edDistCorrPos;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox edMeasRangeMax;
        private System.Windows.Forms.TextBox edMeasRangeMin;
        private System.Windows.Forms.CheckBox cbMeasRange;
        private System.Windows.Forms.CheckBox cbDistCorrPos;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rbFFTA;
        private System.Windows.Forms.RadioButton rbFFTB;
        private System.Windows.Forms.RadioButton rbFFTC;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox edDispCompX2;
        private System.Windows.Forms.TextBox edDispCompX1;
        private System.Windows.Forms.CheckBox cbDispComp;
        private System.Windows.Forms.CheckBox cbDefaultRefractiveIndex;
    }
}

