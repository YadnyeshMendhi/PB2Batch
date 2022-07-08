using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Delegates
{
    class practice2
    {
        public delegate void mydeleg(int a, int b);
        class ppp
        {
/*
            public void Add(int a, int b)
            {
                Console.WriteLine("sum=" + (a + b));
            }
*/

        }
        static void Main(string[] args)
        {
            
            ppp p = new ppp();
            mydeleg m1 =(a,b)=>{

            Console.WriteLine("sum=" + (a + b));

            };
            m1(10, 20);


        }
    }
}