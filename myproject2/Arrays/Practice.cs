using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject2.Arrays
{
    class Practice
    {

		static void Main(string[] args)
		{
			/*int i, j, p, s = 0;
			int[] arr = { 11, 12, 13 };
			

		

			for (i = 0; i < arr.Length; i++)
			{
				j = 2;
				p = 1;
				while (j < arr[i])
				{
					if (arr[i] % j == 0)
					{
						p = 0;
						break;
					}
					j++;
				}

				if (p == 1)
				{
					s = s + arr[i];
				}
			}
			Console.Write("Sum of prime numbers:" + s);*/
/*
			int[,] arr = new int[2, 4] { { 1, 2, 3, 4 }, { 3, 4, 4, 5 } };


			for (int i = 0; i < 2; ++i)
			{
				for (int j = 0; j < 4; ++j)
				{

				}
			}

			for (int i = arr.GetLength(0) - 1; i >= 0; --i)
			{
				for (int j = arr.GetLength(1) - 1; j >= 0; --j)
				{
					Console.Write(arr[i, j] + " ");
				}
				Console.WriteLine();
			}*/


			//int[,] arr1 = new int[2, 2] { { 1, 2 }, { 2, 3 } };
			int[] arr1 = { 4, 3, 2, 4, 9, 2 };


			int[,] a = new int[2,2] { { 2, 3 } , { 4, 5 } };


			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
                    Console.WriteLine(a[i,j]+" ");
				}
			
			}



		}






    }
}
