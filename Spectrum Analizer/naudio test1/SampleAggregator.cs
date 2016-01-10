using NAudio.Dsp; 
using System;
using System.Diagnostics; 

public class SampleAggregator
{
	public event EventHandler<FftEventArgs> FftCalculated;
	public bool PerformFFT { get; set; }

	private Complex[] fftBuffer;
	private FftEventArgs fftArgs;
	private int fftPos;
	private int fftLength;
	private int m;

	public SampleAggregator(int fftLength)
	{
		if (!IsPowerOfTwo(fftLength))
		{
			throw new ArgumentException("Wielokrotność 2 !!!");
		}
		this.m = (int)Math.Log(fftLength, 2.0);
		this.fftLength = fftLength;
		this.fftBuffer = new Complex[fftLength];
		this.fftArgs = new FftEventArgs(fftBuffer);
	}

	bool IsPowerOfTwo(int x)
	{
		return (x & (x - 1)) == 0;
	}

	public void Add(float value)
	{
		if (PerformFFT && FftCalculated != null)
		{
			fftBuffer[fftPos].X = (float)(value * FastFourierTransform.HannWindow(fftPos, fftLength));
		
			fftBuffer[fftPos].Y = 0;
			fftPos++;
			if (fftPos >= fftLength)
			{
				fftPos = 0;
				FastFourierTransform.FFT(true, m, fftBuffer);
				FftCalculated(this, fftArgs);
			}
		}
	}
}

public class FftEventArgs : EventArgs
{
	[DebuggerStepThrough]
	public FftEventArgs(Complex[] result)
	{
		this.Result = result;
	}
	public Complex[] Result { get; private set; }
}