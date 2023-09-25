using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> years = new List<int>();   
            years.Add(1990);
            years.Add(1991);
            years.Add(1992);
            years.Add(1993);
            years.Add(2001);
            years.Add(2002);
            years.Add(2003);

            IEnumerable<int> ienumrable = (IEnumerable<int>)years;
            //Iterations done in IEnumerable
            //foreach (int year in ienumrable)
            //{
            //    Console.WriteLine(year);
            //}
            EnumerableIterate1990To2000(ienumrable);

            Console.WriteLine("-----------------");

            IEnumerator<int> ienumerator = years.GetEnumerator();
            //Iterations done in IEnumerator
            //while (ienumerator.MoveNext()) 
            //{
            //    Console.WriteLine(ienumerator.Current.ToString());
            //}
            EnumeratorIterate1990To2000(ienumerator);

        }

        static void EnumeratorIterate1990To2000(IEnumerator<int> date)    
        {
            while (date.MoveNext())
            {
                //Console.WriteLine(date.Current.ToString());
                if(Convert.ToInt32(date.Current) > 1999)
                {
                    EnumeratorIterate2001AndAbove(date);
                }
            }
        }

        static void EnumeratorIterate2001AndAbove(IEnumerator<int> date)
        {
            while (date.MoveNext())
            {
                Console.WriteLine(date.Current.ToString());
            }
        }

        static void EnumerableIterate1990To2000(IEnumerable<int> date)
        {
            foreach(var i in date)
            {
                if(i > 2000)
                {
                    EnumerableIterate2001AndAbove(date);
                }
            }
        }

        static void EnumerableIterate2001AndAbove(IEnumerable<int> date)
        {
            foreach( var i in date)
            {
                Console.WriteLine(i);
            }
        }

    }
}
