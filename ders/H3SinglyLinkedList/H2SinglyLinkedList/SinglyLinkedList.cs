using System;

namespace H2SinglyLinkedList
{
	public class SinglyLinkedList<T>
	{
		Node<T> head;
		public Node<T> getHead(){
			return head;
		}
		public SinglyLinkedList ()
		{}
		public void print()
		{
			Node<T> current = head;
			while (current!=null) {
				Console.Write ("{0} ", current.value);
				current = current.next;
			}
			Console.WriteLine ();
		}
		public void addHead(T value)
		{
			Node<T> newNode = new Node<T> (value, head);
			head = newNode;
		}
		public void addTail(T value){
			Node<T> current = head;
			Node<T> newNode = new Node<T> (value, null);
			if (head == null) {
				head = newNode;
				return;
			}
			while (current.next != null)
				current = current.next;
			current.next = newNode;			
		}
		public void insertAfter(Node<T> node, T value)
		{
			Node<T> newNode = new Node<T> (value, node.next);
			node.next = newNode;
		}
		public void insertAfter(int index, T value){
			int currentIndex = 0;
			Node<T> current = head;
			while (currentIndex < index) {
				current = current.next;
				currentIndex++;
			}
			insertAfter (current, value);
		}

		public T removeHead()
		{
			Node<T> toDelete = head;
			toDelete.next = null;
			head = head.next;
			return toDelete.value;
		}
		
	}
}

