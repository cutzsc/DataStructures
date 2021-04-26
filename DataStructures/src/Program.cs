using System;
using System.Collections.Generic;

namespace DataStructures.src
{
	class Program
	{
		public static Random rng = new Random();

		static void Main(string[] args)
		{
			DynamicArray<int> arr = new(10);

			for (uint i = 0; i < 4; i++)
			{
				arr.Add(rng.Next(-5, 5));
			}

			arr.Info();
			foreach (var elem in arr)
			{
				Console.Write(elem + " ");
			}
			Console.WriteLine();


			//arr.RemoveAt(0);
			//arr.RemoveAt(0);
			//arr.RemoveAt(0);
			//arr.RemoveAt(0);

			//arr.Clear();

			arr.Info();
			foreach (var elem in arr)
			{
				Console.Write(elem + " ");
			}
			Console.WriteLine();
		}
	}
}
