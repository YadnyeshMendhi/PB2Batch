using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PracticeClass2
    {
        static void Main(String[] args)
        {
            /* 
              for (int i = 1; i <= 100; i++)
              {

                  if (i % 5 == 0) 
                  {
                      Console.WriteLine(i);
                  }


              }*/

            /*
                 int b = 0;
                 do
                 {
                     int a = 2;
                     b++;
                     Console.WriteLine(a++);
                 }
                 while (b != 3);*/
            /*
                        int i = 1;
                         int k = 1;
                        while (i++ <= 5)
                        {
                            k *= i;
                        }
                        Console.WriteLine("k = " + k + "i = " + i);*/


            /*
                        int flag = 0;
                        Console.WriteLine("Enter a number to check number is  trimorphic or not ");
                        int N = Convert.ToInt32(Console.ReadLine());

            */

            /*
            int cube = N * N * N;
           

            while (N != 0)
            {
                if (N % 10 != cube % 10)
                {
                    flag = 1;
                    break;

                }

                N /= 10;
                cube /= 10;

            }


            if (flag == 0)
                {
                    Console.WriteLine("Trimorphic number ");
                }
                else
                {
                    Console.WriteLine("Not trimorphic number ");
                }*/

            int i = 1;
            while (i < 10)
            {

                i = i + 1;
                if(i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
            }
        }

    }
    


