using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap<int> heap = new Heap<int>();

            heap.insert(62);
            heap.insert(15);
            heap.insert(25);
            heap.insert(54);
            heap.insert(18);
            heap.insert(7);
            heap.insert(13);
            heap.insert(43);
            heap.insert(1);
            heap.insert(3);

            heap.display();

            heap.delete();

            heap.display();

            heap.delete();

            heap.display();
        }
    }
}
