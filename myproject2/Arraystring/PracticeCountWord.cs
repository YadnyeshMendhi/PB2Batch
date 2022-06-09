using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class PracticeCountWord
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter string");
            String str = "India is my country and India is the best";
            String str1 = "India";
            String[] words = str.Split();

            for (int i = 0; i < words.Length; i++)
            {
                int count = 1;
                bool isVisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (words[i] == words[k])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            count++;
                        }
                    }
                }
                //if(count > 1)//duplicate words logic 
                if (count > 1)//Unique Numbers
                {
                    Console.WriteLine(str1 + " " + count);
                }
                

                /* String str = "India is my country and India is the best";
                 String str1 = "India";

                 String[] words = str.Split();

                // Console.WriteLine("The Length of string is = " + str.Length);

                 for (int i = 0; i < words.Length; i++)
                 {
                     int count = 1;
                     bool isVisited = false;

                     for (int k = i - 1; k >= 0; k--)
                     {
                         if (words[i] == words[k])
                         {
                             isVisited = true;
                             break;
                         }
                     }
                     if (isVisited == false)
                     {
                         for (int j = i + 1; j < words.Length; j++)
                         {
                             if (words[i] == words[j])
                             {
                                 count++;
                             }
                         }
                        *//* if (count > 1 )
                         {
                             Console.WriteLine(count);
                         }*//*

                     }
                     if (count > 1)
                     {
                         Console.WriteLine(count);
                     }
     */

            }
            

        }
    }
}


         
       