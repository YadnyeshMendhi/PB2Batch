using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Delegates
{

    class Practice_Class
    {
        //Multi cast delegate 
        //holding the referance of two methods
        public delegate void mydeligate(double width, double height);
        class rectangle
        { 

            public void Getarea(double width , double height)
            {
                Console.WriteLine("Area of rectangle="+(width*height));
            }
            public void Getperimeter(double width , double height)
            {
                Console.WriteLine("Area of rectangle="+(2*width*height));
            }
        
        }

        static void Main(string[] args)
        {
            rectangle rect = new rectangle();
            mydeligate m1 = new mydeligate(rect.Getarea);
            //binding instantiation
            m1 += rect.Getperimeter;


            m1(746.22, 382.55);
            Console.WriteLine();
            m1(456.11, 678.33);





        }
    }
}
