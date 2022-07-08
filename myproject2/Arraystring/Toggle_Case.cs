using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Arraystring
{
    class Toggle_Case
    {
        static void Main(string[] args)
        {
            string str = "ReGInold";//upperCase to lowerCase
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'Z')
                    ch[i] = (char)(ch[i] + 'a' - 'A');
                else if (ch[i] >= 'a' && ch[i] <= 'z')
                    ch[i] = (char)(ch[i] + 'A' - 'a');
            }
            Console.WriteLine(ch);
        }
    }
}
