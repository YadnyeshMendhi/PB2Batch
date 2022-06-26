using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Arrays
{
    class ArrayPractice
    {

		static void Main(string[]  args)
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
			int[] a = { 4, 3, 2, 4, 9, 2 };

			/*
						Console.WriteLine("Enter size of an Array");
						int size = Convert.ToInt32(Console.ReadLine());

						int[] a = new int[size];

						Console.WriteLine("Enter Array elements");

						for (int i = 0; i < a.Length; i++)
						{
							a[i] = Convert.ToInt32(Console.ReadLine());
						}

						for (int i = 0; i < a.Length; i++)
						{
							for (int j = i + 1; j < a.Length; j++)
							{
								if (a[i] > a[j])
								{
									int temp = a[i];
									a[i] = a[j];
									a[j] = temp;
								}
							}
						}
						Console.WriteLine();
						Console.WriteLine("Sorted Elements");
						foreach (int ans in a)
						{
							Console.WriteLine(ans);
						}
			*/
			for (int i = 0; i < a.Length; i++)
			{

				int count = 1;
				bool IsVisited = false;
				for (int k = i-1; k > 0; k--)
				{
					if(a[i]==a[k])
					IsVisited = true;
					break;
				}
				if (IsVisited == false)
				{
					for (int j = i + 1; j < a.Length; j++)
					{
						if (a[i] == a[j])
						{
							count++;
						}
					}

					if (count > 1)
					{
                        Console.WriteLine(a[i]+" "+count);
					}
				}



			}
			



		}






    }
}
