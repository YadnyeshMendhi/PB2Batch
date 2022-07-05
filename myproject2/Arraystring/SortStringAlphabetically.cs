using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Arraystring
{
    class SortStringAlphabetically
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Using Ready_Made function");
            string[] arr = { "Yadnyesh", "Shyam", "Vibhor", "Rohan" };

            Array.Sort<string>(arr);
            foreach (var item in arr)
                Console.WriteLine(item);

            Console.WriteLine();

            Console.WriteLine("Swapping Logic");
            char temp;
            string mystr = "Yadnyesh";
            string str = mystr.ToLower();
            char[] charstr = str.ToCharArray();

            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(charstr);
        }
    }
}
