using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Delegates
{
    public class Delegate
    {

        // delegate is a variable which store referance of a function

       /* public delegate void mydel1(int a, int b);
        public delegate void mydel2(int x, int y);*/


        public static void add(int a, int b)
        {
            Console.WriteLine("Addition=" + (a + b));
        }
        public int  factorial(int n)
        {
            if (n == 1)
                return n;
            else
                return n * factorial(n - 1);

        }
        public bool check(string str)
        {
            if (str.Length > 2)
                return true;
            else
                return false;

        }


        public static void Main(string[] args)
        {
            Delegate d = new Delegate();

            Action<int, int> a = Delegate.add;
            a(10, 20);

            Func<int , int> b = d.factorial;
            int ans = d.factorial(10);
            Console.WriteLine("Factorial="+ans);

            Predicate<string > c = d.check;
            bool result =c("yadnyesh");
            Console.WriteLine(result);


           
        }
    }
}
