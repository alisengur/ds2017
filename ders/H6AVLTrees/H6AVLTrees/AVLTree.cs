using System;

namespace H6AVLTrees
{
	public class AVLTree<T> where T:IComparable
	{
		AVLNode<T> root;
		public AVLTree ()
		{
		}
		private int height(AVLNode<T> node)
		{
			return node == null ? -1 : node.height;//Bu değer 0 olunca kod hatalı çalışıyor
		}
		public bool isEmpty(AVLNode<T> node)
		{
			return node == null;
		}
		public T findMin()
		{
			if (isEmpty(root)) {
				throw new Exception ("AVL ağacı boş");
			}
			return findMin (root).element;
		}
		private AVLNode<T> findMin(AVLNode<T> node)
		{
			while (node.left!=null) {
				node = node.left;
			}
			return node;
		}
		public T findMax()
		{
			if (isEmpty(root)) {
				throw new Exception ("AVL ağacı boş");
			}
			return findMax (root).element;
		}
		private AVLNode<T> findMax(AVLNode<T> node)
		{
			while (node.right!=null) {
				node = node.right;
			}
			return node;
		}
		AVLNode<T> rotateLeft(AVLNode<T> k1)
		{
			AVLNode<T> k2 = k1.right;
			k1.right = k2.left;
			k2.left = k1;
			k1.height = Math.Max (height (k1.left), height (k1.right))+1;
			k2.height = Math.Max (k1.height, height (k2.right)) + 1;
			return k2;
		}
		AVLNode<T> rotateRight(AVLNode<T> k2)
		{
			AVLNode<T> k1 = k2.left;
			k2.left = k1.right;
			k1.right = k2;
			k2.height = Math.Max (height (k2.left), height (k2.right)) + 1;
			k1.height = Math.Max (k2.height, height (k1.left)) + 1;
			return k1;
		}
		AVLNode<T> rotateRightLeft(AVLNode<T> k1)
		{
			k1.right = rotateRight (k1.right);
			return rotateLeft (k1);
		}
		AVLNode<T> rotateLeftRight(AVLNode<T> k3)
		{
			k3.left = rotateLeft (k3.left);
			return rotateRight (k3);
		}
		public void insert(T element)
		{
			root = insert (root, element);
		}
		private AVLNode<T> insert(AVLNode<T> node, T element)
		{
			if (node == null)
				return new AVLNode<T> (element);
			int compareResult = node.element.CompareTo (element);
			if (compareResult < 0)
				node.right = insert (node.right, element);
			else if (compareResult > 0)
				node.left = insert (node.left, element);
			return balance (node);
		}
		private AVLNode<T> balance(AVLNode<T> node)
		{
			if (node == null)
				return node;
			int balanceFactor = height (node.right) - height (node.left);
			if (balanceFactor>1) {
				if (height (node.right.right) >= height (node.right.left))
					node = rotateLeft (node);
				else
					node = rotateRightLeft (node);
			}
			else if (balanceFactor<-1) {
				if (height (node.left.left) >= height (node.left.right))
					node = rotateRight (node);
				else
					node = rotateLeftRight (node);
			}
			node.height = Math.Max (height (node.left), height (node.right)) + 1;
			return node;
		}
		public void print()
		{
			print (root, height (root));
		}
		void print(AVLNode<T> node, int max)
		{
			if (node == null)
				return;
			int girinti=max-height(node);
			for (int i = 0; i < girinti; i++) {
				Console.Write ("|  ");
			}
			Console.WriteLine (node.element);
			print (node.left, max);
			print (node.right, max);
		}
		public void remove(T value)
		{
			root = remove (root, value);
		}
		AVLNode<T> remove(AVLNode<T> node, T value)
		{
			if (node == null)
				return node;
			int compareResult = value.CompareTo (node.element);
			if (compareResult < 0)
				node.left = remove (node.left, value);
			else if (compareResult > 0)
				node.right = remove (node.right, value);
			else if (node.left != null && node.right != null) {//iki çocuk
				node.element = findMin (node.right).element;
				node.right = remove (node.right, node.element);
			} else
				node = node.left != null ? node.left : node.right;
			return balance (node);
		}

	}
}

