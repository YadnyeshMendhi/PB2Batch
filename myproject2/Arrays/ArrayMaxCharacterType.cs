using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ArrayMaxCharacterType
    {

        static void Main(String[] args)
        {

            char[] ch = { 'a', 'b', 'z', 'd' };

            char max = ch[0];

            for(int i = 0; i<ch.Length; i++)
            {
                if (max<ch[i])
                {
                    max = ch[i];
                }
            }
            Console.WriteLine("Max is = " +max);


        }




    }
}
