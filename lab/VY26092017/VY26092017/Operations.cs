using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY26092017
{
    class Operations
    {

        public Stack<int> Reverse(Stack<int> stk)
        {
            Stack<int> stkReverse = new Stack<int>();
            Stack<int> stkTemp = new Stack<int>();
            while (stk.Count != 0)
            {
                int temp = stk.Pop();
                stkReverse.Push(temp);
                stkTemp.Push(temp);
            }

            while (stkTemp.Count != 0)
                stk.Push(stkTemp.Pop());

            return stkReverse;

        }

        public void display(Stack<int> stk)
        {
            Console.WriteLine("----------------");
            int[] array= stk.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("----------------");
        }


        public int priority(char val)
        {
            if (val == '*')
                return 10;
            else if (val == '/')
                return 10;
            else if (val == '+')
                return 5;
            else if (val == '-')
                return 5;

            return 0;
        }

        public string convertToPostfix(string infix)
        {
            string postfix = "";
            Stack<char> stk = new Stack<char>();
            for (int i = 0; i < infix.Length; i++)
            {
                if (infix[i] == '(')
                    stk.Push(infix[i]);
                else if (infix[i] == ')')
                {
                    while (stk.Peek() != '(')
                        postfix += stk.Pop();

                    stk.Pop();
                }
                else if (priority(infix[i]) == 0)
                    postfix += infix[i];
                else if (priority(infix[i]) != 0)
                {
                    while (stk.Count != 0
                        && priority(stk.Peek()) >= priority(infix[i])
                        && stk.Peek()!='(')
                        postfix += stk.Pop();

                    stk.Push(infix[i]);
                }
                
            }

            while (stk.Count != 0)
                postfix += stk.Pop();

            return postfix;
        }


        public double solve(string postfix)
        {
            Stack<double> stk = new Stack<double>();

            for (int i = 0; i < postfix.Length; i++)
            {
                if (priority(postfix[i]) == 0)
                    stk.Push(double.Parse(postfix[i].ToString()));
                else
                {
                    double num1 = stk.Pop();
                    double num2 = stk.Pop();
                    if (postfix[i] == '*')
                        stk.Push(num2 * num1);
                    else if (postfix[i] == '/')
                        stk.Push(num2 / num1);
                    else if (postfix[i] == '+')
                        stk.Push(num2 + num1);
                    else if (postfix[i] == '-')
                        stk.Push(num2 - num1);
                }
            }
            
            return stk.Pop();
        }

    }
}
