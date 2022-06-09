using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class Practice
    {

		static void Main(String[] args)
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


			for (int i=0; i<arr1.Length; i++)
            {
				int count = 1;
				bool isVisited = false;
				for(int k=i-1; k>=0; k--)
                {
                    if (arr1[i] == arr1[k])
                    {
						isVisited = true;
						break;
                    }
                }
				if(isVisited == false)
                {
					for(int j =i+ 1; j<arr1.Length; j++)
                    {
                        if (arr1[i] == arr1[j])
                        {
							count++;
                        }
                    }
					if(count == 1 || count > 1)
                    {
                        Console.Write(arr1[i] + " ");
                    }
 
                }
            }




		}






    }
}
