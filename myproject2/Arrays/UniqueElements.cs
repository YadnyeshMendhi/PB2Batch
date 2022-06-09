using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class UniqueElements
    {

        static void Main(String [] args)
        {
            int[] a = { 7, 8, 3, 7, 4, 3, 3, 2 };

            for(int i = 0; i<a.Length; i++)
            {
                int count = 1;

                bool IsVisited = false;
                for(int k = i - 1; k>0; k--)
                {
                    if(a[i] == a[k])
                    {
                        IsVisited = true;
                        break;
                    }
                }

                if(IsVisited  == false)
                {
                    for(int j = i + 1; j<a.Length; j++)
                    {
                        if(a[i] == a[j])
                        {
                            count++;
                        }
                    }

                    /* if (count == 1)//Unique elements*/
                    if (count > 1)//duplicate elements

                    {
                        Console.WriteLine(a[i] +" "+count);
                    }
                }
            }
        }
    }
}
