using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal Makes sound");
        }
    }

    public class Dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Dog Barks");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.sound();
        }
    }
}
