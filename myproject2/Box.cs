using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Box
    {

        int height;
        int width;
        int length;
        int area;



        static void Main(string[] args)
        { 

            Box B1 = new Box();

            B1.height = 3;
            B1.length = 5;
            B1.width = 6;
            
            B1.area = (2* B1.length * B1.width) + (2* B1.width * B1.height) + ( 2*B1.length * B1.height);
            Console.WriteLine("Area of box 1 = " +B1.area);








        }
    }
}
