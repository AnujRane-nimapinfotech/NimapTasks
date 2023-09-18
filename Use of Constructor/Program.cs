using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_of_Constructor
{
    public class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Parameter less constructor called...");
        }

        public Vehicle(string name)
        {
            Console.WriteLine("Parameterized constructor called... " + name);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();
            Vehicle v2 = new Vehicle("Hello World!");
        }
    }
}
