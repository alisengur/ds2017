using System;

namespace H6AVLTrees
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			AVLTree<int> t = new AVLTree<int> ();
			for (int i = 1; i < 16; i++) {
				t.insert (i);
			}
			t.print ();
			t.remove (8);
			t.remove (10);
			t.remove (11);
			t.print ();
		}
	}
}
