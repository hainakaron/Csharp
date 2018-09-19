using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProblem1_2DArray
{
	class Program
	{
		static void Main(string[] args)
		{
			//row will be used in the loop to access the row elements
			//column will be used in the loop to access the column elements
			//counter will be used to access the one-dimensional array elements
			int row, column, counter=0;

			//initializing the 3x5 array
			int[,] number = {
				{ 1, 2, 3, 4, 5 },
				{ 6, 7, 8, 9, 10 },
				{ 11, 12, 13, 14, 15 }
			};

			//assigning the content of the two-dimensional array
			//to the one-dimensional array
			int[] oneDim = new int[number.Length];
			for (row = 0; row < number.GetLength(0); row++)
			{
				for (column = 0; column < number.GetLength(1); column++)
				{
					oneDim[counter] = number[row, column];
					counter++;
				}
			}

			//displaying the one-dimensional array
			Console.WriteLine("Displaying the one-dimensional array in one line");
			for (counter = 0; counter < oneDim.Length; counter++)
			{
				Console.Write(oneDim[counter] + "\t");
			}
			Console.WriteLine();

			//displaying the two-dimensional array
			Console.WriteLine("Displaying the two-dimensional array in table form");
			for (row = 0; row < number.GetLength(0); row++)
			{
				for (column = 0; column < number.GetLength(1); column++)
				{
					Console.Write(number[row,column] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.Write("Press any key to exit...");
			Console.ReadLine();

		}
	}
}
