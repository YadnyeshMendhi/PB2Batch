using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ExtraQuestions
{
    class Coprime
    {

        static void Main(String[] args)
        {


            int a = 100;
            //(5,24) , (7,24)
            //Co prime numbers are those numbers that have only one factor
            //namely 1.

            int j;

            for(int i = 0; i < a; i++)
            {
                int c = 0;
                for(j=1;j<i; j++)
                {
                    if(a % j ==0 && i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 1)
                {
                    Console.WriteLine($"coprime pair is {i} {a}"); ;
                }

/*
                String s = "India is my country";

                Console.WriteLine($"0{s}");*/
            }
        }
    }
}
