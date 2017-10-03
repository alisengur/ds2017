using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY03102017
{
    class Program
    {
        static void Main(string[] args)
        {

            DLinkedList<int> DList = new DLinkedList<int>();
            DList.addToEnd(5);
            //DList.addToEnd(3);
            //DList.addToFront(4);
            //DList.addToEnd(1);
            DList.addAfterHead(8);
            //DList.addToEnd(7);
            //DList.addToFront(2);

            DList.display();

        }
    }
}
