namespace SN76477
{
    partial class EmulatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmulatorForm));
            this.labelSLFRES = new System.Windows.Forms.Label();
            this.trackBarVCORES = new System.Windows.Forms.TrackBar();
            this.labelVCORES = new System.Windows.Forms.Label();
            this.groupBoxSLF = new System.Windows.Forms.GroupBox();
            this.labelSLFRESTOTAL = new System.Windows.Forms.Label();
            this.labelSLFFrequency = new System.Windows.Forms.Label();
            this.cbSLFRES = new System.Windows.Forms.ComboBox();
            this.cbSLFCAP = new System.Windows.Forms.ComboBox();
            this.labelSLFCAP = new System.Windows.Forms.Label();
            this.trackBarSLFRES = new System.Windows.Forms.TrackBar();
            this.groupBoxVCO = new System.Windows.Forms.GroupBox();
            this.labelVCORESTOTAL = new System.Windows.Forms.Label();
            this.labelVCOPitchDutyCycle = new System.Windows.Forms.Label();
            this.labelVCOPitchVoltage = new System.Windows.Forms.Label();
            this.labelVCOEXTFrequency = new System.Windows.Forms.Label();
            this.labelVCOEXTVoltage = new System.Windows.Forms.Label();
            this.labelVCOFrequency = new System.Windows.Forms.Label();
            this.cbVCORES = new System.Windows.Forms.ComboBox();
            this.labelPitch = new System.Windows.Forms.Label();
            this.trackBarVCOPITCH = new System.Windows.Forms.TrackBar();
            this.trackBarVCOEXT = new System.Windows.Forms.TrackBar();
            this.labelVCOEXT = new System.Windows.Forms.Label();
            this.cbVCOCAP = new System.Windows.Forms.ComboBox();
            this.checkBoxVCOEXT = new System.Windows.Forms.CheckBox();
            this.labelVCOCAP = new System.Windows.Forms.Label();
            this.groupBoxNoiseGenerator = new System.Windows.Forms.GroupBox();
            this.labelNOISEGENRESTOTAL = new System.Windows.Forms.Label();
            this.labelNoiseFrequency = new System.Windows.Forms.Label();
            this.labelNoiseGeneratorRES = new System.Windows.Forms.Label();
            this.cbNOISEGENRES = new System.Windows.Forms.ComboBox();
            this.trackBarNOISEGENRES = new System.Windows.Forms.TrackBar();
            this.groupBoxMixer = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBoxMIXNOISE = new System.Windows.Forms.CheckBox();
            this.checkBoxMIXVCO = new System.Windows.Forms.CheckBox();
            this.checkBoxMIXSLF = new System.Windows.Forms.CheckBox();
            this.groupBoxEnvelope = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.labelDecayLength = new System.Windows.Forms.Label();
            this.labelAttackLength = new System.Windows.Forms.Label();
            this.cbENVDECRES = new System.Windows.Forms.ComboBox();
            this.trackBarENVDECRES = new System.Windows.Forms.TrackBar();
            this.labelEnvelopeDEC = new System.Windows.Forms.Label();
            this.cbENVATKRES = new System.Windows.Forms.ComboBox();
            this.cbENVCAP = new System.Windows.Forms.ComboBox();
            this.labelEnvelopeCAP = new System.Windows.Forms.Label();
            this.trackBarENVATKRES = new System.Windows.Forms.TrackBar();
            this.labelEnvelopeATK = new System.Windows.Forms.Label();
            this.rbENVVCOALT = new System.Windows.Forms.RadioButton();
            this.rbENVONESHOT = new System.Windows.Forms.RadioButton();
            this.rbENVMIXER = new System.Windows.Forms.RadioButton();
            this.rbENVVCO = new System.Windows.Forms.RadioButton();
            this.btnONESHOTSHOOT = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBufferPlay = new System.Windows.Forms.ToolStripButton();
            this.groupBoxOneShot = new System.Windows.Forms.GroupBox();
            this.labelOneShotLength = new System.Windows.Forms.Label();
            this.cbONESHOTRES = new System.Windows.Forms.ComboBox();
            this.cbONESHOTCAP = new System.Windows.Forms.ComboBox();
            this.labelOneShotCAP = new System.Windows.Forms.Label();
            this.trackBarONESHOTRES = new System.Windows.Forms.TrackBar();
            this.labelOneShotRES = new System.Windows.Forms.Label();
            this.groupBoxNoiseFilter = new System.Windows.Forms.GroupBox();
            this.labelNoiseFilterFrequency = new System.Windows.Forms.Label();
            this.cbNOISEFILTERRES = new System.Windows.Forms.ComboBox();
            this.cbNOISEFILTERCAP = new System.Windows.Forms.ComboBox();
            this.labelNoiseFilterCAP = new System.Windows.Forms.Label();
            this.trackBarNOISEFILTERRES = new System.Windows.Forms.TrackBar();
            this.labelNoiseFilterRES = new System.Windows.Forms.Label();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelOutputVoltageMinMax = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAMPLITUDERES = new System.Windows.Forms.ComboBox();
            this.cbFEEDBACKRES = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxSystem = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNOISEFILTERRESTOTAL = new System.Windows.Forms.Label();
            this.labelONESHOTRESTOTAL = new System.Windows.Forms.Label();
            this.labelATKRESTOTAL = new System.Windows.Forms.Label();
            this.labelDECRESTOTAL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVCORES)).BeginInit();
            this.groupBoxSLF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSLFRES)).BeginInit();
            this.groupBoxVCO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVCOPITCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVCOEXT)).BeginInit();
            this.groupBoxNoiseGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNOISEGENRES)).BeginInit();
            this.groupBoxMixer.SuspendLayout();
            this.groupBoxEnvelope.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarENVDECRES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarENVATKRES)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.groupBoxOneShot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarONESHOTRES)).BeginInit();
            this.groupBoxNoiseFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNOISEFILTERRES)).BeginInit();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSLFRES
            // 
            this.labelSLFRES.AutoSize = true;
            this.labelSLFRES.Location = new System.Drawing.Point(6, 48);
            this.labelSLFRES.Name = "labelSLFRES";
            this.labelSLFRES.Size = new System.Drawing.Size(50, 13);
            this.labelSLFRES.TabIndex = 4;
            this.labelSLFRES.Text = "RES (20)";
            // 
            // trackBarVCORES
            // 
            this.trackBarVCORES.LargeChange = 10000;
            this.trackBarVCORES.Location = new System.Drawing.Point(57, 46);
            this.trackBarVCORES.Maximum = 8000000;
            this.trackBarVCORES.Minimum = 7500;
            this.trackBarVCORES.Name = "trackBarVCORES";
            this.trackBarVCORES.Size = new System.Drawing.Size(219, 42);
            this.trackBarVCORES.TabIndex = 5;
            this.trackBarVCORES.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVCORES.Value = 7500;
            this.trackBarVCORES.Scroll += new System.EventHandler(this.trackBarVCORES_Scroll);
            // 
            // labelVCORES
            // 
            this.labelVCORES.AutoSize = true;
            this.labelVCORES.Location = new System.Drawing.Point(6, 46);
            this.labelVCORES.Name = "labelVCORES";
            this.labelVCORES.Size = new System.Drawing.Size(50, 13);
            this.labelVCORES.TabIndex = 6;
            this.labelVCORES.Text = "RES (18)";
            // 
            // groupBoxSLF
            // 
            this.groupBoxSLF.Controls.Add(this.labelSLFRESTOTAL);
            this.groupBoxSLF.Controls.Add(this.labelSLFFrequency);
            this.groupBoxSLF.Controls.Add(this.cbSLFRES);
            this.groupBoxSLF.Controls.Add(this.cbSLFCAP);
            this.groupBoxSLF.Controls.Add(this.labelSLFCAP);
            this.groupBoxSLF.Controls.Add(this.trackBarSLFRES);
            this.groupBoxSLF.Controls.Add(this.labelSLFRES);
            this.groupBoxSLF.Location = new System.Drawing.Point(12, 41);
            this.groupBoxSLF.Name = "groupBoxSLF";
            this.groupBoxSLF.Size = new System.Drawing.Size(290, 98);
            this.groupBoxSLF.TabIndex = 8;
            this.groupBoxSLF.TabStop = false;
            this.groupBoxSLF.Text = "SLF";
            // 
            // labelSLFRESTOTAL
            // 
            this.labelSLFRESTOTAL.AutoSize = true;
            this.labelSLFRESTOTAL.Location = new System.Drawing.Point(237, 75);
            this.labelSLFRESTOTAL.Name = "labelSLFRESTOTAL";
            this.labelSLFRESTOTAL.Size = new System.Drawing.Size(31, 13);
            this.labelSLFRESTOTAL.TabIndex = 10;
            this.labelSLFRESTOTAL.Text = "0 kΩ";
            this.labelSLFRESTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSLFFrequency
            // 
            this.labelSLFFrequency.AutoSize = true;
            this.labelSLFFrequency.Location = new System.Drawing.Point(194, 27);
            this.labelSLFFrequency.Name = "labelSLFFrequency";
            this.labelSLFFrequency.Size = new System.Drawing.Size(29, 13);
            this.labelSLFFrequency.TabIndex = 9;
            this.labelSLFFrequency.Text = "0 Hz";
            // 
            // cbSLFRES
            // 
            this.cbSLFRES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSLFRES.FormattingEnabled = true;
            this.cbSLFRES.Location = new System.Drawing.Point(67, 72);
            this.cbSLFRES.Name = "cbSLFRES";
            this.cbSLFRES.Size = new System.Drawing.Size(121, 21);
            this.cbSLFRES.TabIndex = 8;
            this.cbSLFRES.SelectedIndexChanged += new System.EventHandler(this.cbSLFRES_SelectedIndexChanged);
            // 
            // cbSLFCAP
            // 
            this.cbSLFCAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSLFCAP.FormattingEnabled = true;
            this.cbSLFCAP.Items.AddRange(new object[] {
            "0.1",
            "0.5",
            "50",
            "100",
            "470",
            "1000"});
            this.cbSLFCAP.Location = new System.Drawing.Point(67, 24);
            this.cbSLFCAP.Name = "cbSLFCAP";
            this.cbSLFCAP.Size = new System.Drawing.Size(121, 21);
            this.cbSLFCAP.TabIndex = 7;
            this.cbSLFCAP.SelectedIndexChanged += new System.EventHandler(this.cbSLFCAP_SelectedIndexChanged);
            // 
            // labelSLFCAP
            // 
            this.labelSLFCAP.AutoSize = true;
            this.labelSLFCAP.Location = new System.Drawing.Point(6, 24);
            this.labelSLFCAP.Name = "labelSLFCAP";
            this.labelSLFCAP.Size = new System.Drawing.Size(49, 13);
            this.labelSLFCAP.TabIndex = 6;
            this.labelSLFCAP.Text = "CAP (21)";
            // 
            // trackBarSLFRES
            // 
            this.trackBarSLFRES.LargeChange = 10000;
            this.trackBarSLFRES.Location = new System.Drawing.Point(57, 51);
            this.trackBarSLFRES.Maximum = 8000000;
            this.trackBarSLFRES.Minimum = 7500;
            this.trackBarSLFRES.Name = "trackBarSLFRES";
            this.trackBarSLFRES.Size = new System.Drawing.Size(219, 42);
            this.trackBarSLFRES.TabIndex = 5;
            this.trackBarSLFRES.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSLFRES.Value = 7500;
            this.trackBarSLFRES.Scroll += new System.EventHandler(this.trackBarSLFRES_Scroll);
            // 
            // groupBoxVCO
            // 
            this.groupBoxVCO.Controls.Add(this.labelVCORESTOTAL);
            this.groupBoxVCO.Controls.Add(this.labelVCOPitchDutyCycle);
            this.groupBoxVCO.Controls.Add(this.labelVCOPitchVoltage);
            this.groupBoxVCO.Controls.Add(this.labelVCOEXTFrequency);
            this.groupBoxVCO.Controls.Add(this.labelVCOEXTVoltage);
            this.groupBoxVCO.Controls.Add(this.labelVCOFrequency);
            this.groupBoxVCO.Controls.Add(this.cbVCORES);
            this.groupBoxVCO.Controls.Add(this.labelPitch);
            this.groupBoxVCO.Controls.Add(this.trackBarVCOPITCH);
            this.groupBoxVCO.Controls.Add(this.trackBarVCOEXT);
            this.groupBoxVCO.Controls.Add(this.labelVCOEXT);
            this.groupBoxVCO.Controls.Add(this.cbVCOCAP);
            this.groupBoxVCO.Controls.Add(this.checkBoxVCOEXT);
            this.groupBoxVCO.Controls.Add(this.labelVCOCAP);
            this.groupBoxVCO.Controls.Add(this.trackBarVCORES);
            this.groupBoxVCO.Controls.Add(this.labelVCORES);
            this.groupBoxVCO.Location = new System.Drawing.Point(12, 145);
            this.groupBoxVCO.Name = "groupBoxVCO";
            this.groupBoxVCO.Size = new System.Drawing.Size(290, 244);
            this.groupBoxVCO.TabIndex = 9;
            this.groupBoxVCO.TabStop = false;
            this.groupBoxVCO.Text = "VCO";
            // 
            // labelVCORESTOTAL
            // 
            this.labelVCORESTOTAL.AutoSize = true;
            this.labelVCORESTOTAL.Location = new System.Drawing.Point(237, 66);
            this.labelVCORESTOTAL.Name = "labelVCORESTOTAL";
            this.labelVCORESTOTAL.Size = new System.Drawing.Size(31, 13);
            this.labelVCORESTOTAL.TabIndex = 24;
            this.labelVCORESTOTAL.Text = "0 kΩ";
            this.labelVCORESTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVCOPitchDutyCycle
            // 
            this.labelVCOPitchDutyCycle.AutoSize = true;
            this.labelVCOPitchDutyCycle.Location = new System.Drawing.Point(137, 211);
            this.labelVCOPitchDutyCycle.Name = "labelVCOPitchDutyCycle";
            this.labelVCOPitchDutyCycle.Size = new System.Drawing.Size(27, 13);
            this.labelVCOPitchDutyCycle.TabIndex = 23;
            this.labelVCOPitchDutyCycle.Text = "50%";
            // 
            // labelVCOPitchVoltage
            // 
            this.labelVCOPitchVoltage.AutoSize = true;
            this.labelVCOPitchVoltage.Location = new System.Drawing.Point(72, 211);
            this.labelVCOPitchVoltage.Name = "labelVCOPitchVoltage";
            this.labelVCOPitchVoltage.Size = new System.Drawing.Size(23, 13);
            this.labelVCOPitchVoltage.TabIndex = 22;
            this.labelVCOPitchVoltage.Text = "0 V";
            // 
            // labelVCOEXTFrequency
            // 
            this.labelVCOEXTFrequency.AutoSize = true;
            this.labelVCOEXTFrequency.Location = new System.Drawing.Point(137, 148);
            this.labelVCOEXTFrequency.Name = "labelVCOEXTFrequency";
            this.labelVCOEXTFrequency.Size = new System.Drawing.Size(29, 13);
            this.labelVCOEXTFrequency.TabIndex = 21;
            this.labelVCOEXTFrequency.Text = "0 Hz";
            // 
            // labelVCOEXTVoltage
            // 
            this.labelVCOEXTVoltage.AutoSize = true;
            this.labelVCOEXTVoltage.Location = new System.Drawing.Point(72, 148);
            this.labelVCOEXTVoltage.Name = "labelVCOEXTVoltage";
            this.labelVCOEXTVoltage.Size = new System.Drawing.Size(23, 13);
            this.labelVCOEXTVoltage.TabIndex = 20;
            this.labelVCOEXTVoltage.Text = "0 V";
            // 
            // labelVCOFrequency
            // 
            this.labelVCOFrequency.AutoSize = true;
            this.labelVCOFrequency.Location = new System.Drawing.Point(194, 22);
            this.labelVCOFrequency.Name = "labelVCOFrequency";
            this.labelVCOFrequency.Size = new System.Drawing.Size(29, 13);
            this.labelVCOFrequency.TabIndex = 19;
            this.labelVCOFrequency.Text = "0 Hz";
            // 
            // cbVCORES
            // 
            this.cbVCORES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVCORES.FormattingEnabled = true;
            this.cbVCORES.Location = new System.Drawing.Point(67, 73);
            this.cbVCORES.Name = "cbVCORES";
            this.cbVCORES.Size = new System.Drawing.Size(121, 21);
            this.cbVCORES.TabIndex = 18;
            this.cbVCORES.SelectedIndexChanged += new System.EventHandler(this.cbVCORES_SelectedIndexChanged);
            // 
            // labelPitch
            // 
            this.labelPitch.AutoSize = true;
            this.labelPitch.Location = new System.Drawing.Point(7, 179);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.Size = new System.Drawing.Size(52, 13);
            this.labelPitch.TabIndex = 17;
            this.labelPitch.Text = "Pitch (19)";
            // 
            // trackBarVCOPITCH
            // 
            this.trackBarVCOPITCH.Location = new System.Drawing.Point(57, 179);
            this.trackBarVCOPITCH.Maximum = 500;
            this.trackBarVCOPITCH.Name = "trackBarVCOPITCH";
            this.trackBarVCOPITCH.Size = new System.Drawing.Size(219, 42);
            this.trackBarVCOPITCH.TabIndex = 15;
            this.trackBarVCOPITCH.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVCOPITCH.Value = 500;
            this.trackBarVCOPITCH.Scroll += new System.EventHandler(this.trackBarVCOPITCH_Scroll);
            // 
            // trackBarVCOEXT
            // 
            this.trackBarVCOEXT.Location = new System.Drawing.Point(57, 123);
            this.trackBarVCOEXT.Maximum = 235;
            this.trackBarVCOEXT.Name = "trackBarVCOEXT";
            this.trackBarVCOEXT.Size = new System.Drawing.Size(219, 42);
            this.trackBarVCOEXT.TabIndex = 12;
            this.trackBarVCOEXT.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVCOEXT.Value = 235;
            this.trackBarVCOEXT.Scroll += new System.EventHandler(this.trackBarVCOEXT_Scroll);
            // 
            // labelVCOEXT
            // 
            this.labelVCOEXT.AutoSize = true;
            this.labelVCOEXT.Location = new System.Drawing.Point(6, 123);
            this.labelVCOEXT.Name = "labelVCOEXT";
            this.labelVCOEXT.Size = new System.Drawing.Size(49, 13);
            this.labelVCOEXT.TabIndex = 13;
            this.labelVCOEXT.Text = "EXT (16)";
            // 
            // cbVCOCAP
            // 
            this.cbVCOCAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVCOCAP.FormattingEnabled = true;
            this.cbVCOCAP.Location = new System.Drawing.Point(67, 19);
            this.cbVCOCAP.Name = "cbVCOCAP";
            this.cbVCOCAP.Size = new System.Drawing.Size(121, 21);
            this.cbVCOCAP.TabIndex = 10;
            this.cbVCOCAP.SelectedIndexChanged += new System.EventHandler(this.cbVCOCAP_SelectedIndexChanged);
            // 
            // checkBoxVCOEXT
            // 
            this.checkBoxVCOEXT.AutoSize = true;
            this.checkBoxVCOEXT.Location = new System.Drawing.Point(27, 100);
            this.checkBoxVCOEXT.Name = "checkBoxVCOEXT";
            this.checkBoxVCOEXT.Size = new System.Drawing.Size(122, 17);
            this.checkBoxVCOEXT.TabIndex = 9;
            this.checkBoxVCOEXT.Text = "External Source (22)";
            this.checkBoxVCOEXT.UseVisualStyleBackColor = true;
            this.checkBoxVCOEXT.CheckedChanged += new System.EventHandler(this.checkBoxVCOEXT_CheckedChanged);
            // 
            // labelVCOCAP
            // 
            this.labelVCOCAP.AutoSize = true;
            this.labelVCOCAP.Location = new System.Drawing.Point(6, 22);
            this.labelVCOCAP.Name = "labelVCOCAP";
            this.labelVCOCAP.Size = new System.Drawing.Size(49, 13);
            this.labelVCOCAP.TabIndex = 8;
            this.labelVCOCAP.Text = "CAP (17)";
            // 
            // groupBoxNoiseGenerator
            // 
            this.groupBoxNoiseGenerator.Controls.Add(this.labelNOISEGENRESTOTAL);
            this.groupBoxNoiseGenerator.Controls.Add(this.labelNoiseFrequency);
            this.groupBoxNoiseGenerator.Controls.Add(this.labelNoiseGeneratorRES);
            this.groupBoxNoiseGenerator.Controls.Add(this.cbNOISEGENRES);
            this.groupBoxNoiseGenerator.Controls.Add(this.trackBarNOISEGENRES);
            this.groupBoxNoiseGenerator.Location = new System.Drawing.Point(12, 395);
            this.groupBoxNoiseGenerator.Name = "groupBoxNoiseGenerator";
            this.groupBoxNoiseGenerator.Size = new System.Drawing.Size(290, 69);
            this.groupBoxNoiseGenerator.TabIndex = 10;
            this.groupBoxNoiseGenerator.TabStop = false;
            this.groupBoxNoiseGenerator.Text = "Noise Generator";
            // 
            // labelNOISEGENRESTOTAL
            // 
            this.labelNOISEGENRESTOTAL.AutoSize = true;
            this.labelNOISEGENRESTOTAL.Location = new System.Drawing.Point(237, 25);
            this.labelNOISEGENRESTOTAL.Name = "labelNOISEGENRESTOTAL";
            this.labelNOISEGENRESTOTAL.Size = new System.Drawing.Size(31, 13);
            this.labelNOISEGENRESTOTAL.TabIndex = 22;
            this.labelNOISEGENRESTOTAL.Text = "0 kΩ";
            this.labelNOISEGENRESTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNoiseFrequency
            // 
            this.labelNoiseFrequency.AutoSize = true;
            this.labelNoiseFrequency.Location = new System.Drawing.Point(194, 40);
            this.labelNoiseFrequency.Name = "labelNoiseFrequency";
            this.labelNoiseFrequency.Size = new System.Drawing.Size(29, 13);
            this.labelNoiseFrequency.TabIndex = 21;
            this.labelNoiseFrequency.Text = "0 Hz";
            // 
            // labelNoiseGeneratorRES
            // 
            this.labelNoiseGeneratorRES.AutoSize = true;
            this.labelNoiseGeneratorRES.Location = new System.Drawing.Point(6, 16);
            this.labelNoiseGeneratorRES.Name = "labelNoiseGeneratorRES";
            this.labelNoiseGeneratorRES.Size = new System.Drawing.Size(44, 13);
            this.labelNoiseGeneratorRES.TabIndex = 20;
            this.labelNoiseGeneratorRES.Text = "RES (4)";
            // 
            // cbNOISEGENRES
            // 
            this.cbNOISEGENRES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNOISEGENRES.FormattingEnabled = true;
            this.cbNOISEGENRES.Location = new System.Drawing.Point(64, 36);
            this.cbNOISEGENRES.Name = "cbNOISEGENRES";
            this.cbNOISEGENRES.Size = new System.Drawing.Size(121, 21);
            this.cbNOISEGENRES.TabIndex = 19;
            this.cbNOISEGENRES.SelectedIndexChanged += new System.EventHandler(this.cbNOISEGENRES_SelectedIndexChanged);
            // 
            // trackBarNOISEGENRES
            // 
            this.trackBarNOISEGENRES.LargeChange = 10000;
            this.trackBarNOISEGENRES.Location = new System.Drawing.Point(54, 11);
            this.trackBarNOISEGENRES.Maximum = 8000000;
            this.trackBarNOISEGENRES.Minimum = 7500;
            this.trackBarNOISEGENRES.Name = "trackBarNOISEGENRES";
            this.trackBarNOISEGENRES.Size = new System.Drawing.Size(219, 42);
            this.trackBarNOISEGENRES.TabIndex = 18;
            this.trackBarNOISEGENRES.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarNOISEGENRES.Value = 7500;
            this.trackBarNOISEGENRES.Scroll += new System.EventHandler(this.trackBarNOISEGENRES_Scroll);
            // 
            // groupBoxMixer
            // 
            this.groupBoxMixer.Controls.Add(this.richTextBox1);
            this.groupBoxMixer.Controls.Add(this.checkBoxMIXNOISE);
            this.groupBoxMixer.Controls.Add(this.checkBoxMIXVCO);
            this.groupBoxMixer.Controls.Add(this.checkBoxMIXSLF);
            this.groupBoxMixer.Location = new System.Drawing.Point(312, 41);
            this.groupBoxMixer.Name = "groupBoxMixer";
            this.groupBoxMixer.Size = new System.Drawing.Size(315, 144);
            this.groupBoxMixer.TabIndex = 11;
            this.groupBoxMixer.TabStop = false;
            this.groupBoxMixer.Text = "Mixer (25,26,27)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(71, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(237, 126);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "C (27)\tB (25)\tC (26)\t\nL\tL\tL\tVCO\nL\tL\tH\tSLF\nL\tH\tL\tNOISE\nL\tH\tH\tVCO/NOISE\nH\tL\tL\tSLF/N" +
                "OISE\nH\tL\tH\tSLF/VCO/NOISE\nH\tH\tL\tSLF/VCO\nH\tH\tH\tINHIBIT";
            // 
            // checkBoxMIXNOISE
            // 
            this.checkBoxMIXNOISE.AutoCheck = false;
            this.checkBoxMIXNOISE.AutoSize = true;
            this.checkBoxMIXNOISE.Location = new System.Drawing.Point(7, 68);
            this.checkBoxMIXNOISE.Name = "checkBoxMIXNOISE";
            this.checkBoxMIXNOISE.Size = new System.Drawing.Size(53, 17);
            this.checkBoxMIXNOISE.TabIndex = 2;
            this.checkBoxMIXNOISE.Text = "Noise";
            this.checkBoxMIXNOISE.UseVisualStyleBackColor = true;
            this.checkBoxMIXNOISE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkBoxMIXNOISE_KeyPress);
            this.checkBoxMIXNOISE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkBoxMIXNOISE_MouseUp);
            // 
            // checkBoxMIXVCO
            // 
            this.checkBoxMIXVCO.AutoCheck = false;
            this.checkBoxMIXVCO.AutoSize = true;
            this.checkBoxMIXVCO.Checked = true;
            this.checkBoxMIXVCO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMIXVCO.Location = new System.Drawing.Point(7, 44);
            this.checkBoxMIXVCO.Name = "checkBoxMIXVCO";
            this.checkBoxMIXVCO.Size = new System.Drawing.Size(48, 17);
            this.checkBoxMIXVCO.TabIndex = 1;
            this.checkBoxMIXVCO.Text = "VCO";
            this.checkBoxMIXVCO.UseVisualStyleBackColor = true;
            this.checkBoxMIXVCO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkBoxMIXVCO_KeyPress);
            this.checkBoxMIXVCO.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkBoxMIXVCO_MouseUp);
            // 
            // checkBoxMIXSLF
            // 
            this.checkBoxMIXSLF.AutoCheck = false;
            this.checkBoxMIXSLF.AutoSize = true;
            this.checkBoxMIXSLF.Location = new System.Drawing.Point(7, 20);
            this.checkBoxMIXSLF.Name = "checkBoxMIXSLF";
            this.checkBoxMIXSLF.Size = new System.Drawing.Size(45, 17);
            this.checkBoxMIXSLF.TabIndex = 0;
            this.checkBoxMIXSLF.Text = "SLF";
            this.checkBoxMIXSLF.UseVisualStyleBackColor = true;
            this.checkBoxMIXSLF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkBoxMIXSLF_KeyPress);
            this.checkBoxMIXSLF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkBoxMIXSLF_MouseUp);
            // 
            // groupBoxEnvelope
            // 
            this.groupBoxEnvelope.Controls.Add(this.labelDECRESTOTAL);
            this.groupBoxEnvelope.Controls.Add(this.labelATKRESTOTAL);
            this.groupBoxEnvelope.Controls.Add(this.richTextBox2);
            this.groupBoxEnvelope.Controls.Add(this.labelDecayLength);
            this.groupBoxEnvelope.Controls.Add(this.labelAttackLength);
            this.groupBoxEnvelope.Controls.Add(this.cbENVDECRES);
            this.groupBoxEnvelope.Controls.Add(this.trackBarENVDECRES);
            this.groupBoxEnvelope.Controls.Add(this.labelEnvelopeDEC);
            this.groupBoxEnvelope.Controls.Add(this.cbENVATKRES);
            this.groupBoxEnvelope.Controls.Add(this.cbENVCAP);
            this.groupBoxEnvelope.Controls.Add(this.labelEnvelopeCAP);
            this.groupBoxEnvelope.Controls.Add(this.trackBarENVATKRES);
            this.groupBoxEnvelope.Controls.Add(this.labelEnvelopeATK);
            this.groupBoxEnvelope.Controls.Add(this.rbENVVCOALT);
            this.groupBoxEnvelope.Controls.Add(this.rbENVONESHOT);
            this.groupBoxEnvelope.Controls.Add(this.rbENVMIXER);
            this.groupBoxEnvelope.Controls.Add(this.rbENVVCO);
            this.groupBoxEnvelope.Location = new System.Drawing.Point(312, 339);
            this.groupBoxEnvelope.Name = "groupBoxEnvelope";
            this.groupBoxEnvelope.Size = new System.Drawing.Size(315, 237);
            this.groupBoxEnvelope.TabIndex = 12;
            this.groupBoxEnvelope.TabStop = false;
            this.groupBoxEnvelope.Text = "Envelope (1,28)";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(108, 16);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(173, 78);
            this.richTextBox2.TabIndex = 24;
            this.richTextBox2.Text = "A (1)\tB (28)\t\nL\tL\tVCO \nL\tH\tMIXER\nH\tL\tONESHOT\nH\tH\tVCO/ALT.";
            // 
            // labelDecayLength
            // 
            this.labelDecayLength.AutoSize = true;
            this.labelDecayLength.Location = new System.Drawing.Point(199, 202);
            this.labelDecayLength.Name = "labelDecayLength";
            this.labelDecayLength.Size = new System.Drawing.Size(33, 13);
            this.labelDecayLength.TabIndex = 23;
            this.labelDecayLength.Text = "0 sec";
            // 
            // labelAttackLength
            // 
            this.labelAttackLength.AutoSize = true;
            this.labelAttackLength.Location = new System.Drawing.Point(199, 162);
            this.labelAttackLength.Name = "labelAttackLength";
            this.labelAttackLength.Size = new System.Drawing.Size(33, 13);
            this.labelAttackLength.TabIndex = 22;
            this.labelAttackLength.Text = "0 sec";
            // 
            // cbENVDECRES
            // 
            this.cbENVDECRES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbENVDECRES.FormattingEnabled = true;
            this.cbENVDECRES.Location = new System.Drawing.Point(72, 199);
            this.cbENVDECRES.Name = "cbENVDECRES";
            this.cbENVDECRES.Size = new System.Drawing.Size(121, 21);
            this.cbENVDECRES.TabIndex = 21;
            this.cbENVDECRES.SelectedIndexChanged += new System.EventHandler(this.cbENVDECRES_SelectedIndexChanged);
            // 
            // trackBarENVDECRES
            // 
            this.trackBarENVDECRES.LargeChange = 10000;
            this.trackBarENVDECRES.Location = new System.Drawing.Point(62, 178);
            this.trackBarENVDECRES.Maximum = 8000000;
            this.trackBarENVDECRES.Minimum = 7500;
            this.trackBarENVDECRES.Name = "trackBarENVDECRES";
            this.trackBarENVDECRES.Size = new System.Drawing.Size(219, 42);
            this.trackBarENVDECRES.TabIndex = 20;
            this.trackBarENVDECRES.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarENVDECRES.Value = 7500;
            this.trackBarENVDECRES.Scroll += new System.EventHandler(this.trackBarENVDECRES_Scroll);
            // 
            // labelEnvelopeDEC
            // 
            this.labelEnvelopeDEC.AutoSize = true;
            this.labelEnvelopeDEC.Location = new System.Drawing.Point(7, 189);
            this.labelEnvelopeDEC.Name = "labelEnvelopeDEC";
            this.labelEnvelopeDEC.Size = new System.Drawing.Size(44, 13);
            this.labelEnvelopeDEC.TabIndex = 19;
            this.labelEnvelopeDEC.Text = "DEC (7)";
            // 
            // cbENVATKRES
            // 
            this.cbENVATKRES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbENVATKRES.FormattingEnabled = true;
            this.cbENVATKRES.Location = new System.Drawing.Point(72, 159);
            this.cbENVATKRES.Name = "cbENVATKRES";
            this.cbENVATKRES.Size = new System.Drawing.Size(121, 21);
            this.cbENVATKRES.TabIndex = 18;
            this.cbENVATKRES.SelectedIndexChanged += new System.EventHandler(this.cbENVATKRES_SelectedIndexChanged);
            // 
            // cbENVCAP
            // 
            this.cbENVCAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbENVCAP.FormattingEnabled = true;
            this.cbENVCAP.Items.AddRange(new object[] {
            "100 pF",
            "500 pF",
            "50 nF",
            "100 nF",
            "470 nF",
            "1 µF"});
            this.cbENVCAP.Location = new System.Drawing.Point(72, 111);
            this.cbENVCAP.Name = "cbENVCAP";
            this.cbENVCAP.Size = new System.Drawing.Size(121, 21);
            this.cbENVCAP.TabIndex = 17;
            this.cbENVCAP.SelectedIndexChanged += new System.EventHandler(this.cbENVCAP_SelectedIndexChanged);
            // 
            // labelEnvelopeCAP
            // 
            this.labelEnvelopeCAP.AutoSize = true;
            this.labelEnvelopeCAP.Location = new System.Drawing.Point(9, 111);
            this.labelEnvelopeCAP.Name = "labelEnvelopeCAP";
            this.labelEnvelopeCAP.Size = new System.Drawing.Size(43, 13);
            this.labelEnvelopeCAP.TabIndex = 16;
            this.labelEnvelopeCAP.Text = "CAP (8)";
            // 
            // trackBarENVATKRES
            // 
            this.trackBarENVATKRES.LargeChange = 10000;
            this.trackBarENVATKRES.Location = new System.Drawing.Point(62, 138);
            this.trackBarENVATKRES.Maximum = 8000000;
            this.trackBarENVATKRES.Minimum = 7500;
            this.trackBarENVATKRES.Name = "trackBarENVATKRES";
            this.trackBarENVATKRES.Size = new System.Drawing.Size(219, 42);
            this.trackBarENVATKRES.TabIndex = 15;
            this.trackBarENVATKRES.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarENVATKRES.Value = 7500;
            this.trackBarENVATKRES.Scroll += new System.EventHandler(this.trackBarENVATKRES_Scroll);
            // 
            // labelEnvelopeATK
            // 
            this.labelEnvelopeATK.AutoSize = true;
            this.labelEnvelopeATK.Location = new System.Drawing.Point(9, 138);
            this.labelEnvelopeATK.Name = "labelEnvelopeATK";
            this.labelEnvelopeATK.Size = new System.Drawing.Size(49, 13);
            this.labelEnvelopeATK.TabIndex = 14;
            this.labelEnvelopeATK.Text = "ATK (10)";
            // 
            // rbENVVCOALT
            // 
            this.rbENVVCOALT.AutoSize = true;
            this.rbENVVCOALT.Location = new System.Drawing.Point(10, 40);
            this.rbENVVCOALT.Name = "rbENVVCOALT";
            this.rbENVVCOALT.Size = new System.Drawing.Size(73, 17);
            this.rbENVVCOALT.TabIndex = 4;
            this.rbENVVCOALT.TabStop = true;
            this.rbENVVCOALT.Text = "VCO / Alt.";
            this.rbENVVCOALT.UseVisualStyleBackColor = true;
            this.rbENVVCOALT.CheckedChanged += new System.EventHandler(this.rbENVVCOALT_CheckedChanged);
            // 
            // rbENVONESHOT
            // 
            this.rbENVONESHOT.AutoSize = true;
            this.rbENVONESHOT.Location = new System.Drawing.Point(10, 86);
            this.rbENVONESHOT.Name = "rbENVONESHOT";
            this.rbENVONESHOT.Size = new System.Drawing.Size(70, 17);
            this.rbENVONESHOT.TabIndex = 3;
            this.rbENVONESHOT.TabStop = true;
            this.rbENVONESHOT.Text = "One Shot";
            this.rbENVONESHOT.UseVisualStyleBackColor = true;
            this.rbENVONESHOT.CheckedChanged += new System.EventHandler(this.rbENVONESHOT_CheckedChanged);
            // 
            // rbENVMIXER
            // 
            this.rbENVMIXER.AutoSize = true;
            this.rbENVMIXER.Location = new System.Drawing.Point(10, 63);
            this.rbENVMIXER.Name = "rbENVMIXER";
            this.rbENVMIXER.Size = new System.Drawing.Size(50, 17);
            this.rbENVMIXER.TabIndex = 2;
            this.rbENVMIXER.TabStop = true;
            this.rbENVMIXER.Text = "Mixer";
            this.rbENVMIXER.UseVisualStyleBackColor = true;
            this.rbENVMIXER.CheckedChanged += new System.EventHandler(this.rbENVMIXER_CheckedChanged);
            // 
            // rbENVVCO
            // 
            this.rbENVVCO.AutoSize = true;
            this.rbENVVCO.Checked = true;
            this.rbENVVCO.Location = new System.Drawing.Point(10, 17);
            this.rbENVVCO.Name = "rbENVVCO";
            this.rbENVVCO.Size = new System.Drawing.Size(47, 17);
            this.rbENVVCO.TabIndex = 1;
            this.rbENVVCO.TabStop = true;
            this.rbENVVCO.Text = "VCO";
            this.rbENVVCO.UseVisualStyleBackColor = true;
            this.rbENVVCO.CheckedChanged += new System.EventHandler(this.rbENVVCO_CheckedChanged);
            // 
            // btnONESHOTSHOOT
            // 
            this.btnONESHOTSHOOT.Location = new System.Drawing.Point(185, 94);
            this.btnONESHOTSHOOT.Name = "btnONESHOTSHOOT";
            this.btnONESHOTSHOOT.Size = new System.Drawing.Size(75, 23);
            this.btnONESHOTSHOOT.TabIndex = 0;
            this.btnONESHOTSHOOT.Text = "Shoot (9)";
            this.btnONESHOTSHOOT.UseVisualStyleBackColor = true;
            this.btnONESHOTSHOOT.Click += new System.EventHandler(this.btnONESHOTSHOOT_Click);
            this.btnONESHOTSHOOT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnONESHOTSHOOT_MouseDown);
            this.btnONESHOTSHOOT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnONESHOTSHOOT_KeyDown);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(890, 18);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(38, 13);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonPlay,
            this.toolStripButtonPause,
            this.toolStripSeparator2,
            this.toolStripButtonBufferPlay});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(890, 25);
            this.toolStrip.TabIndex = 14;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "toolStripButtonNew";
            this.toolStripButtonNew.ToolTipText = "New configuration";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "toolStripButtonOpen";
            this.toolStripButtonOpen.ToolTipText = "Open configuration";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "toolStripButtonSave";
            this.toolStripButtonSave.ToolTipText = "Save configuration";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPlay
            // 
            this.toolStripButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlay.Image")));
            this.toolStripButtonPlay.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButtonPlay.Name = "toolStripButtonPlay";
            this.toolStripButtonPlay.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPlay.Text = "toolStripButtonPlay";
            this.toolStripButtonPlay.ToolTipText = "Save WAV and playback";
            this.toolStripButtonPlay.Click += new System.EventHandler(this.toolStripButtonPlay_Click);
            // 
            // toolStripButtonPause
            // 
            this.toolStripButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPause.Image")));
            this.toolStripButtonPause.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButtonPause.Name = "toolStripButtonPause";
            this.toolStripButtonPause.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPause.Text = "toolStripButtonPause";
            this.toolStripButtonPause.ToolTipText = "Stop WAV playback";
            this.toolStripButtonPause.Click += new System.EventHandler(this.toolStripButtonPause_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonBufferPlay
            // 
            this.toolStripButtonBufferPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBufferPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBufferPlay.Image")));
            this.toolStripButtonBufferPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBufferPlay.Name = "toolStripButtonBufferPlay";
            this.toolStripButtonBufferPlay.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBufferPlay.Text = "BufferPlay";
            this.toolStripButtonBufferPlay.ToolTipText = "Continouus direct play";
            this.toolStripButtonBufferPlay.CheckStateChanged += new System.EventHandler(this.toolStripButtonBufferPlay_CheckStateChanged);
            this.toolStripButtonBufferPlay.Click += new System.EventHandler(this.toolStripButtonBufferPlay_Click);
            // 
            // groupBoxOneShot
            // 
            this.groupBoxOneShot.Controls.Add(this.labelONESHOTRESTOTAL);
            this.groupBoxOneShot.Controls.Add(this.labelOneShotLength);
            this.groupBoxOneShot.Controls.Add(this.cbONESHOTRES);
            this.groupBoxOneShot.Controls.Add(this.cbONESHOTCAP);
            this.groupBoxOneShot.Controls.Add(this.labelOneShotCAP);
            this.groupBoxOneShot.Controls.Add(this.trackBarONESHOTRES);
            this.groupBoxOneShot.Controls.Add(this.labelOneShotRES);
            this.groupBoxOneShot.Controls.Add(this.btnONESHOTSHOOT);
            this.groupBoxOneShot.Location = new System.Drawing.Point(312, 211);
            this.groupBoxOneShot.Name = "groupBoxOneShot";
            this.groupBoxOneShot.Size = new System.Drawing.Size(315, 122);
            this.groupBoxOneShot.TabIndex = 15;
            this.groupBoxOneShot.TabStop = false;
            this.groupBoxOneShot.Text = "One Shot";
            // 
            // labelOneShotLength
            // 
            this.labelOneShotLength.AutoSize = true;
            this.labelOneShotLength.Location = new System.Drawing.Point(199, 22);
            this.labelOneShotLength.Name = "labelOneShotLength";
            this.labelOneShotLength.Size = new System.Drawing.Size(33, 13);
            this.labelOneShotLength.TabIndex = 14;
            this.labelOneShotLength.Text = "0 sec";
            // 
            // cbONESHOTRES
            // 
            this.cbONESHOTRES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbONESHOTRES.FormattingEnabled = true;
            this.cbONESHOTRES.Location = new System.Drawing.Point(72, 67);
            this.cbONESHOTRES.Name = "cbONESHOTRES";
            this.cbONESHOTRES.Size = new System.Drawing.Size(121, 21);
            this.cbONESHOTRES.TabIndex = 13;
            this.cbONESHOTRES.SelectedIndexChanged += new System.EventHandler(this.cbONESHOTRES_SelectedIndexChanged);
            // 
            // cbONESHOTCAP
            // 
            this.cbONESHOTCAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbONESHOTCAP.FormattingEnabled = true;
            this.cbONESHOTCAP.Items.AddRange(new object[] {
            "100 pF",
            "500 pF",
            "50 nF",
            "100 nF",
            "470 nF",
            "1 µF"});
            this.cbONESHOTCAP.Location = new System.Drawing.Point(72, 19);
            this.cbONESHOTCAP.Name = "cbONESHOTCAP";
            this.cbONESHOTCAP.Size = new System.Drawing.Size(121, 21);
            this.cbONESHOTCAP.TabIndex = 12;
            this.cbONESHOTCAP.SelectedIndexChanged += new System.EventHandler(this.cbONESHOTCAP_SelectedIndexChanged);
            // 
            // labelOneShotCAP
            // 
            this.labelOneShotCAP.AutoSize = true;
            this.labelOneShotCAP.Location = new System.Drawing.Point(7, 19);
            this.labelOneShotCAP.Name = "labelOneShotCAP";
            this.labelOneShotCAP.Size = new System.Drawing.Size(49, 13);
            this.labelOneShotCAP.TabIndex = 11;
            this.labelOneShotCAP.Text = "CAP (23)";
            // 
            // trackBarONESHOTRES
            // 
            this.trackBarONESHOTRES.LargeChange = 10000;
            this.trackBarONESHOTRES.Location = new System.Drawing.Point(62, 46);
            this.trackBarONESHOTRES.Maximum = 8000000;
            this.trackBarONESHOTRES.Minimum = 7500;
            this.trackBarONESHOTRES.Name = "trackBarONESHOTRES";
            this.trackBarONESHOTRES.Size = new System.Drawing.Size(219, 42);
            this.trackBarONESHOTRES.TabIndex = 10;
            this.trackBarONESHOTRES.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarONESHOTRES.Value = 7500;
            this.trackBarONESHOTRES.Scroll += new System.EventHandler(this.trackBarONESHOTRES_Scroll);
            // 
            // labelOneShotRES
            // 
            this.labelOneShotRES.AutoSize = true;
            this.labelOneShotRES.Location = new System.Drawing.Point(7, 46);
            this.labelOneShotRES.Name = "labelOneShotRES";
            this.labelOneShotRES.Size = new System.Drawing.Size(50, 13);
            this.labelOneShotRES.TabIndex = 9;
            this.labelOneShotRES.Text = "RES (24)";
            // 
            // groupBoxNoiseFilter
            // 
            this.groupBoxNoiseFilter.Controls.Add(this.labelNOISEFILTERRESTOTAL);
            this.groupBoxNoiseFilter.Controls.Add(this.labelNoiseFilterFrequency);
            this.groupBoxNoiseFilter.Controls.Add(this.cbNOISEFILTERRES);
            this.groupBoxNoiseFilter.Controls.Add(this.cbNOISEFILTERCAP);
            this.groupBoxNoiseFilter.Controls.Add(this.labelNoiseFilterCAP);
            this.groupBoxNoiseFilter.Controls.Add(this.trackBarNOISEFILTERRES);
            this.groupBoxNoiseFilter.Controls.Add(this.labelNoiseFilterRES);
            this.groupBoxNoiseFilter.Location = new System.Drawing.Point(13, 470);
            this.groupBoxNoiseFilter.Name = "groupBoxNoiseFilter";
            this.groupBoxNoiseFilter.Size = new System.Drawing.Size(290, 106);
            this.groupBoxNoiseFilter.TabIndex = 16;
            this.groupBoxNoiseFilter.TabStop = false;
            this.groupBoxNoiseFilter.Text = "Noise Filter";
            // 
            // labelNoiseFilterFrequency
            // 
            this.labelNoiseFilterFrequency.AutoSize = true;
            this.labelNoiseFilterFrequency.Location = new System.Drawing.Point(193, 20);
            this.labelNoiseFilterFrequency.Name = "labelNoiseFilterFrequency";
            this.labelNoiseFilterFrequency.Size = new System.Drawing.Size(29, 13);
            this.labelNoiseFilterFrequency.TabIndex = 17;
            this.labelNoiseFilterFrequency.Text = "0 Hz";
            // 
            // cbNOISEFILTERRES
            // 
            this.cbNOISEFILTERRES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNOISEFILTERRES.FormattingEnabled = true;
            this.cbNOISEFILTERRES.Location = new System.Drawing.Point(63, 68);
            this.cbNOISEFILTERRES.Name = "cbNOISEFILTERRES";
            this.cbNOISEFILTERRES.Size = new System.Drawing.Size(121, 21);
            this.cbNOISEFILTERRES.TabIndex = 16;
            this.cbNOISEFILTERRES.SelectedIndexChanged += new System.EventHandler(this.cbNOISEFILTERRES_SelectedIndexChanged);
            // 
            // cbNOISEFILTERCAP
            // 
            this.cbNOISEFILTERCAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNOISEFILTERCAP.FormattingEnabled = true;
            this.cbNOISEFILTERCAP.Location = new System.Drawing.Point(63, 20);
            this.cbNOISEFILTERCAP.Name = "cbNOISEFILTERCAP";
            this.cbNOISEFILTERCAP.Size = new System.Drawing.Size(121, 21);
            this.cbNOISEFILTERCAP.TabIndex = 15;
            this.cbNOISEFILTERCAP.SelectedIndexChanged += new System.EventHandler(this.cbNOISEFILTERCAP_SelectedIndexChanged);
            // 
            // labelNoiseFilterCAP
            // 
            this.labelNoiseFilterCAP.AutoSize = true;
            this.labelNoiseFilterCAP.Location = new System.Drawing.Point(6, 20);
            this.labelNoiseFilterCAP.Name = "labelNoiseFilterCAP";
            this.labelNoiseFilterCAP.Size = new System.Drawing.Size(43, 13);
            this.labelNoiseFilterCAP.TabIndex = 14;
            this.labelNoiseFilterCAP.Text = "CAP (6)";
            // 
            // trackBarNOISEFILTERRES
            // 
            this.trackBarNOISEFILTERRES.LargeChange = 10000;
            this.trackBarNOISEFILTERRES.Location = new System.Drawing.Point(53, 47);
            this.trackBarNOISEFILTERRES.Maximum = 8000000;
            this.trackBarNOISEFILTERRES.Minimum = 7500;
            this.trackBarNOISEFILTERRES.Name = "trackBarNOISEFILTERRES";
            this.trackBarNOISEFILTERRES.Size = new System.Drawing.Size(219, 42);
            this.trackBarNOISEFILTERRES.TabIndex = 12;
            this.trackBarNOISEFILTERRES.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarNOISEFILTERRES.Value = 7500;
            this.trackBarNOISEFILTERRES.Scroll += new System.EventHandler(this.trackBarNOISEFILTERRES_Scroll);
            // 
            // labelNoiseFilterRES
            // 
            this.labelNoiseFilterRES.AutoSize = true;
            this.labelNoiseFilterRES.Location = new System.Drawing.Point(6, 47);
            this.labelNoiseFilterRES.Name = "labelNoiseFilterRES";
            this.labelNoiseFilterRES.Size = new System.Drawing.Size(44, 13);
            this.labelNoiseFilterRES.TabIndex = 13;
            this.labelNoiseFilterRES.Text = "RES (5)";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.labelOutputVoltageMinMax);
            this.groupBoxOutput.Controls.Add(this.labelOutput);
            this.groupBoxOutput.Controls.Add(this.label3);
            this.groupBoxOutput.Controls.Add(this.label2);
            this.groupBoxOutput.Controls.Add(this.cbAMPLITUDERES);
            this.groupBoxOutput.Controls.Add(this.cbFEEDBACKRES);
            this.groupBoxOutput.Location = new System.Drawing.Point(633, 41);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(231, 144);
            this.groupBoxOutput.TabIndex = 17;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // labelOutputVoltageMinMax
            // 
            this.labelOutputVoltageMinMax.AutoSize = true;
            this.labelOutputVoltageMinMax.Location = new System.Drawing.Point(90, 123);
            this.labelOutputVoltageMinMax.Name = "labelOutputVoltageMinMax";
            this.labelOutputVoltageMinMax.Size = new System.Drawing.Size(48, 13);
            this.labelOutputVoltageMinMax.TabIndex = 7;
            this.labelOutputVoltageMinMax.Text = "0 V - 1 V";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(10, 123);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(39, 13);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amplitude RES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Feedback RES";
            // 
            // cbAMPLITUDERES
            // 
            this.cbAMPLITUDERES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAMPLITUDERES.FormattingEnabled = true;
            this.cbAMPLITUDERES.Items.AddRange(new object[] {
            "8000",
            "11025",
            "22050",
            "32000",
            "44100",
            "48000",
            "96000",
            "192000"});
            this.cbAMPLITUDERES.Location = new System.Drawing.Point(93, 91);
            this.cbAMPLITUDERES.Name = "cbAMPLITUDERES";
            this.cbAMPLITUDERES.Size = new System.Drawing.Size(109, 21);
            this.cbAMPLITUDERES.TabIndex = 3;
            this.cbAMPLITUDERES.SelectedIndexChanged += new System.EventHandler(this.cbAMPLITUDERES_SelectedIndexChanged);
            // 
            // cbFEEDBACKRES
            // 
            this.cbFEEDBACKRES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFEEDBACKRES.FormattingEnabled = true;
            this.cbFEEDBACKRES.Items.AddRange(new object[] {
            "8000",
            "11025",
            "22050",
            "32000",
            "44100",
            "48000",
            "96000",
            "192000"});
            this.cbFEEDBACKRES.Location = new System.Drawing.Point(93, 64);
            this.cbFEEDBACKRES.Name = "cbFEEDBACKRES";
            this.cbFEEDBACKRES.Size = new System.Drawing.Size(109, 21);
            this.cbFEEDBACKRES.TabIndex = 2;
            this.cbFEEDBACKRES.SelectedIndexChanged += new System.EventHandler(this.cbFEEDBACKRES_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sample Rate";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8000",
            "11025",
            "22050",
            "32000",
            "44100",
            "48000",
            "96000",
            "192000"});
            this.comboBox1.Location = new System.Drawing.Point(87, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBoxSystem
            // 
            this.groupBoxSystem.Controls.Add(this.comboBox2);
            this.groupBoxSystem.Controls.Add(this.label6);
            this.groupBoxSystem.Controls.Add(this.comboBox1);
            this.groupBoxSystem.Controls.Add(this.label1);
            this.groupBoxSystem.Location = new System.Drawing.Point(633, 211);
            this.groupBoxSystem.Name = "groupBoxSystem";
            this.groupBoxSystem.Size = new System.Drawing.Size(230, 121);
            this.groupBoxSystem.TabIndex = 18;
            this.groupBoxSystem.TabStop = false;
            this.groupBoxSystem.Text = "System";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "20"});
            this.comboBox2.Location = new System.Drawing.Point(87, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(109, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Length";
            // 
            // labelNOISEFILTERRESTOTAL
            // 
            this.labelNOISEFILTERRESTOTAL.AutoSize = true;
            this.labelNOISEFILTERRESTOTAL.Location = new System.Drawing.Point(236, 68);
            this.labelNOISEFILTERRESTOTAL.Name = "labelNOISEFILTERRESTOTAL";
            this.labelNOISEFILTERRESTOTAL.Size = new System.Drawing.Size(31, 13);
            this.labelNOISEFILTERRESTOTAL.TabIndex = 23;
            this.labelNOISEFILTERRESTOTAL.Text = "0 kΩ";
            this.labelNOISEFILTERRESTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelONESHOTRESTOTAL
            // 
            this.labelONESHOTRESTOTAL.AutoSize = true;
            this.labelONESHOTRESTOTAL.Location = new System.Drawing.Point(240, 64);
            this.labelONESHOTRESTOTAL.Name = "labelONESHOTRESTOTAL";
            this.labelONESHOTRESTOTAL.Size = new System.Drawing.Size(31, 13);
            this.labelONESHOTRESTOTAL.TabIndex = 24;
            this.labelONESHOTRESTOTAL.Text = "0 kΩ";
            this.labelONESHOTRESTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelATKRESTOTAL
            // 
            this.labelATKRESTOTAL.AutoSize = true;
            this.labelATKRESTOTAL.Location = new System.Drawing.Point(238, 151);
            this.labelATKRESTOTAL.Name = "labelATKRESTOTAL";
            this.labelATKRESTOTAL.Size = new System.Drawing.Size(31, 13);
            this.labelATKRESTOTAL.TabIndex = 25;
            this.labelATKRESTOTAL.Text = "0 kΩ";
            this.labelATKRESTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDECRESTOTAL
            // 
            this.labelDECRESTOTAL.AutoSize = true;
            this.labelDECRESTOTAL.Location = new System.Drawing.Point(240, 199);
            this.labelDECRESTOTAL.Name = "labelDECRESTOTAL";
            this.labelDECRESTOTAL.Size = new System.Drawing.Size(31, 13);
            this.labelDECRESTOTAL.TabIndex = 26;
            this.labelDECRESTOTAL.Text = "0 kΩ";
            this.labelDECRESTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 597);
            this.Controls.Add(this.groupBoxSystem);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxNoiseFilter);
            this.Controls.Add(this.groupBoxOneShot);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBoxEnvelope);
            this.Controls.Add(this.groupBoxMixer);
            this.Controls.Add(this.groupBoxNoiseGenerator);
            this.Controls.Add(this.groupBoxVCO);
            this.Controls.Add(this.groupBoxSLF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmulatorForm";
            this.Text = "SN76477 Emulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmulatorForm_FormClosing);
            this.Load += new System.EventHandler(this.EmulatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVCORES)).EndInit();
            this.groupBoxSLF.ResumeLayout(false);
            this.groupBoxSLF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSLFRES)).EndInit();
            this.groupBoxVCO.ResumeLayout(false);
            this.groupBoxVCO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVCOPITCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVCOEXT)).EndInit();
            this.groupBoxNoiseGenerator.ResumeLayout(false);
            this.groupBoxNoiseGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNOISEGENRES)).EndInit();
            this.groupBoxMixer.ResumeLayout(false);
            this.groupBoxMixer.PerformLayout();
            this.groupBoxEnvelope.ResumeLayout(false);
            this.groupBoxEnvelope.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarENVDECRES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarENVATKRES)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBoxOneShot.ResumeLayout(false);
            this.groupBoxOneShot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarONESHOTRES)).EndInit();
            this.groupBoxNoiseFilter.ResumeLayout(false);
            this.groupBoxNoiseFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNOISEFILTERRES)).EndInit();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.groupBoxSystem.ResumeLayout(false);
            this.groupBoxSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSLFRES;
        private System.Windows.Forms.TrackBar trackBarVCORES;
        private System.Windows.Forms.Label labelVCORES;
        private System.Windows.Forms.GroupBox groupBoxSLF;
        private System.Windows.Forms.Label labelSLFCAP;
        private System.Windows.Forms.TrackBar trackBarSLFRES;
        private System.Windows.Forms.GroupBox groupBoxVCO;
        private System.Windows.Forms.CheckBox checkBoxVCOEXT;
        private System.Windows.Forms.Label labelVCOCAP;
        private System.Windows.Forms.GroupBox groupBoxNoiseGenerator;
        private System.Windows.Forms.GroupBox groupBoxMixer;
        private System.Windows.Forms.CheckBox checkBoxMIXNOISE;
        private System.Windows.Forms.CheckBox checkBoxMIXVCO;
        private System.Windows.Forms.CheckBox checkBoxMIXSLF;
        private System.Windows.Forms.GroupBox groupBoxEnvelope;
        private System.Windows.Forms.ComboBox cbSLFCAP;
        private System.Windows.Forms.Button btnONESHOTSHOOT;
        private System.Windows.Forms.TrackBar trackBarVCOEXT;
        private System.Windows.Forms.Label labelVCOEXT;
        private System.Windows.Forms.ComboBox cbVCOCAP;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Label labelPitch;
        private System.Windows.Forms.TrackBar trackBarVCOPITCH;
        private System.Windows.Forms.RadioButton rbENVVCOALT;
        private System.Windows.Forms.RadioButton rbENVONESHOT;
        private System.Windows.Forms.RadioButton rbENVMIXER;
        private System.Windows.Forms.RadioButton rbENVVCO;
        private System.Windows.Forms.GroupBox groupBoxOneShot;
        private System.Windows.Forms.ComboBox cbONESHOTRES;
        private System.Windows.Forms.ComboBox cbONESHOTCAP;
        private System.Windows.Forms.Label labelOneShotCAP;
        private System.Windows.Forms.TrackBar trackBarONESHOTRES;
        private System.Windows.Forms.Label labelOneShotRES;
        private System.Windows.Forms.ComboBox cbENVDECRES;
        private System.Windows.Forms.TrackBar trackBarENVDECRES;
        private System.Windows.Forms.Label labelEnvelopeDEC;
        private System.Windows.Forms.ComboBox cbENVATKRES;
        private System.Windows.Forms.ComboBox cbENVCAP;
        private System.Windows.Forms.Label labelEnvelopeCAP;
        private System.Windows.Forms.TrackBar trackBarENVATKRES;
        private System.Windows.Forms.Label labelEnvelopeATK;
        private System.Windows.Forms.Label labelNoiseGeneratorRES;
        private System.Windows.Forms.ComboBox cbNOISEGENRES;
        private System.Windows.Forms.TrackBar trackBarNOISEGENRES;
        private System.Windows.Forms.GroupBox groupBoxNoiseFilter;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ComboBox cbNOISEFILTERRES;
        private System.Windows.Forms.ComboBox cbNOISEFILTERCAP;
        private System.Windows.Forms.Label labelNoiseFilterCAP;
        private System.Windows.Forms.TrackBar trackBarNOISEFILTERRES;
        private System.Windows.Forms.Label labelNoiseFilterRES;
        private System.Windows.Forms.ComboBox cbSLFRES;
        private System.Windows.Forms.ComboBox cbVCORES;
        private System.Windows.Forms.Label labelSLFFrequency;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPlay;
        private System.Windows.Forms.ToolStripButton toolStripButtonPause;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonBufferPlay;
        private System.Windows.Forms.Label labelVCOFrequency;
        private System.Windows.Forms.Label labelNoiseFrequency;
        private System.Windows.Forms.Label labelDecayLength;
        private System.Windows.Forms.Label labelAttackLength;
        private System.Windows.Forms.Label labelOneShotLength;
        private System.Windows.Forms.Label labelNoiseFilterFrequency;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label labelVCOPitchDutyCycle;
        private System.Windows.Forms.Label labelVCOPitchVoltage;
        private System.Windows.Forms.Label labelVCOEXTFrequency;
        private System.Windows.Forms.Label labelVCOEXTVoltage;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAMPLITUDERES;
        private System.Windows.Forms.ComboBox cbFEEDBACKRES;
        private System.Windows.Forms.Label labelOutputVoltageMinMax;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelSLFRESTOTAL;
        private System.Windows.Forms.Label labelVCORESTOTAL;
        private System.Windows.Forms.Label labelNOISEGENRESTOTAL;
        private System.Windows.Forms.GroupBox groupBoxSystem;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNOISEFILTERRESTOTAL;
        private System.Windows.Forms.Label labelDECRESTOTAL;
        private System.Windows.Forms.Label labelATKRESTOTAL;
        private System.Windows.Forms.Label labelONESHOTRESTOTAL;
    }
}

