using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class FindSum
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter two Values :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());


            //Calculate SUM
            int SUM = num1 + num2;

            Console.WriteLine("The SUM is = " + num1 +" + " + num2 +" = " +SUM);

          

        }
    }
}
