using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProblem3_2DArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int row, column; // these two variables will serve as the counter variable for the for loop in accessing the array
			int x, y; // these two variables will be used to obtain the data
			int temp; // we will store the data in this variable

			//ask the user for the number or rows
			Console.Write("Enter the number of rows:");
			int num_row = Convert.ToInt32(Console.ReadLine());

			//ask the user for the number of columns
			Console.Write("Enter the number of columns:");
			int num_column = Convert.ToInt32(Console.ReadLine());

			//declare the array based on the given dimension
			//this array will be used as a storage for the numbers
			int[,] table = new int[num_row,num_column];

			//use for loop to obtain the data
			for (x = 1; x <= num_row; x++)//x here will serve as the multiplicand
			{
				for (y = 1; y <= num_column; y++)//y here will serve as the multitplier
				{
					temp = x * y; //generate the data
					table[x-1,y-1] = temp;//store the data into the array, use the counter variables to specify the array index
				}
			}

			//display the contents of the array
			for (row = 0; row < table.GetLength(0); row++)
			{
				for (column = 0; column < table.GetLength(1); column++)
				{
					Console.Write(table[row, column] + "\t");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
