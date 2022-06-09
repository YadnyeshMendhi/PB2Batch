using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ForLoop1to20Even
    {
        static void Main(string[] args)
        {
           
            for(int i = 1; i <=10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
