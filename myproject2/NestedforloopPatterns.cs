using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class NestedforloopPatterns
    {
        static void Main(String[] args)
        {

            //Box pattern

            /*int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i==1 || j==1 ||  i==n|| j==n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                   

                }
                Console.WriteLine();
            }*/

            //N pattern

            /* int n = 5;
             for (int i = 1; i <= n; i++)
             {
                 for (int j = 1; j <= n; j++)
                 {
                     if (j == 1 || i== n || i == j)
                     {
                         Console.Write("*");
                     }
                     else
                     {
                         Console.Write(" ");
                     }/


                 }
                 Console.WriteLine();
 */
            /*1
              123
              456*/
            /*
                        int x = 1;
                        for (int i = 1; i <= 4; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write(x);
                                x++;
                            }
                            Console.WriteLine();
                        }*/

            // + pattern
            /*
                        int n = 5;

                        for (int i = 1; i <= 5; i++)
                        {
                            for (int j = 1; j <= 5; j++)
                            {
                                if (i == 3 || j == 3)
                                {
                                    Console.Write(" * ");
                                }
                                else
                                {
                                    Console.Write("  ");
                                }
                            }
                            Console.WriteLine();
                        }*/
            /* 1
             10
             101
             1010
             101010*/


            /* for(int i = 1; i <= 5; i++)
             {
                 for(int j = 1; j <=i; j++)
                 {
                     if(j % 2 == 0)
                     {
                         Console.Write("0");
                     }
                     else
                     {
                         Console.Write("1");
                     }
                 }
                 Console.WriteLine();

             }*/

            int n = 3;
            int z = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = n - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= z; k++)
                {
                    Console.Write(z);
                }
                z = z + 2;
                Console.WriteLine();
            }
            /*
                        // Floyd's Triangle
                        int n = 3;
                        int count = 1;
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write(count);
                                count++;
                            }
                            Console.WriteLine();
                        }
            */


        }

    }
}



