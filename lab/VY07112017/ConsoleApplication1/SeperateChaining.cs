using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SeperateChaining
    {
        LinkedList<int>[] array = new LinkedList<int>[10];

        public SeperateChaining()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new LinkedList<int>();
            }
        }

        int Hash(int x)
        {
            return x % 10;
        }

        public void add(int val)
        {
            array[Hash(val)].AddFirst(val);
        }

        public void delete(int val)
        {
            array[Hash(val)].Remove(val);
        }

        public void display()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("("+i+")");
                LinkedListNode<int> iterator = array[i].First;
                while (iterator != null)
                {
                    Console.Write("->"+iterator.Value);
                    iterator = iterator.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
