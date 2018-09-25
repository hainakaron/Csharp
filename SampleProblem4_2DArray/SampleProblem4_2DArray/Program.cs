using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProblem4_2DArray
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter the dimension of the square array:");
			int dim = Convert.ToInt32(Console.ReadLine());
			int[,] array = new int[dim,dim];
			int num;
			for (int column = 0; column < dim; column++)
			{
				num = 0;
				for (int row = column; row < dim; row++)
				{
					num++;
					array[row, column] = num;
					array[column, row] = num;
				}
			}

			Console.WriteLine("View of the table");
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
