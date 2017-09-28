using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY26092017
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations obj = new Operations();

            //Stack<int> stk = new Stack<int>();
            //stk.Push(5);
            //stk.Push(3);
            //stk.Push(8);
            //stk.Push(6);


            //obj.display(stk);
            //obj.display(obj.Reverse(stk));
            //obj.display(stk);


            string infix = "(1+2)*3+(5+4)";
            //Console.WriteLine(infix);
            //Console.WriteLine(obj.convertToPostfix(infix));

            Console.WriteLine(obj.solve(obj.convertToPostfix(infix)));





        }
    }
}
