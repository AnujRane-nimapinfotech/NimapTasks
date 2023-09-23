using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarVsObjectVsDynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nameVar = "Anuj";
            //nameVar = 5;      Will Show us error cause var was initialized as string

            object nameObject = "Anuj Object";
            string nameStringObject = (string) nameObject; //We have to cast to make it work

            dynamic nameDynamic = "Anuj Dynamic";
            string nameStringDynamic = nameDynamic;   //Here we can assign to other variable without casting
        }
    }
}
