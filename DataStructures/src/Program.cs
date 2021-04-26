using System;
using System.Collections.Generic;

namespace DataStructures.src
{
	class Program
	{
		public static Random rng = new Random();

		static void Main(string[] args)
		{
			CustomQueue<int> q = new CustomQueue<int>();

			for (int i = 0; i < 10; i++)
			{
				int a = rng.Next(-10, 10);
				q.Enqueue(a);
				Console.WriteLine(a);
			}

			Console.WriteLine("===============");

			while (q.Count > 0)
			{
				Console.WriteLine(q.Poll());
			}
		}
	}
}
