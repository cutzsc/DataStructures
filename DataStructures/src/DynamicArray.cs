using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.src
{
	public class DynamicArrayEnumerator<T> : IEnumerator<T>
	{
		private int position = -1;
		private readonly int length;
		private readonly T[] data;

		public T Current => data[position];

		object IEnumerator.Current => Current;

		public DynamicArrayEnumerator(in T[] data, in int length)
		{
			this.data = data;
			this.length = length;
		}

		public void Dispose() { }

		public bool MoveNext()
		{
			return ++position < length;
		}

		public void Reset()
		{
			position = -1;
		}
	}

	public class DynamicArray<T> : IEnumerable<T>
	{
		private T[] data;
		private int count = 0;
		private int capacity;

		public int Capacity => capacity;
		public int Count => count;

		public T this[int index]
		{
			get
			{
				if (index < count)
					return data[index];
				throw new ArgumentOutOfRangeException();
			}
			set
			{
				if (index < count)
				{
					data[index] = value;
					return;
				}
				throw new ArgumentOutOfRangeException();
			}
		}

		public DynamicArray(in int capacity = 10)
		{
			this.capacity = capacity;
			data = new T[capacity];
		}

		public void Info()
		{
			Console.WriteLine($"Capacity: {capacity}\tCount: {count}");
		}

		public void Add(in T element)
		{
			if (count == capacity)
			{
				Resize();
			}

			data[count] = element;
			count++;
		}

		public void RemoveAt(in int offset)
		{
			if (offset >= count)
				throw new ArgumentOutOfRangeException();

			data[offset] = data[count - 1];
			count--;
		}

		public int Remove(in T element)
		{
			for (int i = 0; i < Count; i++)
			{
				if (data[i].Equals(element))
				{
					RemoveAt(i);
					return i;
				}
			}
			return -1;
		}

		public void Clear()
		{
			for (int i = 0; i < count; i++)
			{
				data[i] = default(T);
			}
			count = 0;
		}

		private void Resize()
		{
			T[] tmp = data;
			capacity *= 2;
			data = new T[capacity];
			for (int i = 0; i < tmp.Length; i++)
			{
				data[i] = tmp[i];
			}
			tmp = null;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return new DynamicArrayEnumerator<T>(data, count);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)GetEnumerator();
		}
	}
}
