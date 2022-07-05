using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2
{
    class Test_Class
    {
        static void Main(String[] args)
        {

            //Heart-->Earth
/*

            Console.WriteLine("Enter a first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter a second string");
            string str2 = Console.ReadLine();

            string s1 = str1.ToLower();
            string s2 = str2.ToLower();

            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            Console.WriteLine(String.Join(" ", ch1));
            Console.WriteLine(String.Join(" ", ch2));

            String s3 = new string(ch1);
            String s4 = new string(ch2);

            if (s3.CompareTo(s4) == 0)
            {
                Console.WriteLine("Both strings are Anagram");

            }
            else
            {
                Console.WriteLine("Both string are not Anagram");

            }
            //Fibonacci series
            int a = 0, b = 1, c, i = 3, n;
            Console.Write("Enter a Number : ");
            n = int.Parse(Console.ReadLine());
            Console.Write("{0} {1}",a,b);

            while (i <= n)
            {
                c = a + b;
                Console.Write(" "+c);
                a = b;
                b = c;
                i++;

            }
            Console.ReadLine();*/

            //The recursive function or method is a very strong functionality in C#.
            //A recursive method is a method which calls itself
            //again and again on basis of few statements which need to be true.


            Console.WriteLine("Enter a Number");

            int number = Convert.ToInt32(Console.ReadLine());

            //invoke the static method   

            double factorial = Factorial(number);



            //print the factorial result   

            Console.WriteLine("factorial of" + number + "=" + factorial);



        }

        public static double Factorial(int number)

        {

            if (number == 0)

                return 1;

            return number * Factorial(number - 1);//Recursive call   
        }


      
    }
}
