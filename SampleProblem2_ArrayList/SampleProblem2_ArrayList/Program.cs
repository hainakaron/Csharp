using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SampleProblem2_ArrayList
{
	class Program
	{
		static void Main(string[] args)
		{
			//declaration of variables
			ArrayList namelst = new ArrayList();
			string name = null;

			//ask for inputs
			Console.WriteLine("Please enter a name. Input the first name followed by a space and last name. Enter \"stop\" to stop.");
			do
			{
				name = Console.ReadLine();
				namelst.Add(name);
			}
			while (name != "stop");

			//removing the added "stop" in the arraylist
			namelst.Remove("stop");

			//name format correcting process
			for (int x = 0; x < namelst.Count; x++)
			{
				string[] name_arr;
				name_arr = namelst[x].ToString().Split(' ');
				namelst[x] = string.Format("{0}, {1}" , name_arr[1], name_arr[0]);
			}

			//sorting
			namelst.Sort();

			//display the arraylist
			Console.WriteLine("The sorted values of the arraylist:");
			for (int x = 0; x < namelst.Count; x++)
				Console.WriteLine(namelst[x]);
			Console.ReadLine();
		}
	}
}
