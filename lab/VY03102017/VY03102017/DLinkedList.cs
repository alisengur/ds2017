using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY03102017
{
    class DLinkedList<T>
    {
        Node<T> head;


        public void addToFront(T val)
        {
            Node<T> newNode = new Node<T>(val);

            if (isEmpty())
                head = newNode;
            else
            {
                head.prev = newNode;
                newNode.next = head;
                head = newNode;
            }

        }

        public bool isEmpty()
        {
            if (head == null)
                return true;

            return false;
        }

        public void addToEnd(T val)
        {
            Node<T> newNode = new Node<T>(val);
            if (isEmpty())
                head = newNode;
            else
            {
                Node<T> iterator = head;
                while (iterator.next != null)
                    iterator = iterator.next;
                iterator.next = newNode;
                newNode.prev = iterator;
            }
        }

        public void display()
        {
            Console.WriteLine("-------------------");
            Node<T> iterator = head;
            while (iterator != null)
            {
                Console.Write(iterator.val+" - ");
                iterator = iterator.next;
            }
            Console.WriteLine();
            Console.WriteLine("-------------------");
        }

        public void addAfterHead(T val)
        {
            Node<T> newNode = new Node<T>(val);
            if (isEmpty())
                head = newNode;
            else
            {
                newNode.next = head.next;
                head.next = newNode;
                newNode.prev = head;
                if(newNode.next!=null)
                    newNode.next.prev = newNode;
            }
        }

        public void removeFromFront()
        {
            if (!isEmpty())
            {
                if (head.next == null)
                    head = null;
                else
                {
                    head = head.next;
                    head.prev = null;
                }
            }
        }

        public void removeFromEnd()
        {
            if (!isEmpty())
            {
                if (head.next == null)
                    head = null;
                else
                {
                    Node<T> iterator = head;
                    while (iterator.next != null)
                        iterator = iterator.next;
                    iterator.prev.next = null;
                }
            }
            

        }

    }
}
