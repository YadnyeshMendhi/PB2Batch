using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ArrangeZeroTONonZero
    {

        static void Main(String[] args)
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] > 0)
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                            break;
                        }
                    }
                    

                }
            }

            Console.WriteLine("...........................................");
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
