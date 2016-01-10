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
using System.Collections;
//using System.Numerics;

namespace naudio_test1
{
	public class AudioAnalizer
	{
		public event Action<double[]> SpectrumCalculated;

		public int[] FftLength = new int[] { 512, 1024, 2048, 4096, 8192 };
		public WasapiCapture Capture { get; private set; }
		public SampleAggregator SampleAggregator { get; private set; }
		public MMDevice audioDevice { get; set; }
        public int bufferLenght { get; set; }
        public float ScaleLogBase { get; set; }
        private Queue<double[]> dataBuffer = new Queue<double[]>();
		


		public MMDeviceCollection GetDevices(DataFlow dataFlow)
		{
			MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
			MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(dataFlow, DeviceState.Active);
			return devices;
		}
		
		public void Initalize(MMDevice audioDevice, int fftLength, int bufferLenght)
		{
            this.audioDevice = audioDevice;
			this.bufferLenght = bufferLenght;
			Capture = new WasapiLoopbackCapture(audioDevice);
			SampleAggregator = new SampleAggregator(fftLength);
			SampleAggregator.FftCalculated += new EventHandler<FftEventArgs>(FftCalculated);
			SampleAggregator.PerformFFT = true;
			//capture.ShareMode = AudioClientShareMode.Shared;
		}

		void FftCalculated(object sender, FftEventArgs fftEvent)
		{
			double[] spectrumData = CalculateSpectrum(fftEvent.Result);
			
			dataBuffer.Enqueue(spectrumData);	

			if (dataBuffer.Count<double[]>() >= bufferLenght)
			{
				double[] average = new double[spectrumData.Length];               
				for (int i = 0; i < spectrumData.Length; i++)
				{
					average[i] = dataBuffer.Sum<double[]>( (x) => x[i] ) / dataBuffer.Count<double[]>();
                    //if (average.Max((x) => Math.Abs(x)) > temp)
                    //{
                    //    temp = average.Max((x) => Math.Abs(x));
                    //}
                }
                while (dataBuffer.Count<double[]>() != bufferLenght) dataBuffer.Dequeue();
                

                //double[] spectrumBars = SpectrumBars(average);
				SpectrumCalculated.Invoke(average);	
			}			
		}

       

        private double[] CalculateSpectrum(Complex[] fftResult)
		{
			double[] data = new double[fftResult.Length];

			for (int i = 0; i < fftResult.Length / 2; i++)
			{
				double magnitude = Math.Sqrt(fftResult[i].X * fftResult[i].X + fftResult[i].Y * fftResult[i].Y);
				data[i] = magnitude; //Math.Log10(1f + Math.Abs(magnitude));
			}
			double total = data.Sum(x => Math.Abs(x));

			double max = data.Max(x => Math.Abs(x));

            //for (int i = 0; i < data.Length; i++)
           // {
              //  data[i] /= max;
               // data[i] *= (-(data[i] * data[i]))+1;
               // double a = data[i] * 2f / 3f + 0.1f;
               // data[i] *= -Math.Log10(a);
            //}

			return data;
		}
	}
}