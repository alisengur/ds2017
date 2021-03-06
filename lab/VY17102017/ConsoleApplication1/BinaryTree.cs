﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BinaryTree<T> where T:IComparable
    {
        Node<T> root;

        public bool isEmpty()
        {
            return root == null;
        }

        public void add(T val)
        {
            if (isEmpty())
                root = new Node<T>(val);
            else
                addRecursive(root, val);
        }
        void addRecursive(Node<T> node, T val)
        {
            if (node.val.CompareTo(val) == 0)
                return;
            if (node.val.CompareTo(val) == -1)
                if (node.Right == null)
                {
                    Node<T> newNode = new Node<T>(val);
                    node.Right = newNode;
                    newNode.Parent = node;
                }
                else
                    addRecursive(node.Right, val);
            if (node.val.CompareTo(val) == 1)
                if (node.Left == null)
                {
                    Node<T> newNode = new Node<T>(val);
                    node.Left = newNode;
                    newNode.Parent = node;
                }
                else
                    addRecursive(node.Left, val);
        }

        Node<T> findNode(Node<T> node, T val)
        {
            if (node == null)
                return null;
            else if (node.val.CompareTo(val) == 0)
                return node;
            else if (node.val.CompareTo(val) == -1)
                return findNode(node.Right, val);
            else
                return findNode(node.Left, val);
        }



        public void delete(T val)
        {
            Node<T> node = findNode(root, val);
            if (node == null)
                return;
            else if (node.isLeaf())
            {
                if (node == root)
                    root = null;
                else if (node.Parent.Right == node)
                    node.Parent.Right = null;
                else
                    node.Parent.Left = null;
            }
            else if (node.hasOneChild())
            {
                if (node == root)
                {
                    if (node.Left != null)
                    {
                        root = node.Left;
                    }
                    else
                    {
                        root = node.Right;
                    }
                    root.Parent = null;
                }
                else if (node.Parent.Left == node)
                {
                    if (node.Left != null)
                    {
                        node.Parent.Left = node.Left;
                        node.Left.Parent = node.Parent;
                    }
                    else
                    {
                        node.Parent.Left = node.Right;
                        node.Right.Parent = node.Parent;
                    }
                }
                else
                {
                    if (node.Left != null)
                    {
                        node.Parent.Right = node.Left;
                        node.Left.Parent = node.Parent;
                    }
                    else
                    {
                        node.Parent.Right = node.Right;
                        node.Right.Parent = node.Parent;
                    }
                }
            }
            else if (node.hasTwoChild())
            {
                Node<T> successor = node.Right;
                while (successor.Left != null)
                    successor = successor.Left;

                delete(successor.val);

                successor.Right = node.Right;
                successor.Left = node.Left;
                if (node.Left != null)
                    node.Left.Parent = successor;
                if (node.Right != null)
                    node.Right.Parent = successor;
                successor.Parent = node.Parent;
                if (node == root)
                    root = successor;
                else if (node.Parent.Right == node)
                    node.Parent.Right = successor;
                else if(node.Parent.Left==node)
                    node.Parent.Left = successor;
            }
        }

        public void preOrder()
        {
            preOrderRecursive(root);
        }

        void preOrderRecursive(Node<T> node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.val);
            preOrderRecursive(node.Left);
            preOrderRecursive(node.Right);
        }

        public void inOrder()
        {
            inOrderRecursive(root);
        }

        void inOrderRecursive(Node<T> node)
        {
            if (node == null)
                return;
            inOrderRecursive(node.Left);
            Console.WriteLine(node.val);
            inOrderRecursive(node.Right);
        }

        public void postOrder()
        {
            postOrderRecursive(root);
        }

        void postOrderRecursive(Node<T> node)
        {
            if (node == null)
                return;
            postOrderRecursive(node.Left);
            postOrderRecursive(node.Right);
            Console.WriteLine(node.val);
        }
    }
}
