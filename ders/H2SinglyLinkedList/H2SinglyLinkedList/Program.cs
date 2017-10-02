using System;

namespace H2SinglyLinkedList
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			SinglyLinkedList<int> ll = new SinglyLinkedList<int> ();
			ll.addHead (3);
			ll.addHead (5);
			ll.addHead (7);
			ll.print ();
			ll.addTail (9);
			ll.print ();
			ll.insertAfter (ll.getHead (), 15);
			ll.print ();
			ll.insertAfter (0, 76);
			ll.insertAfter (5, 41);
			ll.addHead (12);
			ll.print ();
		}
	}
}
