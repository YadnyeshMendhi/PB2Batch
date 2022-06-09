using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class CountWord
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter string ");
            String str = Console.ReadLine();

            String str1 = "India";
            /*String str = "India is my country  I like india";*/

            String[] words = str.Split(" ");

           // Console.WriteLine("The Length of string is = "+str.Length);

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
                   // if (count > 1)
                    if(count==1)
                    {
                        Console.WriteLine(str1 + " " + count);
                    }
                }
            }
        }
    }
}
