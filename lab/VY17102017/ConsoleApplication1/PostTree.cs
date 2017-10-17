using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PostTree
    {
        Node<char> root;
        Stack<char> stk;

        public PostTree(string postfix)
        {
            stk = new Stack<char>();
            for (int i = 0; i < postfix.Length; i++)
            {
                stk.Push(postfix[i]);
            }
            root = new Node<char>(stk.Pop());
            add(root);
        }

        void add(Node<char> node)
        {
            node.Right = new Node<char>(stk.Pop());
            if (isOperator(node.Right.val))
                add(node.Right);
            node.Left = new Node<char>(stk.Pop());
            if (isOperator(node.Left.val))
                add(node.Left);
        }

        bool isOperator(char val)
        {
            return val == '+' || val == '-' || val == '*' || val == '/';
        }

        public void postOrder()
        {
            postOrderRecursive(root);
        }

        void postOrderRecursive(Node<char> node)
        {
            if (node == null)
                return;
            postOrderRecursive(node.Left);
            postOrderRecursive(node.Right);
            Console.WriteLine(node.val);
        }
    }
}
