using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HashTable
    {

        HashEntry[] array;
        int size;

        public HashTable(int capasity)
        {
            allocateArray(capasity);
        }

        bool isPrime(int number)
        {
            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    return false;

            return true;
        }


        int findNextPrime(int number)
        {
            for (; !isPrime(number); number++) ;

            return number;
        }

        bool isFull()
        {
            return size == array.Length;
        }

        void allocateArray(int capasity)
        {
            array = new HashEntry[findNextPrime(capasity)];
            size = 0;
        }

        int hash(int value)
        {
            return value % array.Length;
        }

        int findPos(int value)
        {
            int current = hash(value);
            int diff = 1;
            while (array[current] != null
                && array[current].isActive
                && array[current].value != value)
            {
                current = (current+diff)%array.Length;
                diff += 2;
            }

            return current;
        }

        public void insert(int value)
        {
            if (!contains(value))
            {
                array[findPos(value)] = new HashEntry(value);

                size++;

                if (size > array.Length / 2)
                    reHash();
            }
        }


        public bool contains(int value)
        {
            int current = findIndex(value);

            return array[current] != null;
        }

        public void display()
        {
            Console.WriteLine("####################");
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]!=null && array[i].isActive)
                    Console.WriteLine(i+" -> "+array[i].value);
            }
            Console.WriteLine("####################");
        }

        public void reHash()
        {
            HashEntry[] oldArray = array;

            allocateArray(array.Length * 2);

            for (int i = 0; i < oldArray.Length; i++)
                if (oldArray[i] != null && oldArray[i].isActive)
                    insert(oldArray[i].value);
        }

        int findIndex(int value)
        {
            int current = hash(value);
            int diff = 1;
            while (array[current] != null)
            {
                if (array[current].isActive && array[current].value == value)
                    break;
                current = (current + diff) % array.Length;
                diff += 2;
            }

            return current;
        }

        public void delete(int value)
        {
            if (contains(value))
            {
                array[findIndex(value)].isActive = false;
                size--;
            }
        }

    }
}
