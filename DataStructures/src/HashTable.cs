using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.src
{
	public class HashTable<Key, Value>
		where Key : notnull
	{
		public class Pair
		{			
			public Key Key { get; set; }
			public Value Value { get; set; }
			public int HashCode { get; private set; }

			public Pair(Key key, Value value) =>
				(Key, Value, HashCode) = (key, value, key.GetHashCode());
		}

		private LinkedList<Pair>[] data;

		public int Capacity { get; private set; }

		public HashTable(in int capacity = 5)
		{
			data = new LinkedList<Pair>[capacity];
			Capacity = capacity;
		}

		public Value Get(in Key key)
		{
			int hashCode = key.GetHashCode();
			int pairIndex = GetPairIndex(hashCode);
			Pair pair = GetPair(pairIndex, hashCode);

			if (pair == null)
				throw new ArgumentException();

			return pair.Value;
		}

		public void Add(Key key, Value value)
		{
			Pair newPair = new Pair(key, value);
			int pairIndex = GetPairIndex(newPair.HashCode);

			if (data[pairIndex] == null)
				data[pairIndex] = new LinkedList<Pair>();

			Pair existentPair = GetPair(pairIndex, newPair.HashCode);
			if (existentPair == null)
			{
				data[pairIndex].AddLast(newPair);
			}
			else
			{
				existentPair.Value = newPair.Value;
			}
		}

		private Pair GetPair(in int pairIndex, in int hashCode)
		{
			foreach (var item in data[pairIndex])
			{
				if (hashCode == item.HashCode)
					return item;
			}
			return null;
		}

		private int GetPairIndex(in int hashCode)
		{
			return hashCode % Capacity;
		}
	}
}
