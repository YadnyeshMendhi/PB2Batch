using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.ExtraQuestions
{
    class Coprime
    {

        static void Main(String[] args)
        {


            //int a = 20;
            Console.WriteLine("Enter a number to check CoPrime");
            int num = Convert.ToInt32(Console.ReadLine());
            //(5,24) , (7,24)
            //Co prime numbers are those numbers that have only one factor
            //namely 1.

            int j;

            /* for(int i = 0; i < num; i++)
             {
                 int count = 0;
                 for(j=1;j<i; j++)
                 {
                     if(num % j ==0 && i % j == 0)
                     {
                         count++;
                     }
                 }
                 if (count == 1)
                 {
                     Console.WriteLine($"coprime pair is {i} {num}"); ;
                 }
 */

            for (int i = 0; i < num; i++)
            {
                int count = 0;
                for (j = 1; j < i; j++)
                {
                    if (num % j == 0 && i % j == 0) {
                        count++;
                    }
                   
                }
                if (count == 1)
                {
                    Console.WriteLine($"Coprime pair is {i} {num}");
                }

            }
/*
                String s = "India is my country";

                Console.WriteLine($"0{s}");*/
            }
        }
    }

