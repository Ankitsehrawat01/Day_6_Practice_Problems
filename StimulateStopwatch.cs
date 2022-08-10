using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Day_6_Practice_Problems
{
	public class StimulateStopwatch
	{
		public void StopWatch()
		{
			//stopwatch  creation
			Stopwatch stopwatch = new Stopwatch();

			//Start timing 
			stopwatch.Start();
			for (int i = 0; i < 100; i++)
			{
				Thread.Sleep(1);
			}

			// Stop timing
			stopwatch.Stop();

			// Write result
			Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
		}
	}
}
