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

           /* public void Add(int a, int b)
            {
                Console.WriteLine("sum=" + (a + b));
            }
*/

        }
        static void Main(string[] args)
        {

            //lambda
            ppp practice = new ppp();

            mydeleg m1 = delegate (int a, int b)
            {
                Console.WriteLine("Addition=" + (a + b));
            };
            m1(10, 20);

        }
    }
}
