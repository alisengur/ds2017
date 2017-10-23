using System;

namespace H6AVLTrees
{
	public class AVLNode<T> where T: IComparable
	{
		public T element;
		public AVLNode<T> left;
		public AVLNode<T> right;
		public int height;
		public AVLNode ()
		{}
		public AVLNode (T element)
		{
			this.element = element;
		}
		public AVLNode (T element, AVLNode<T> left, AVLNode<T> right)
		{
			this.element = element;
			this.left = left;
			this.right = right;
		}
	}
}

