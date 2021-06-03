using System;
using System.Diagnostics;

namespace FrendlyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Frendly.GetFrendlies(Convert.ToInt32(Console.ReadLine()));
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("RunTime " + elapsedTime);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            
        }
    }
}
