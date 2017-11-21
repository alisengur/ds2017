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
            HashTable ht = new HashTable(10);
            
            ht.insert(20);
            ht.insert(9);
            ht.insert(31);
            ht.insert(42);
            ht.insert(53);
            ht.insert(64);

            ht.delete(31);

            ht.display();
        }
    }
}
