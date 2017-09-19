using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY19092017
{
    class Operations<T> where T :IComparable
    {
        public T field;
        T privateField;

        public T[] array = new T[3];

        public void yazdir()
        {
            Console.WriteLine(field);
        }

        public string sentence()
        {
            return "this is " + field;
        }

        public T givePrivate()
        {
            return privateField;
        }

        public void displayArray()
        {
            //foreach (T item in array)
            //{
            //    Console.WriteLine(item);
            //}
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public T max()
        {
            T max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max.CompareTo( array[i])==-1)
                    max = array[i];
            }
            return max;
        }
    }
}
