using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2
{
    class AutoMorphicNum
    {

        static void Main(String[] args)
        {

            Console.Write("Enter a number : ");
            int no = Convert.ToInt32(Console.ReadLine());
            Boolean CheckAutoMorphic = true;


            int square = no * no;
            while (no > 0)
            {
                if (no % 10 != square % 10)
                {
                    CheckAutoMorphic = false;
                }
                no = no / 10;
                square = square / 10;
            }
            

            if (CheckAutoMorphic == true)
            {
                Console.WriteLine("Automorphic Number");
            }
            else
            {
                Console.WriteLine("Not Automorphic Number");
            }
            Console.ReadLine();
        }

    }
}
      
        
   