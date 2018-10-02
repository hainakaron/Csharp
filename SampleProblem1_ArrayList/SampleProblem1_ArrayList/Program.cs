using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SampleProblem1_ArrayList
{
	class Program
	{
		static void Main(string[] args)
		{
			//declaration of variables
			ArrayList container = new ArrayList();
			string answer = null;

			//ask for inputs
			Console.WriteLine("Please enter any values. Enter thw word \"stop\" to stop.");
			do
			{
				answer = Console.ReadLine();
				container.Add(answer);
			}
			while (answer != "stop");

			//removing the added "stop" in the arraylist
			container.Remove("stop");

			//sorting process
			ArrayList intcontainer = new ArrayList();
			for (int x = 0; x < container.Count; x++)
			{
				if (int.TryParse(container[x].ToString(), out int value))
				{
					intcontainer.Add(value);
					container.RemoveAt(x);
				}
			}

			container.Sort();
			intcontainer.Sort();
			container.InsertRange(0, intcontainer);

			//display the arraylist
			Console.WriteLine("The sorted values of the arraylist:");
			for ( int x=0; x<container.Count; x++)
				Console.WriteLine(container[x]);
			Console.ReadLine();
			

		}
	}
}
