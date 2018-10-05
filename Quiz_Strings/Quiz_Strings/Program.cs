using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			//as the user for input
			Console.Write("Please enter a possible palindrome:");
			string word = Console.ReadLine();

			//checking
			bool palindrome = true;
			int x = 0;
			int y = word.Length - 1;
			while (x != y && x < y)
			{
				if (word[x] != word[y])
					palindrome = false;
				x++;
				y--;
			}

			//display the result
			Console.WriteLine(palindrome);
			Console.ReadLine();
		}
	}
}
