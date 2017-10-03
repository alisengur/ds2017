using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY03102017
{
    class Node<T>
    {
        public T val;
        public Node<T> next;
        public Node<T> prev;

        public Node(T val)
        {
            this.val = val;
        }


    }
}
