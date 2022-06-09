using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ForLoopOdd25to75
    {
        static void Main (string[] args)
        {

            
            for(int i = 25; i <=75; i++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine( i);
                }
                
            }
        }
    }
}
