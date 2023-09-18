using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitve_vs_NonPrimitive_Types
{
    //classes are also non primitive data types 
    class NonPrimitiveDataTypes
    {
        int number;
        string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primitive Data Types
            int intNumber = 1;
            byte byteNumber = 25;
            char alphabet = 'A';
            float floatNumber = 22.5f;
            long longNumber = 100000;


            //Non Primitive Data Types 
            int[] arrays = { 1, 2, 3, 4, 5, 6, 7 };
            string[] stringArray = { "anuj", "abhiraj", "swapnil" };
            string name = "Anuj Rane";
            string upper = name.ToUpper();
            Console.WriteLine(upper);

            foreach (int number in arrays)
            {
                Console.WriteLine(number);
            }

            foreach (string word in stringArray)
            {
                Console.WriteLine(word);
            }
        }
    }
}
