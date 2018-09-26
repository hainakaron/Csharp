using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2DArray
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter dimension for the square array:");
			int dim = Convert.ToInt32(Console.ReadLine());
			int[,] array = new int[dim, dim];
			int num = 0, column_index = 0, controller = 1;

			for (int row = 0; row < dim; row++)
			{
				for (int column = 0; column < dim; column++)
				{
					num++;
					array[row, column_index] = num;
					column_index = column_index + controller;
				}
				if (column_index == dim)
				{
					controller = -1;
					column_index = dim - 1;
				}
				else if (column_index == -1)
				{
					controller = 1;
					column_index = 0;
				}

			}

			for (int row = 0; row < dim; row++)
			{
				for (int col = 0; col < dim; col++)
				{
					Console.Write(array[row, col] + "\t");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
