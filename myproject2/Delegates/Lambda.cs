using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Delegates
{
    //public delegate void mydel(int a, int b);
    class Lambda
    {
        public delegate int  square(int n);
        static void Main(string[] args)
        {
            square d1 = (n) =>//lambda
            {
                // Console.WriteLine("Addition=" + (a + b));
                return n * n;
            };
            int s = d1(10);
            Console.WriteLine(s);
        }
    }
}
