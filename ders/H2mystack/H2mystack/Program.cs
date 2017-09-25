using System;

namespace H2mystack
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MyStack<int> stack = new MyStack<int> ();
			stack.push (5);
			stack.push (2);
			stack.push (7);
			stack.pop ();
			stack.push (6);
			stack.push (9);
			stack.push (4);
			stack.pop ();
			stack.pop ();
			stack.push (12);
			stack.print ();
			//while (true)
			//	stack.pop ();
			MyStack<string> stack2=new MyStack<string>();
			stack2.push ("Şevket");
			stack2.push ("Yuşa");
			stack2.push("Lassine");
			while(!stack2.isEmpty())
				Console.WriteLine (stack2.pop());
		}
	}
}
