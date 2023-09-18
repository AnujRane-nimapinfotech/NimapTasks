    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class MethodOverloading
    {
        public void add()
        {
            Console.WriteLine("parameterless ADD function/method is called");
        }

        public void add(int a, int b)
        {
            int ans = a + b;
            Console.WriteLine("a + b = " + ans);
        }

        public void add(int a, int b, int c)
        {
            int ans = a + b + c;
            Console.WriteLine("a + b + c = " + ans);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            MethodOverloading obj = new MethodOverloading();
            obj.add();
            obj.add(1, 2);
            obj.add(5, 10, 20);
        }
    }
}
