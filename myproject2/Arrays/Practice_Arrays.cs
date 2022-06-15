using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Arrays
{
    class Practice_Arrays
    {
        static void Main(string[] args)
        {
            //Unique elements
            int[] a = { 3, 2, 8, 5, 7, 1, 9 , 9 , 3 };

            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;

                bool IsVisited = false;
                for (int k = i - 1; k > 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        IsVisited = true;
                        break;
                    }

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
                    if (count == 1)
                       Console.WriteLine(a[i]+"-->"+count);
                    /*if (count > 1)
                        Console.WriteLine(a[i] + " " + count);*/
                }
            }
            



        }
        
    }
}
