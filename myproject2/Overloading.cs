using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Overloading
    {
        void areaOfreactangle(int l , int w)
        {
            Console.WriteLine("areaOfrectangle = " +(l*w));
        }
        void areaOfcircle(float a , int b , int c)
        {
            Console.WriteLine("areaOfcircle = " +(a*b*c));
        }
        void areaOfsquare(int s , int s1)
        {
            Console.WriteLine("areaOfsquare = " +(s*s1));
        }
        void areaOftriangle(float a1 , int b1 , int h)
        {
            Console.WriteLine("areaOftriangle = " +a1 * (b1*h));
        }

        static void Main(string [] args)
        {
            Overloading d = new Overloading();
            d.areaOfreactangle(5, 6);
            d.areaOfcircle(3.14f, 7, 7);
            d.areaOfsquare(5, 5);
            d.areaOftriangle(0.5f , 5 , 6);
        }


    }
}
