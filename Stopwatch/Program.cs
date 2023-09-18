using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    public class Stopwatch
    {
        System.Diagnostics.Stopwatch stopwatchClass = new System.Diagnostics.Stopwatch();
        public void start()
        {
            Console.WriteLine("Press Enter to start the watch");
            //Console.ReadKey();
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
            }
            stopwatchClass.Start();
        }

        public TimeSpan stop()
        {
            Console.WriteLine("Press Enter to stop the watch");
            //Console.ReadKey();
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
            }
            stopwatchClass.Stop();
            var tm = stopwatchClass.Elapsed;
            return tm;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                stopwatch.start();
                Console.WriteLine(stopwatch.stop().ToString("mm\\:ss\\:ff"));
            }
        }
    }
}
