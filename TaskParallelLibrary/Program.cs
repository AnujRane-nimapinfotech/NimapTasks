using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread thread = new Thread(RunMillionIterations);  // This will only utilize one processor
            //thread.Start(); 
            Parallel.For(0, 1000000, x => RunMillionIterations()); // This will utilize all processors
        }

        private static void RunMillionIterations()
        {
            string x = "";
            for(int i = 0; i < 1000000; i++)
            {
                x = x + "s";
            }
        }
    }
}
