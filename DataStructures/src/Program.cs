using System;
using System.Collections.Generic;

namespace DataStructures.src
{
	class Program
	{
		public static Random rng = new Random();

		static void Main(string[] args)
		{
			Person p1 = new("John", "Snow");

			CustomStack<int> stack = new CustomStack<int>();



			for (int i = 0; i < 10; i++)
			{
				stack.Push(rng.Next(-10, 10));
			}

			
			while (stack.Size > 0)
			{
				Console.WriteLine(stack.Pop());
			}
		}
	}
}
