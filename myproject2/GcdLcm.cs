using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2
{
    class GcdLcm
    {
        static void Main(String[] args)
        {



            int val1, val2, n1, n2, x;
            int resLCM, resGCD;
            val1 = 10;
            val2 = 16;

            n1 = val1;
            n2 = val2;
            while (n2 != 0)
            {
                x = n2;
                n2 = n1 % n2;
                n1 = x;
            }

            resGCD = n1;
            resLCM = (val1 * val2) / resGCD;

            Console.WriteLine("LCM: ", val1, val2, resLCM);
            Console.WriteLine("GCD: ", val1, val2, resGCD);
            Console.ReadKey();

        }
    }
}
