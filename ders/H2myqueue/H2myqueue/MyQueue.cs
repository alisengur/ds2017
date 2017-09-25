using System;

namespace H2myqueue
{
	public class MyQueue<T>
	{
		int front=-1;
		int rear=-1;
		T[] dizi;
		public MyQueue ()
		{
			dizi = new T[20];
		}
		public MyQueue(int boyut)
		{
			dizi = new T[boyut];
		}
		public bool isEmpty()
		{
			return front == -1 && rear == -1;
		}
		public bool isFull()
		{
			return rear == dizi.Length - 1;
		}
		public void enqueue(T item)
		{
			if (isFull ())
				throw new Exception ("Queue is full!");
			if (isEmpty ()) {
				front = 0;
			}
			dizi [++rear] = item;
		}
		public T dequeue()
		{
			if (isEmpty ())
				throw new Exception ("Queue is empty");
			T donen = dizi [front++];
			if (front > rear)
				front = rear = -1;
			return donen;
		}
		public int Count{
			get { 
				if (isEmpty ())
					return 0;
				return rear - front + 1;
			}
		}
		public void print()
		{
			for (int i = front; i <= rear; i++) {
				Console.WriteLine (dizi[i]);
			}
		}
	}
}

