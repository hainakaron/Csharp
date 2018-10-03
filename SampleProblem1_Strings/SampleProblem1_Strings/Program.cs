using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProblem1_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string sentence;
			int counter = 0;
			ArrayList unique_chars = new ArrayList();

			//ask user for the sentence
			Console.Write("Please enter a sentence:");
			sentence = Console.ReadLine();

			//cherry pick the unique characters and
			//place it in the arraylist
			foreach (char c in sentence)
			{
				if (counter == 0)
					unique_chars.Add(c);
				else
				{
					if (!unique_chars.Contains(c))
						unique_chars.Add(c);
				}
				counter++;
			}

			//count the number of occurence of each
			//unique characters
			foreach (object obj in unique_chars)
			{
				counter = 0;
				foreach (char c in sentence)
				{
					if (obj.ToString() == c.ToString())
						counter++;
				}
				//display the character with count
				Console.WriteLine(String.Format("{0} = {1}", obj, counter));
			}

			Console.ReadLine();


		}
	}
}
