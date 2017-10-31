using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Heap<T> where T :IComparable
    {
        List<T> _list;

        public Heap()
        {
            _list = new List<T>();
        }

        public void insert(T val)
        {
            _list.Add(val);

            int i = _list.Count - 1;
            int parent = (i - 1) / 2;

            while (i!=0 && _list[parent].CompareTo(_list[i]) == 1)
            {
                T tmp = _list[parent];
                _list[parent] = _list[i];
                _list[i] = tmp;

                i = parent;
                parent = (i - 1) / 2;
            }
        }


        public T delete()
        {
            int i = 0;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            T rt = _list[i];
            _list[i] = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);

            while ((left <= _list.Count - 1 && _list[left].CompareTo(_list[i]) == -1)
                || (right <= _list.Count - 1 && _list[right].CompareTo(_list[i]) == -1))
            {
                int min = left;
                if (right <= _list.Count - 1)
                    min = _list[left].CompareTo(_list[right]) == -1 ? left : right;

                T tmp = _list[i];
                _list[i] = _list[min];
                _list[min] = tmp;

                i = min;
                left = 2 * i + 1;
                right = 2 * i + 2;

            }


            return rt;
        }

        public void display()
        {
            Console.WriteLine("-----------------------");
            foreach (T item in _list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
