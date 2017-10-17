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
            //BinaryTree<int> bt = new BinaryTree<int>();
            //bt.add(5);
            //bt.add(3);
            //bt.add(8);
            //bt.add(1);
            //bt.add(4);
            //bt.add(7);
            //bt.add(10);

            ////bt.delete(1);
            ////bt.delete(3);
            ////bt.delete(8);
            ////bt.delete(5);

            //bt.postOrder();

            PostTree pt = new PostTree("35+47**5/147-+*");

            pt.postOrder();
        }
    }
}
