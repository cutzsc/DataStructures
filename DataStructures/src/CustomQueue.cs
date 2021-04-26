using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.src
{
	public class CustomQueue<T>
	{
		LinkedList<T> data;

		public int Count => data.Count;

		public CustomQueue() =>
			data = new LinkedList<T>();

		public CustomQueue(IEnumerable<T> collection) =>
			data = new LinkedList<T>(collection);

		public T Peek()
		{
			return data.First.Value;
		}

		public T Poll()
		{
			T item = data.First.Value;
			data.RemoveFirst();
			return item;
		}

		public void Enqueue(T item) => data.AddLast(item);
	}
}
