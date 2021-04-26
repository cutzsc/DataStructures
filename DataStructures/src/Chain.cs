using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.src
{
	/// <summary>
	/// Linked List
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Chain<T>
	{
		public class Node
		{
			public T item;
			public Node prevNode;
			public Node nextNode;

			public Node(T item, Node prev, Node next) =>
				(this.item, prevNode, nextNode) = (item, prev, next);
		}

		private Node head;
		private Node tail;

		public int Length { get; private set; }

		public void AddBefore(T item, Node point)
		{
			for (Node ptr = head; ptr != null; ptr = ptr.nextNode)
			{
				if (ptr == point)
				{
					Node node = new Node(item, ptr.prevNode, ptr);
					ptr.prevNode = node;
					Length++;
					break;
				}
			}
		}

		public void AddAfter(T item, Node point)
		{
			for (Node ptr = head; ptr != null; ptr = ptr.nextNode)
			{
				if (ptr == point)
				{
					Node node = new Node(item, ptr, ptr.nextNode);
					ptr.nextNode = node;
					Length++;
					break;
				}
			}
		}

		public void AddHead(T item)
		{
			if (Length == 0)
			{
				head = new Node(item, null, null);
				tail = head;
			}
			else
			{
				head.prevNode = new Node(item, null, head);
				head = head.prevNode;
			}

			Length++;
		}

		public void AddTail(T item)
		{
			if (Length == 0)
			{
				tail = new Node(item, null, null);
				head = tail;
			}
			else
			{
				tail.nextNode = new Node(item, tail, null);
				tail = tail.nextNode;
			}

			Length++;
		}
	}
}
