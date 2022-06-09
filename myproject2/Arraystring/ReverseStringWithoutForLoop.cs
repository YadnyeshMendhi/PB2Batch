using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class ReverseStringWithoutForLoop
    {

        static void reverse(string str)
        {                            
            if(str != "")
            {
                Console.WriteLine(str[str.Length-1]);
                reverse(str.Substring(0, str.Length - 1));
            }

        }

        static void Main(String[] args)
        {
            reverse("Prasad");
        }
    }
}
