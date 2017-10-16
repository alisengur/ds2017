using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Node<T> where T : IComparable
    {
        public T val;
        public Node<T> Right;
        public Node<T> Left;
        public Node<T> Parent;

        public Node(T val)
        {
            this.val = val;
        }


        public bool isLeaf()
        {
            return Left == null && Right == null;
        }

        public bool hasOneChild()
        {
            return Left == null ^ Right == null;
        }

        public bool hasTwoChild()
        {
            return Left != null && Right != null;
        }

    }
}
