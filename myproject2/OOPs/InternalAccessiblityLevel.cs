using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{

    internal class complex
    {
        int real;
        int img;

        public void setdata(int r , int i)
        {
            real = r;
            img = i;

        }
        public void displaydata()
        {

            Console.WriteLine("the value of real : {0}" , real);
            Console.WriteLine("the value of img : {0}" , img);
        }
    }


    class InternalAccessiblityLevel
    {
        static void Main(String[] args)
        {
            complex c = new complex();
            c.setdata(10, 20);
            c.displaydata();
        }
    }
}
