using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Delegates
{
    class Multi_Cast_Delegate
    {

        //Multi-Cast delegate 
        // holding the referance of two methods
        public delegate void mydel(double width, double height);
        class Recatngle
        {
            public void Getarea(double width, double height)
            {
                Console.WriteLine("Area of rectangle=" + (width * height));
            }
            public void GetPerimeter(double width , double height)
            {
                Console.WriteLine("Perimeter of rectangle="+(2*width*height));
            }

        }
        static void Main(string[] args)
        {
            Recatngle a = new Recatngle();

            mydel d1 = new mydel(a.Getarea);
            //binding instatiation
            d1 += a.GetPerimeter;

            d1(345.11, 567.22);
            d1(564.57, 576.11);
            //when we use multi cast delegate values should be non value type return otherwise they will oveeride values
        }
    }
}
