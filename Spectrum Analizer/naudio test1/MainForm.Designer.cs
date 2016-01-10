
namespace naudio_test1
{
	partial class MainForm
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
            this.deviceSelectComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.convertedPeakProgressBar = new ProgressBars.Basic.BasicProgressBar();
            this.minOffsetTrackBar = new System.Windows.Forms.TrackBar();
            this.maxOffsetTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.realPeakProgressBar = new ProgressBars.Basic.BasicProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.portSelectComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.openPortButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FFTLenghtComboBox = new System.Windows.Forms.ComboBox();
            this.spectrumBar1 = new ProgressBars.Basic.BasicProgressBar();
            this.spectrumPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bufferLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.convertedSpectrumProgressBar3 = new ProgressBars.Basic.BasicProgressBar();
            this.convertedSpectrumProgressBar2 = new ProgressBars.Basic.BasicProgressBar();
            this.convertedSpectrumProgressBar1 = new ProgressBars.Basic.BasicProgressBar();
            this.spectrumBar3 = new ProgressBars.Basic.BasicProgressBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.spectrumBar2 = new ProgressBars.Basic.BasicProgressBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logScaleScrollBar = new System.Windows.Forms.TrackBar();
            this.spectrumScaleScrollBar = new System.Windows.Forms.TrackBar();
            this.spectogramPictureBox = new System.Windows.Forms.PictureBox();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minOffsetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxOffsetTrackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumPictureBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bufferLengthNumericUpDown)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logScaleScrollBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumScaleScrollBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectogramPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceSelectComboBox
            // 
            this.deviceSelectComboBox.FormattingEnabled = true;
            this.deviceSelectComboBox.Location = new System.Drawing.Point(17, 20);
            this.deviceSelectComboBox.Name = "deviceSelectComboBox";
            this.deviceSelectComboBox.Size = new System.Drawing.Size(369, 21);
            this.deviceSelectComboBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.convertedPeakProgressBar);
            this.groupBox2.Location = new System.Drawing.Point(1174, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Master Output";
            // 
            // convertedPeakProgressBar
            // 
            this.convertedPeakProgressBar.BackColor = System.Drawing.Color.DarkGray;
            this.convertedPeakProgressBar.BorderThickness = 3;
            this.convertedPeakProgressBar.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.convertedPeakProgressBar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.convertedPeakProgressBar.Location = new System.Drawing.Point(17, 19);
            this.convertedPeakProgressBar.Maximum = 500;
            this.convertedPeakProgressBar.Name = "convertedPeakProgressBar";
            this.convertedPeakProgressBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.convertedPeakProgressBar.Size = new System.Drawing.Size(387, 32);
            this.convertedPeakProgressBar.TabIndex = 7;
            this.convertedPeakProgressBar.Text = "basicProgressBar1";
            this.convertedPeakProgressBar.TextStyle = ProgressBars.Basic.BasicProgressBar.TextStyleType.None;
            // 
            // minOffsetTrackBar
            // 
            this.minOffsetTrackBar.LargeChange = 20;
            this.minOffsetTrackBar.Location = new System.Drawing.Point(6, 19);
            this.minOffsetTrackBar.Maximum = 500;
            this.minOffsetTrackBar.Name = "minOffsetTrackBar";
            this.minOffsetTrackBar.Size = new System.Drawing.Size(408, 45);
            this.minOffsetTrackBar.SmallChange = 10;
            this.minOffsetTrackBar.TabIndex = 5;
            this.minOffsetTrackBar.TickFrequency = 10;
            this.minOffsetTrackBar.Value = 1;
            // 
            // maxOffsetTrackBar
            // 
            this.maxOffsetTrackBar.LargeChange = 20;
            this.maxOffsetTrackBar.Location = new System.Drawing.Point(6, 79);
            this.maxOffsetTrackBar.Maximum = 500;
            this.maxOffsetTrackBar.Minimum = 1;
            this.maxOffsetTrackBar.Name = "maxOffsetTrackBar";
            this.maxOffsetTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maxOffsetTrackBar.Size = new System.Drawing.Size(408, 45);
            this.maxOffsetTrackBar.SmallChange = 10;
            this.maxOffsetTrackBar.TabIndex = 5;
            this.maxOffsetTrackBar.TickFrequency = 10;
            this.maxOffsetTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.maxOffsetTrackBar.Value = 255;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.realPeakProgressBar);
            this.groupBox3.Controls.Add(this.minOffsetTrackBar);
            this.groupBox3.Controls.Add(this.maxOffsetTrackBar);
            this.groupBox3.Location = new System.Drawing.Point(1174, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 130);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Master Offset";
            // 
            // realPeakProgressBar
            // 
            this.realPeakProgressBar.BackColor = System.Drawing.Color.DarkGray;
            this.realPeakProgressBar.BorderThickness = 3;
            this.realPeakProgressBar.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.realPeakProgressBar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.realPeakProgressBar.Location = new System.Drawing.Point(17, 50);
            this.realPeakProgressBar.Maximum = 500;
            this.realPeakProgressBar.Name = "realPeakProgressBar";
            this.realPeakProgressBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.realPeakProgressBar.Size = new System.Drawing.Size(387, 32);
            this.realPeakProgressBar.TabIndex = 6;
            this.realPeakProgressBar.Text = "basicProgressBar1";
            this.realPeakProgressBar.TextStyle = ProgressBars.Basic.BasicProgressBar.TextStyleType.None;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deviceSelectComboBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 52);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Device";
            // 
            // portSelectComboBox
            // 
            this.portSelectComboBox.FormattingEnabled = true;
            this.portSelectComboBox.Location = new System.Drawing.Point(17, 16);
            this.portSelectComboBox.Name = "portSelectComboBox";
            this.portSelectComboBox.Size = new System.Drawing.Size(135, 21);
            this.portSelectComboBox.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.openPortButton);
            this.groupBox5.Controls.Add(this.portSelectComboBox);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 48);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Com Port";
            // 
            // openPortButton
            // 
            this.openPortButton.Location = new System.Drawing.Point(158, 16);
            this.openPortButton.Name = "openPortButton";
            this.openPortButton.Size = new System.Drawing.Size(83, 21);
            this.openPortButton.TabIndex = 10;
            this.openPortButton.Text = "Open Port";
            this.openPortButton.UseVisualStyleBackColor = true;
            this.openPortButton.Click += new System.EventHandler(this.openPortButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FFTLenghtComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 48);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FFT Length";
            // 
            // FFTLenghtComboBox
            // 
            this.FFTLenghtComboBox.FormattingEnabled = true;
            this.FFTLenghtComboBox.Location = new System.Drawing.Point(17, 16);
            this.FFTLenghtComboBox.Name = "FFTLenghtComboBox";
            this.FFTLenghtComboBox.Size = new System.Drawing.Size(121, 21);
            this.FFTLenghtComboBox.TabIndex = 0;
            // 
            // spectrumBar1
            // 
            this.spectrumBar1.BackColor = System.Drawing.Color.LightCyan;
            this.spectrumBar1.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.spectrumBar1.ForeColor = System.Drawing.Color.Red;
            this.spectrumBar1.Location = new System.Drawing.Point(44, 74);
            this.spectrumBar1.Maximum = 500;
            this.spectrumBar1.Name = "spectrumBar1";
            this.spectrumBar1.Size = new System.Drawing.Size(26, 251);
            this.spectrumBar1.TabIndex = 13;
            this.spectrumBar1.Text = "basicProgressBar1";
            this.spectrumBar1.TextStyle = ProgressBars.Basic.BasicProgressBar.TextStyleType.None;
            this.spectrumBar1.Value = 0;
            // 
            // spectrumPictureBox
            // 
            this.spectrumPictureBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.spectrumPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spectrumPictureBox.Location = new System.Drawing.Point(12, 368);
            this.spectrumPictureBox.Name = "spectrumPictureBox";
            this.spectrumPictureBox.Size = new System.Drawing.Size(1161, 309);
            this.spectrumPictureBox.TabIndex = 16;
            this.spectrumPictureBox.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bufferLengthNumericUpDown);
            this.groupBox6.Location = new System.Drawing.Point(173, 66);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(154, 48);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Buffer Size";
            // 
            // bufferLengthNumericUpDown
            // 
            this.bufferLengthNumericUpDown.Location = new System.Drawing.Point(16, 16);
            this.bufferLengthNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.bufferLengthNumericUpDown.Name = "bufferLengthNumericUpDown";
            this.bufferLengthNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.bufferLengthNumericUpDown.TabIndex = 0;
            this.bufferLengthNumericUpDown.ValueChanged += new System.EventHandler(this.bufferLengthNumericUpDown_ValueChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.convertedSpectrumProgressBar3);
            this.groupBox7.Controls.Add(this.convertedSpectrumProgressBar2);
            this.groupBox7.Controls.Add(this.convertedSpectrumProgressBar1);
            this.groupBox7.Controls.Add(this.spectrumBar3);
            this.groupBox7.Controls.Add(this.trackBar5);
            this.groupBox7.Controls.Add(this.spectrumBar2);
            this.groupBox7.Controls.Add(this.trackBar3);
            this.groupBox7.Controls.Add(this.trackBar4);
            this.groupBox7.Controls.Add(this.spectrumBar1);
            this.groupBox7.Controls.Add(this.trackBar1);
            this.groupBox7.Controls.Add(this.trackBar2);
            this.groupBox7.Controls.Add(this.trackBar6);
            this.groupBox7.Location = new System.Drawing.Point(433, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(297, 341);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "LED Spectrum Bars";
            // 
            // convertedSpectrumProgressBar3
            // 
            this.convertedSpectrumProgressBar3.BackColor = System.Drawing.Color.DarkGray;
            this.convertedSpectrumProgressBar3.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.convertedSpectrumProgressBar3.ForeColor = System.Drawing.Color.Blue;
            this.convertedSpectrumProgressBar3.Location = new System.Drawing.Point(204, 28);
            this.convertedSpectrumProgressBar3.Name = "convertedSpectrumProgressBar3";
            this.convertedSpectrumProgressBar3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.convertedSpectrumProgressBar3.Size = new System.Drawing.Size(75, 27);
            this.convertedSpectrumProgressBar3.TabIndex = 23;
            this.convertedSpectrumProgressBar3.Text = "HIGH";
            this.convertedSpectrumProgressBar3.TextStyle = ProgressBars.Basic.BasicProgressBar.TextStyleType.Text;
            // 
            // convertedSpectrumProgressBar2
            // 
            this.convertedSpectrumProgressBar2.BackColor = System.Drawing.Color.DarkGray;
            this.convertedSpectrumProgressBar2.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.convertedSpectrumProgressBar2.ForeColor = System.Drawing.Color.Green;
            this.convertedSpectrumProgressBar2.Location = new System.Drawing.Point(112, 28);
            this.convertedSpectrumProgressBar2.Name = "convertedSpectrumProgressBar2";
            this.convertedSpectrumProgressBar2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.convertedSpectrumProgressBar2.Size = new System.Drawing.Size(75, 27);
            this.convertedSpectrumProgressBar2.TabIndex = 22;
            this.convertedSpectrumProgressBar2.Text = "MID";
            this.convertedSpectrumProgressBar2.TextStyle = ProgressBars.Basic.BasicProgressBar.TextStyleType.Text;
            // 
            // convertedSpectrumProgressBar1
            // 
            this.convertedSpectrumProgressBar1.BackColor = System.Drawing.Color.DarkGray;
            this.convertedSpectrumProgressBar1.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.convertedSpectrumProgressBar1.ForeColor = System.Drawing.Color.Red;
            this.convertedSpectrumProgressBar1.Location = new System.Drawing.Point(19, 28);
            this.convertedSpectrumProgressBar1.Name = "convertedSpectrumProgressBar1";
            this.convertedSpectrumProgressBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.convertedSpectrumProgressBar1.Size = new System.Drawing.Size(75, 27);
            this.convertedSpectrumProgressBar1.TabIndex = 20;
            this.convertedSpectrumProgressBar1.Text = "LOW";
            this.convertedSpectrumProgressBar1.TextStyle = ProgressBars.Basic.BasicProgressBar.TextStyleType.Text;
            // 
            // spectrumBar3
            // 
            this.spectrumBar3.BackColor = System.Drawing.Color.LightCyan;
            this.spectrumBar3.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.spectrumBar3.ForeColor = System.Drawing.Color.Blue;
            this.spectrumBar3.Location = new System.Drawing.Point(229, 74);
            this.spectrumBar3.Maximum = 500;
            this.spectrumBar3.Name = "spectrumBar3";
            this.spectrumBar3.Size = new System.Drawing.Size(26, 251);
            this.spectrumBar3.TabIndex = 19;
            this.spectrumBar3.Text = "basicProgressBar1";
            this.spectrumBar3.TextStyle = ProgressBars.Basic.BasicProgressBar.TextStyleType.None;
            this.spectrumBar3.Value = 0;
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(204, 61);
            this.trackBar5.Maximum = 500;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar5.Size = new System.Drawing.Size(45, 277);
            this.trackBar5.TabIndex = 20;
            this.trackBar5.TickFrequency = 10;
            this.trackBar5.Value = 2;
            // 
            // spectrumBar2
            // 
            this.spectrumBar2.BackColor = System.Drawing.Color.LightCyan;
            this.spectrumBar2.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.spectrumBar2.ForeColor = System.Drawing.Color.Green;
            this.spectrumBar2.Location = new System.Drawing.Point(137, 74);
            this.spectrumBar2.Maximum = 500;
            this.spectrumBar2.Name = "spectrumBar2";
            this.spectrumBar2.Size = new System.Drawing.Size(26, 251);
            this.spectrumBar2.TabIndex = 16;
            this.spectrumBar2.Text = "basicProgressBar1";
            this.spectrumBar2.TextStyle = ProgressBars.Basic.BasicProgressBar.TextStyleType.None;
            this.spectrumBar2.Value = 0;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(112, 61);
            this.trackBar3.Maximum = 500;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 277);
            this.trackBar3.TabIndex = 17;
            this.trackBar3.TickFrequency = 10;
            this.trackBar3.Value = 2;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(157, 61);
            this.trackBar4.Maximum = 500;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(45, 277);
            this.trackBar4.TabIndex = 18;
            this.trackBar4.TickFrequency = 10;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar4.Value = 500;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(19, 61);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 277);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 2;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(64, 61);
            this.trackBar2.Maximum = 500;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 277);
            this.trackBar2.TabIndex = 15;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar2.Value = 500;
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(249, 61);
            this.trackBar6.Maximum = 500;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar6.Size = new System.Drawing.Size(45, 277);
            this.trackBar6.TabIndex = 21;
            this.trackBar6.TickFrequency = 10;
            this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar6.Value = 500;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(270, 18);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(146, 42);
            this.startButton.TabIndex = 20;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.logScaleScrollBar);
            this.groupBox8.Controls.Add(this.spectrumScaleScrollBar);
            this.groupBox8.Location = new System.Drawing.Point(12, 178);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(404, 175);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Spectrum Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Log Scale Base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Linear Scale";
            // 
            // logScaleScrollBar
            // 
            this.logScaleScrollBar.Location = new System.Drawing.Point(17, 114);
            this.logScaleScrollBar.Maximum = 100;
            this.logScaleScrollBar.Minimum = 2;
            this.logScaleScrollBar.Name = "logScaleScrollBar";
            this.logScaleScrollBar.Size = new System.Drawing.Size(369, 45);
            this.logScaleScrollBar.TabIndex = 1;
            this.logScaleScrollBar.TickFrequency = 10;
            this.logScaleScrollBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.logScaleScrollBar.Value = 10;
            // 
            // spectrumScaleScrollBar
            // 
            this.spectrumScaleScrollBar.Location = new System.Drawing.Point(17, 40);
            this.spectrumScaleScrollBar.Maximum = 200;
            this.spectrumScaleScrollBar.Minimum = 1;
            this.spectrumScaleScrollBar.Name = "spectrumScaleScrollBar";
            this.spectrumScaleScrollBar.Size = new System.Drawing.Size(369, 45);
            this.spectrumScaleScrollBar.TabIndex = 0;
            this.spectrumScaleScrollBar.TickFrequency = 10;
            this.spectrumScaleScrollBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.spectrumScaleScrollBar.Value = 15;
            // 
            // spectogramPictureBox
            // 
            this.spectogramPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.spectogramPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spectogramPictureBox.Location = new System.Drawing.Point(745, 202);
            this.spectogramPictureBox.Name = "spectogramPictureBox";
            this.spectogramPictureBox.Size = new System.Drawing.Size(423, 151);
            this.spectogramPictureBox.TabIndex = 22;
            this.spectogramPictureBox.TabStop = false;
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoRichTextBox.Location = new System.Drawing.Point(745, 13);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.ReadOnly = true;
            this.infoRichTextBox.Size = new System.Drawing.Size(423, 159);
            this.infoRichTextBox.TabIndex = 23;
            this.infoRichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.spectogramPictureBox);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.spectrumPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "SASA";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minOffsetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxOffsetTrackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spectrumPictureBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bufferLengthNumericUpDown)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logScaleScrollBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumScaleScrollBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectogramPictureBox)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox deviceSelectComboBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TrackBar minOffsetTrackBar;
		private System.Windows.Forms.TrackBar maxOffsetTrackBar;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ComboBox portSelectComboBox;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button openPortButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox FFTLenghtComboBox;
		private ProgressBars.Basic.BasicProgressBar spectrumBar1;
		private System.Windows.Forms.PictureBox spectrumPictureBox;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.NumericUpDown bufferLengthNumericUpDown;
        private ProgressBars.Basic.BasicProgressBar convertedPeakProgressBar;
        private ProgressBars.Basic.BasicProgressBar realPeakProgressBar;
        private System.Windows.Forms.GroupBox groupBox7;
        private ProgressBars.Basic.BasicProgressBar spectrumBar3;
        private System.Windows.Forms.TrackBar trackBar5;
        private ProgressBars.Basic.BasicProgressBar spectrumBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar6;
        private ProgressBars.Basic.BasicProgressBar convertedSpectrumProgressBar3;
        private ProgressBars.Basic.BasicProgressBar convertedSpectrumProgressBar2;
        private ProgressBars.Basic.BasicProgressBar convertedSpectrumProgressBar1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TrackBar logScaleScrollBar;
        private System.Windows.Forms.TrackBar spectrumScaleScrollBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox spectogramPictureBox;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.Button button1;
    }
}

