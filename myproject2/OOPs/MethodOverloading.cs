using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{
         class Testdata
         {
            public int add(int a, int b)
            {
                return a + b;
            }
            public int add(int a, int b, int c)
            {
                return a + b + c;
            }
         }

        class MethodOverloading
        {
            static void Main(String[] args)
            {
                Testdata tes = new Testdata();
                int add1 = tes.add(10, 20);
                int add2 = tes.add(10, 20, 30);
                Console.WriteLine(add1);
                Console.WriteLine(add2);

            }
        }
}

