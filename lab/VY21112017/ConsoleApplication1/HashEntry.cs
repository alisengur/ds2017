using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HashEntry
    {
        public int value;
        public bool isActive;

        public HashEntry(int val)
        {
            value = val;
            isActive = true;
        }
    }
}
