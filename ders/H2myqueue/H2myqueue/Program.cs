using System;

namespace H2myqueue
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MyQueue<int> queue = new MyQueue<int> ();
			queue.enqueue (5);
			queue.enqueue (7);
			queue.enqueue (4);
			Console.WriteLine ("Eleman sayısı:{0}",queue.Count);
			queue.dequeue ();
			queue.dequeue ();
			queue.dequeue ();
			Console.WriteLine ("Eleman sayısı:{0}",queue.Count);
			queue.print ();
			queue.enqueue (6);
			Console.WriteLine ("Eleman sayısı:{0}",queue.Count);
			queue.enqueue (5);
			queue.enqueue (7);
			queue.enqueue (4);
			queue.print ();
		}
	}
}
