using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{



    interface IWishable
    {
        void greet(string msg);


    }
    interface IMaths
    {
        void add(int a, int b);
        int divide(int a, int b);

    }
    class MyInterfaces : IMaths, IWishable
    {

        public void greet(string msg)
        {
            Console.WriteLine("Welcome..." + msg);
        }
        public void add(int x, int y)
        {
            Console.WriteLine("Addition  = " + (x + y));
        }
        public int divide(int a, int b)
        {
            int r = a / b;
            return r;
        }

        static void Main(string[] args)
        {
            IMaths m = new MyInterfaces();
            m.add(10, 90);
            int ans = m.divide(34, 6);
            Console.WriteLine(ans);
        }
    }
}
        

   

