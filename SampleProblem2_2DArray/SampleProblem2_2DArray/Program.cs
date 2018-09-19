using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProblem2_2DArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] array = new int[5][]; //storage of the arrays
			int[] numbers = new int[5]; //array for the user input
			int x, row, column; //variables for my for loops

			//ask user for 5 integer numbers
			//then store them in the array
			Console.WriteLine("Please enter 5 integer numbers ranging from 1-5: ");
			for (x = 0; x < numbers.Length; x++)
			{
				numbers[x] = Convert.ToInt32(Console.ReadLine());
			}

			for (row = 0; row < numbers.Length; row++)
			{
				int[] data = new int[numbers[row]]; //create separate arrays for the values

				int total = 1; 
				for (column = 0; column < data.Length; column++)
				{
					total = total * numbers[row]; //numbers raised to their incremented value
					data[column] = total; //place the numbers in the array
				}

				array[row] = data; //place the new array to the jagged array
			}

			//display the content of the jagged array
			Console.WriteLine("Final output:");
			for (row = 0; row < array.Length; row++)
			{
				for (column = 0; column < array[row].Length; column++)
				{
					Console.Write(array[row][column] + "\t");
				}
				Console.WriteLine();
			}

			Console.WriteLine("Press any key to continue");
			Console.ReadLine();
		}
	}
}
