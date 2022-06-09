using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class ILikeIndiaPattern
    {

        static void Main(string [] args)
        {
            String str = "I Like India Country";

            String[] Length;
            

            for(int i=0; i < str.Length; i++)
            {
                for(int j=i; j<=str.Length-1; j++)
                {
                   for(int k=j;k<=str.Length-1; k++)
                    {
                        Console.WriteLine(k);
                    }
                }
            }
            Console.WriteLine(  );
        }
    }
}
