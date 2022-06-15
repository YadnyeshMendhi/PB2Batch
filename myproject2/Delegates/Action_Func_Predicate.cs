using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Delegates
{

    class Action_Func_Predicate
    {

        class demo
        {
            public void add(int a, int b)
            {
                Console.WriteLine("Addition=" + (a + b));

            }
            public int divide(int a, int b)
            {
                return a / b;

            }
            public int factorial(int n)
            {
                if (n == 1)
                    return 1;
                else
                    return n * factorial(n - 1);
            }
            public bool product(int a)
            {
                if (a > 10)
                    return true;
                else
                    return false;
            }
        }

            static void Main(string[] args)
            {
                demo d = new demo();
                Action<int, int> a1 = d.add;
                a1(10, 20);

                Func<int,int> a2 = d.factorial;
                int fact = a2(5);
                Console.WriteLine(fact);

                Predicate<int> a3 = d.product;
                bool result = a3(2);
                Console.WriteLine(result);
            }
        
        
    }
}
