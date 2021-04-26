using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.src
{
	public class Person
	{
		public string Name { get; set; }
		public string LastName { get; set; }

		public Person(string name, string lastName) =>
			(Name, LastName) = (name, lastName);

		public override string ToString()
		{
			return $"{Name} {LastName}";
		}
	}
}
