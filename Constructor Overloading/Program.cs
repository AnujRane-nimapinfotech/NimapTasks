using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    public class ConstructorOverloading
    {
        int number;
        string name;

        public ConstructorOverloading()
        {
            Console.WriteLine("This is a parameter less Constructor ");
        }

        public ConstructorOverloading(int number)
        {
            this.number = number;
        }

        public ConstructorOverloading(string name)
        {
            this.name = name;
        }

        public void printName()
        {
            Console.WriteLine("Name: " + name);
        }

        public void printNumber()
        {
            Console.WriteLine("Roll No: " + number);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructorOverloading ParameterlessConstructor = new ConstructorOverloading();
            ConstructorOverloading number = new ConstructorOverloading(33);
            ConstructorOverloading name = new ConstructorOverloading("Anuj");

            number.printNumber();
            name.printName();
        }
    }
}
