using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{
    class X
    {

        protected int x;

        public X()
        {
            x = 10;
        }
       
    }
    class Y : X 
    {
        public int getX()
        {
            return x;
        }
    }

    class ProtectedAccessibilityLevel
    {
        static void Main(String[] args)
        {
            Y obj = new Y();
            Console.WriteLine("The value of x is : {0}" , obj.getX());

        }
    }
}
