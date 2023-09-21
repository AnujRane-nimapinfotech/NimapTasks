using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private List<Object> _List = new List<Object>();

        public void Push(Object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("You cannot add null values to the list"); 
            }

            _List.Add(obj);
            
        }

        public Object Pop()
        {

            Object toReturn; 

            if (_List.Count == 0)
            {
                throw new InvalidOperationException("The list is already empty");
            }
            if(_List.Count == 1)
            {
                toReturn = _List[0];
                _List.RemoveAt(0);
            }
            else
            {
                 toReturn = _List[_List.Count - 1];
                _List.RemoveAt(_List.Count - 1);
            }
            return toReturn;
        }

        public void Print()
        {
            foreach (var item in _List)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            for(int i = 0; i < 6; i++)
            {
                stack.Push(i);
            }

            stack.Print();

            for(int i = 0;i < 6; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
