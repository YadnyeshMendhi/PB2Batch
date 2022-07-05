using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Arraystring
{
    class StringAnagram
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st String ");
            String str1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd String ");
            String str2 = Console.ReadLine();
    
            //Anagram strings-->Heart,Listen,Triangle, 
            String s1 = str1.ToLower();
            String s2 = str2.ToLower();

            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            Console.WriteLine(String.Join(" ", ch1));
            Console.WriteLine(String.Join(" " , ch2));

            String st1 = new string(ch1);
            String st2 = new string(ch2);

            if (st1.CompareTo(st2) == 0)
            {
                Console.WriteLine("Both strings are Anagram");
            }
            else
            {
                Console.WriteLine("Both strings are not Anagarm");
            }


            
        }
    }
}
