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
			/* int[] firstRow = new int[n];
			for(int i = 0; i < n; ++i)
			{
				firstRow[i] = i + 1;
			}
			result[0] = firstRow;*/
			for(int i = 0; i < n; ++i)
			{
				// generate any row
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
	}
}

/**
 *  [1, 2, 3]
 *  [2, 3, 1]
 *  [3, 1, 2]
 *  
 *  [1, 2, 3, 4]
 *  [2, 3, 4, 1]
 *  [3, 4, 1, 2]
 *  [4, 1, 2, 3]
 */