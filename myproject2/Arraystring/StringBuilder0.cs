using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class StringBuilder0
    {

        static void Main(string [] args)
        {
            String s = "Hello";

            s = s + "Pune";

            StringBuilder sb = new StringBuilder("Hello" +" ");//Convert String TO StringBuilder
            sb.Append("PUNE");
            Console.WriteLine(sb);

            sb.Insert(5, "C#" );
            Console.WriteLine( sb);

            sb.Replace("PUNE", "Program");
            Console.WriteLine(sb);


            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Hello");
            sb1.Append("pune");
            Console.WriteLine(sb1);


            StringBuilder sb3 = new StringBuilder("india", 40);
            
            //Print vertically HelloC# Program
            for(int i=0; i<sb.Length; i++)
            {
                Console.WriteLine("      "+sb[i]);
            }

            Console.WriteLine(sb.Equals(sb1));
            Console.WriteLine(sb==sb1);

            String str = sb.ToString();
            String str1 = sb1.ToString();
            Console.WriteLine(str.CompareTo(str1));


            //Equal = 0 and NotEqual = 1
            String s0 = "Hello";
            String s1 = "hello";

            Console.WriteLine(s0.CompareTo(s1));


            String p = "Hii i am yadnyesh mendhi";
            Console.WriteLine(p.Substring(0,4));
            String ptr = p.ToString();

        }
    }
}