using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class PassByMethod
    {

        public static void checkprime(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                bool isprime = true;
                int n = a[i];

                for (int j = 2; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isprime = false;
                        break;

                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(a[i] + "is a Prime");
                }
            }
        }

        public static bool checkArrayPrime(int n)
        {
            bool isPrime = true;
            for(int i=2; i<n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(String [] args)
        {
            int[] a = { 6, 7, 8, 4, 3, 9 };

            for(int i=0; i<a.Length; i++)
            {
                bool isPrimeCheck = PassByMethod.checkArrayPrime(a[i]);

                if(isPrimeCheck == true)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
