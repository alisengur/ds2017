using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY24102017
{
    class Node:IComparable
    {
        public string chars;
        public int frequency;
        public Node Left;
        public Node Right;

        public Node(string chars, int frequency)
        {
            this.chars = chars;
            this.frequency = frequency;
        }

        public int CompareTo(object obj)
        {
            if (frequency < ((Node)obj).frequency)
                return -1;
            else if (frequency == ((Node)obj).frequency)
                return 0;
            else
                return 1;
        }
    }
}
