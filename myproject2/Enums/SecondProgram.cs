using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Enums
{
    class SecondProgram
    {
        enum months
        { 
            // Enum Items
            Januray, // By default , the first item of an enum has the value 0
            February, // Second has value 1 and so on
            March,
            April = 6, //You can also assign your own enum values, and the next items will update the number accordingly:
            May,
            June,
            July,
            August


        }
        static void Main(String[] args)
        {
            int variable = (int) months.April;
            Console.WriteLine(variable);
          

        }
    }
}
