using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class TotalAveragePercentage
    {
        static void Main(string[] args)
        {
            double eng, phy, chem, maths, his;
            double Total, Average, Percentage;

            // Input Marks of all subjects

            Console.WriteLine("Enter marks of 5 subjects : ");
            eng = Convert.ToInt32(Console.ReadLine());
            phy = Convert.ToInt32(Console.ReadLine());
            chem = Convert.ToInt32(Console.ReadLine());
            maths = Convert.ToInt32(Console.ReadLine());
            his = Convert.ToInt32(Console.ReadLine());

            // Calculte Total , Average , Percentage

            Total = eng + phy + chem + maths + his;
            Average = Total / 5.0;
            Percentage = (Total / 500.0) * 100;

            // Print 5 Subjects

           
            
            Console.WriteLine("Total Marks = " +Total);
            Console.WriteLine("Average = " +Average);
            Console.WriteLine("Percentage = " +Percentage);


        }
    }
}
