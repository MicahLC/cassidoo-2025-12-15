using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassidoo_2025_12_15
{
	internal class LatinSquare
	{
		public static int[][] GenerateLatinSquare(int n)
		{
			int[][] result = new int[n][];
			for(int i = 0; i < n; ++i)
			{
				// generate every row
				int[] row = new int[n];
				for(int j = 0; j < n; ++j)
				{
					row[j] = i + j + 1;
					if (row[j] > n)
					{
						row[j] -= n;
					}
				}
				result[i] = row;
			}
			return result;
		}
		public static void Main(string[] args)
		{
			int[][] latinSquare = GenerateLatinSquare(195);
			for (int i = 0; i < latinSquare.Length; ++i)
			{
				Console.Write("[");
				for (int j = 0; j < latinSquare[i].Length; ++j)
				{
					Console.Write(latinSquare[i][j]);
					if (j != latinSquare[i].Length - 1)
					{
						Console.Write(", ");
					}
				}
				Console.WriteLine("]");
			}
		}
	}
}