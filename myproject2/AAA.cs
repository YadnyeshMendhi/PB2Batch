using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2
{
    class AAA
    {
       
        static void Main(String[] args)
        {
            

            string str = Console.ReadLine();

            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'Z')
                    ch[i] = (char)(str[i] + 'a' - 'A');
                else if (ch[i] >= 'a' && ch[i] <= 'z')
                    ch[i] = (char)(str[i] + 'A' - 'a');
            }
            Console.WriteLine(ch);
        }


    }
}
