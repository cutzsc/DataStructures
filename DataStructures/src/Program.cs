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

			Chain<Person> chain = new Chain<Person>();

			chain.AddHead(p1);
			chain.AddHead(new Person("Ad", "Cd"));
		}
	}
}
