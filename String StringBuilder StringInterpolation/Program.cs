using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_StringBuilder_StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String A = "Hello";
            String B = "World";
            String C = "How are you";


            //String 

            Console.WriteLine("Using String");
            string usingString = A + " " + B + " " + C;
            Console.WriteLine(usingString);

            //StringBuilder
            Console.WriteLine(" \nUsing String Builder");
            var usingStringBuilder = new StringBuilder();
            usingStringBuilder.Append(A);
            usingStringBuilder.Append(" ");
            usingStringBuilder.Append(B);
            usingStringBuilder.Append(" ");
            usingStringBuilder.Append(C);
            usingStringBuilder.Append(" ");

            Console.WriteLine(usingStringBuilder);


            //String Interpolation
            Console.WriteLine("\nUsing String Interpolation");
            Console.WriteLine("{0} {1} {2}", A, B, C);
            Console.WriteLine($"{A} {B} {C}");     //using dollar sign
        }
    }
}
