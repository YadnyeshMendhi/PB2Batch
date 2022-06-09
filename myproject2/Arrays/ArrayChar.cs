using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ArrayChar
    {


        static void Main(String [] args)
        {
            char[] ch = { 'e', 'a', 't', 'u', 'f' };

            foreach(char c in ch)
            {
                Console.Write(c);
            }

            for(int i = 0; i<ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }

            Console.WriteLine("///////////////");
            Array.ForEach(ch, Console.WriteLine);

            Console.WriteLine("//////////////////");
            Console.WriteLine(String.Join(",",ch));
        }
    }
}
