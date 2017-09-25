using System;

namespace H2mystack
{
	public class MyStack<T>
	{
		int top=-1;
		T [] dizi;
		public MyStack ()
		{
			dizi = new T[20];
		}
		public MyStack(int boyut)
		{
			dizi = new T[boyut];
		}
		public bool isEmpty()
		{
			return top == -1;
		}
		public bool isFull()
		{
			return top == dizi.Length - 1;
		}
		public void push(T item)
		{
			if (isFull ())
				throw new Exception ("Stack overflow!");
			dizi [++top] = item;
		}
		public T pop()
		{
			if (isEmpty ())
				throw new Exception ("Stack underflow!");
			return dizi [top--];
		}
		public int Count {
			get { return top + 1;}
		}
		public void print()
		{
			for (int i = top; i >= 0; i--) {
				Console.WriteLine (dizi[i]);
			}
		}
		public T peek()
		{
			if (isEmpty ())
				throw new Exception ("Stack underflow!");
			return dizi [top];
		}
	}
}

