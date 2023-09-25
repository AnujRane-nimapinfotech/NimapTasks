using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutAndRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int refOutSideNumber = 10;
            Console.WriteLine($"Before ref Conversion {refOutSideNumber}");
            SomeRefFunction(ref refOutSideNumber);
            Console.WriteLine($"After ref conversion {refOutSideNumber}");

            int outOutSizeNumber = 20;
            Console.WriteLine($"Before out conversion {outOutSizeNumber}");
            SomeOutFucntion(out outOutSizeNumber);
            Console.WriteLine($"Before ref conversion {outOutSizeNumber}");
        }

        static void SomeRefFunction(ref int insideNumber)
        {
            insideNumber += 10;
        }

        static void SomeOutFucntion(out int insideNumber)
        {
            insideNumber = 100;
        }
    }
}
