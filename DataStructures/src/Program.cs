using System;

namespace DataStructures.src
{
	class Program
	{
		public static Random rng = new Random();

		static void Main(string[] args)
		{
			HashTable<int, string> table = new(3);

			for (int i = 0; i < 20; i++)
			{
				string str = "";
				if (i % 2 == 0)
				{
					str = $"String by: {i}";
				}
				else
				{
					str = $"Created with: {i}";
				}

				table.Add(i, str);
			}

			Console.WriteLine(table.Get(5));
		}
	}
}
