using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY24102017
{
    class Huffman
    {
        Node root;

        public Huffman(string val)
        {
            List<Node> priorityList = new List<Node>();
            for (int i = 0; i < val.Length; i++)
            {
                bool exist = false;
                for (int j = 0; j < priorityList.Count; j++)
                {
                    if (val[i].ToString()==priorityList[j].chars)
                    {
                        priorityList[j].frequency++;
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    priorityList.Add(new Node(val[i].ToString(), 1));
                }
            }
            priorityList.Sort();
            //for (int i = 0; i < priorityList.Count; i++)
            //{
            //    Console.WriteLine(priorityList[i].chars + "\t" + priorityList[i].frequency);
            //}

            while (priorityList.Count != 1)
            {
                Node left = priorityList[0];
                Node right = priorityList[1];

                priorityList.Remove(left);
                priorityList.Remove(right);

                Node parent = new Node(left.chars + right.chars, left.frequency + right.frequency);
                parent.Left = left;
                parent.Right = right;

                priorityList.Add(parent);
                priorityList.Sort();
            }
            root = priorityList[0];
        }

        public bool[] encode(string val)
        {
            List<bool> code = new List<bool>();
            for (int i = 0; i < val.Length; i++)
            {
                Node iterator = root;
                while (iterator.chars != val[i].ToString())
                {
                    if (iterator.Left.chars.Contains(val[i]))
                    {
                        code.Add(false);
                        iterator = iterator.Left;
                    }
                    else
                    {
                        code.Add(true);
                        iterator = iterator.Right;
                    }
                }

            }
            return code.ToArray();
        }

        public string decode(bool[] code)
        {
            string val = "";
            Node iterator = root;
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i])
                    iterator = iterator.Right;
                else
                    iterator = iterator.Left;

                if (iterator.chars.Length == 1)
                {
                    val += iterator.chars;
                    iterator = root;
                }
            }
            return val;
        }
    }
}
