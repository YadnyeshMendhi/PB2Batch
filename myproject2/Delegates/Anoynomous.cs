using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Delegates
{

    //public delegate void mydel(int a, int b);

    class Anoynomous
    {
        public delegate void mydel(int a, int b);
        static void Main(string[] args)
        {
            mydel d1 = delegate (int a, int b)
            {
                Console.WriteLine("Addition=" + (a + b));
            };
            d1(12, 9);
        }
    }
}
