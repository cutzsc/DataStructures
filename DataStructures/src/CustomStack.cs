using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.src
{
	class CustomStack<T>
	{
		class Node
		{
			public T item;
			public Node prev;

			public Node(T item, Node prev) =>
				(this.item, this.prev) = (item, prev);
		}

		public int Size { get; private set; }

		Node top;

		public void Push(T item)
		{
			if (Size == 0)
			{
				top = new Node(item, null);
			}
			else
			{
				top = new Node(item, top);
			}

			Size++;
		}

		public T Pop()
		{
			if (Size == 0)
				throw new Exception();

			Size--;

			T item = top.item;
			top = top.prev;
			return item;
		}
	}
}
