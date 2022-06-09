using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class OccurencesOfWordString
    {

        static void Main(string [] args)
        {
            //String str = "yadnyesh is a good yadnyesh yadnyesh";
            String str = Console.ReadLine();
            String str1 = "yadnyesh";

            String[] word = str.Split();

            int count = 0;

            for(int i=0; i<word.Length; i++)
            {
                if (str1.Equals(word[i]))
                {
                    count++;
                }
            }
           /* foreach(String st in word)
            {
                Console.WriteLine(st);
            }*/
            Console.WriteLine("The word" + " occurs "+ count +" times ");




        }
    }
}
