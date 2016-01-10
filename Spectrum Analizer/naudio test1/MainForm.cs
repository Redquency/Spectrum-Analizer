using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using NAudio;
using NAudio.Dsp;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using System.Runtime.InteropServices;
using System.Numerics;
using System.Diagnostics;

namespace naudio_test1
{
	public partial class MainForm : Form
	{
		private SerialPort serialPort;
		private AudioAnalizer audioAnalizer;
        private double[] spectrumData;
        private ColorDialog colorPicker;
        private bool started = false;
        private PerformanceCounter counter;

        public MainForm()
		{
			InitializeComponent();

            counter = new PerformanceCounter();
            

			audioAnalizer = new AudioAnalizer();
			

			foreach (MMDevice device in audioAnalizer.GetDevices(DataFlow.All))
			{
				deviceSelectComboBox.Items.Add(device);
			}
			
			foreach (int fftValue in audioAnalizer.FftLength)
			{
				FFTLenghtComboBox.Items.Add(fftValue);
			}

			portSelectComboBox.Items.AddRange(SerialPort.GetPortNames());

            FFTLenghtComboBox.SelectedItem = audioAnalizer.FftLength[1];
            bufferLengthNumericUpDown.Value = 7;

			Timer timer = new Timer();
			timer.Interval = 50;
			timer.Enabled = false;
			timer.Tick += timer_Tick;


            colorPicker = new ColorDialog();
			
			convertedPeakProgressBar.ForeColor = Color.Green;

            

			deviceSelectComboBox.SelectedValueChanged += DeviceSelectComboBox_SelectedValueChanged;
			this.FormClosed += MainForm_FormClosed;
            this.SizeChanged += MainForm_SizeChanged;
            spectrumPictureBox.Paint += SpectrumPictureBox_Paint;

		}

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            spectrumPictureBox.Width = this.Width - spectrumPictureBox.Left - 30;
            spectrumPictureBox.Height = this.Height - spectrumPictureBox.Top -55;
        }

    

        private void SpectrumPictureBox_Paint(object sender, PaintEventArgs e)
        {
            
            if (spectrumData != null)
            {
                // e.Graphics.TranslateTransform(,,)\
               // e.Graphics.RenderingOrigin = new Point(trackBar6.Value,0);
                //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                int barSize = 10;
                double singleBar;
                Rectangle[] barsTop = new Rectangle[spectrumData.Length];
                Rectangle[] spectrumBars = new Rectangle[spectrumData.Length];
                Rectangle[] scale = new Rectangle[spectrumData.Length];

                for (int i = 0; i < spectrumData.Length; i++)
                {
                    singleBar = spectrumData[i] * (float)spectrumScaleScrollBar.Value;
                    if (singleBar > 1) singleBar = 1;
                    spectrumBars[i] = new Rectangle(new Point(i * (barSize + 1), e.ClipRectangle.Height - (int)(singleBar * (float)e.ClipRectangle.Height)), new Size(barSize, (int)(spectrumData[i] * (float)e.ClipRectangle.Height * (float)spectrumScaleScrollBar.Value)));
                    barsTop[i] = new Rectangle(i * (barSize + 1), (int)(e.ClipRectangle.Height - singleBar * e.ClipRectangle.Height), barSize, 3);

                    double logScale = Math.Log(i + 2, logScaleScrollBar.Value);
                    scale[i] = new Rectangle(new Point(i * (barSize + 1), e.ClipRectangle.Height - (int)(logScale * (float)e.ClipRectangle.Height)), new Size(barSize, 2));

                    var color = (int)(255f * singleBar);
                    if (color > 255 || color < 0 ) color = 255;
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255-color, color, 0)), spectrumBars[i]);
                }
                //e.Graphics.FillRectangles(Brushes.Red, spectrumBars);
                e.Graphics.FillRectangles(Brushes.Blue, barsTop);
                e.Graphics.FillRectangles(Brushes.Green, scale);
            }
        }

        void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (serialPort != null)
			{
				if (serialPort.IsOpen) serialPort.Close();
			}

			if (audioAnalizer.Capture != null) audioAnalizer.Capture.StopRecording();
		}

		void DeviceSelectComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
					
		}

		private void audioAnalizer_SpectrumCalculated(double[] calculatedData)
		{
            this.spectrumData = calculatedData;
            for (int i = 0; i < spectrumData.Length; i++)
            {
                spectrumData[i] *= Math.Log(i + 2, logScaleScrollBar.Value);
            }
            double[] bars = SpectrumBars(spectrumData);
            //var device = audioAnalizer.audioDevice;

            //infoRichTextBox.Text = device.Properties + "\n" + device.State + "\n" + device.AudioEndpointVolume.Channels.Count + "\n" + device.AudioClient.StreamLatency + "\n" + device.AudioMeterInformation.PeakValues.Count + "\n";


            if (bars[0] > 1) spectrumBar1.Value = spectrumBar1.Maximum;
            else spectrumBar1.Value = (int)(bars[0] * spectrumBar1.Maximum);

            if (bars[1] > 1) spectrumBar2.Value =  spectrumBar2.Maximum;
            else spectrumBar2.Value = (int)(bars[1] * spectrumBar2.Maximum);

            if (bars[2] > 1) spectrumBar3.Value = spectrumBar3.Maximum;
            else spectrumBar3.Value = (int)(bars[2] * spectrumBar3.Maximum);


            if (deviceSelectComboBox.SelectedItem != null && audioAnalizer.audioDevice != null /*&& !openPortButton.Enabled*/)
            {
                realPeakProgressBar.Value = (int)(realPeakProgressBar.Maximum * audioAnalizer.audioDevice.AudioMeterInformation.MasterPeakValue);

                if (ConvertPeak(audioAnalizer.audioDevice.AudioMeterInformation.MasterPeakValue) >= 0 && ConvertPeak(audioAnalizer.audioDevice.AudioMeterInformation.MasterPeakValue) <= 1)
                {
                    convertedPeakProgressBar.Value = (int)(realPeakProgressBar.Maximum * ConvertPeak(audioAnalizer.audioDevice.AudioMeterInformation.MasterPeakValue));
                }
                //serialPort.Write(new byte[] { (byte)(255f - ConvertPeak(audioAnalizer.audioDevice.AudioMeterInformation.MasterPeakValue) * -255f) }, 0, 1);
            }

            spectrumPictureBox.Invalidate();		
		}


		private void capture_DataAvailable(object sender, WaveInEventArgs audioEvent)
		{
			if (this.InvokeRequired)
			{
				this.BeginInvoke(new EventHandler<WaveInEventArgs>(capture_DataAvailable), sender, audioEvent);
			}
			else
			{
				byte[] buffer = audioEvent.Buffer;
				int bytesRecorded = audioEvent.BytesRecorded;
				int bufferIncrement = audioAnalizer.Capture.WaveFormat.BlockAlign;

				for (int index = 0; index < bytesRecorded; index += bufferIncrement)
				{
					float sample32 = BitConverter.ToSingle(buffer, index);
					audioAnalizer.SampleAggregator.Add(sample32);
				}
			}
		}

        private double[] SpectrumBars(double[] data)
        {
            float binRange = 43.06f;
            int spectPart = data.Length / 80;
            int counter = 0;
            double peak1 = 0, peak2 = 0, peak3 = 0;

            for (int i = 0; i < spectPart; i++)
            {
                peak1 += Math.Abs(data[i]);
                counter = i;
            }
            peak1 /= counter;
            for (int i = spectPart; i < spectPart + (int)((double)data.Length / 5.34f); i++)
            {
                peak2 += Math.Abs(data[i]);
                counter = i;
            }
            peak2 /= counter;

            for (int i = spectPart + (int)((double)data.Length / 5.34f); i < data.Length; i++)
            {
                peak3 += Math.Abs(data[i]);
                counter = i;
            }
            peak3 /= counter;

            peak1 *= spectrumScaleScrollBar.Value * trackBar1.Value / 60;
            peak2 *= spectrumScaleScrollBar.Value * trackBar3.Value / 30;
            peak3 *= spectrumScaleScrollBar.Value * trackBar5.Value;

            //var max = Math.Max(Math.Max(peak1, peak2), peak3);
            //peak1 /= max;
            //peak2 /= max;
            //peak3 /= max;
            //peak1 /= 5;
            //peak2 /= 20;
            //peak3 /= 30;
            return new double[] { peak1, peak2, peak3 };
        }
        void timer_Tick(object sender, EventArgs e)
		{

			
		}



		private void openPortButton_Click(object sender, EventArgs e)
		{

			if (portSelectComboBox.SelectedItem != null)
			{
				serialPort = new SerialPort((string)portSelectComboBox.SelectedItem, 9600);
				serialPort.Open();
				openPortButton.Enabled = false;
			}

		}
		private float ConvertPeak(float inputPeak)
		{
			float outputPeak = 0f;
			outputPeak = (inputPeak - minOffsetTrackBar.Value / (float)minOffsetTrackBar.Maximum) * (1 / (maxOffsetTrackBar.Value / (float)maxOffsetTrackBar.Maximum - minOffsetTrackBar.Value / (float)minOffsetTrackBar.Maximum));
			if (outputPeak < 0f) return 0f;
			if (outputPeak > 1f) return 1f;
			else return outputPeak; ;
		}

		private void bufferLengthNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			audioAnalizer.bufferLenght = (int)bufferLengthNumericUpDown.Value;
		}

        private void startButton_Click(object sender, EventArgs e)
        {
            started = !started;

            if (started)
            {
                MMDevice audioDevice = (MMDevice)deviceSelectComboBox.SelectedItem;
                int fftLength = (int)FFTLenghtComboBox.SelectedItem;
                int bufferLength = (int)bufferLengthNumericUpDown.Value;
                audioAnalizer.Initalize(audioDevice, fftLength, bufferLength);
                audioAnalizer.Capture.DataAvailable += capture_DataAvailable;
                audioAnalizer.Capture.StartRecording();
                audioAnalizer.SpectrumCalculated += audioAnalizer_SpectrumCalculated;
                startButton.Text = "STOP";
            }
            else
            {
                // audioAnalizer.Capture.DataAvailable -= capture_DataAvailable;
                audioAnalizer.SampleAggregator.PerformFFT = false;

                audioAnalizer.Capture.StopRecording();
              //  audioAnalizer.SpectrumCalculated -= audioAnalizer_SpectrumCalculated;
                startButton.Text = "START";
            }

            // var color = colorPicker.ShowDialog();
            // this.BackColor = colorPicker.Color;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter.BeginInit();
        }
    }
}
