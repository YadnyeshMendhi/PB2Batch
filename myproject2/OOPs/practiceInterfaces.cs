using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{
    interface IWishablemy
    { 
        void greetion(string msg);
    }
    interface IMathsmy
    {

        void addition(int a, int b);
        int division(int x, int y);

    }
    class practiceInterfaces : IMathsmy , IWishablemy
    {

        public void greetion(string msg)
        {
            Console.WriteLine("Welcome...."+msg);
        }
        public void addition(int a, int b)
        {
            Console.WriteLine("Addition = "+(a+b));
        }
        public int division(int x , int y)
        {
            int r = x / y;
            return +r;
        }
        
        static void Main(string [] args)
        {
            IMathsmy w = new practiceInterfaces();
            w.addition(2, 3);
            int ans = w.division(10,5);
            Console.WriteLine(ans);
        }
    }
}
