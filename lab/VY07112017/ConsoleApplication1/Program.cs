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
            SeperateChaining sc = new SeperateChaining();

            sc.add(13);
            sc.add(65);
            sc.add(54);
            sc.add(1);
            sc.add(6);
            sc.add(42);
            sc.add(18);
            sc.add(63);
            sc.add(7);
            sc.add(2);
            sc.add(43);
            sc.add(35);
            sc.add(25);
            sc.add(5);
            sc.add(16);

            sc.display();
        }
    }
}
