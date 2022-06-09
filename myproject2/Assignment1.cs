using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Assignment1
    {
        static void Main(String[] args)
        {
            /* int n = 5;
             for (int i = 1; i <= n; i++)
             {
                 for (int j = 1; j < i; j++)
                 {
                     Console.Write(" ");
                 }
                 for (int j = 1; j <= n - i; j++)
                 {
                     Console.Write(" *");

                 }
                 Console.WriteLine();

             }*/


            int val = 5;
            int i, j, k;
            for (i = val; i >= 1; i--)
            {
                for (j = 1; j <= val - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();


            /*  int n = 5;
              int z = 1;

              for (int i = 1; i <= n; i++)
              {
                  for (int j = n - 1; j >= i; j--)
                  {
                      Console.Write(" ");
                  }
                  for (int k = 1; k <= z; k++)
                  {
                      Console.Write(z);
                  }
                  z = z + 1;
                  Console.WriteLine();
              }*/

            /*for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }*/

            //Twin prime number
            /* static bool isPrime(int n)
             {


                 // Corner cases
                 if (n <= 1) return false;
                 if (n <= 3) return true;

                 // This is checked so that we can skip
                 // middle five numbers in below loop
                 if (n % 2 == 0 || n % 3 == 0)
                     return false;

                 for (int i = 5; i * i <= n; i = i + 6)
                     if (n % i == 0 || n % (i + 2) == 0)
                         return false;

                 return true;
             }

             // Returns true if n1 and n2 are twin primes
             static bool twinPrime(int n1, int n2)
             {
                 return (isPrime(n1) && isPrime(n2) &&
                             Math.Abs(n1 - n2) == 2);
             }



             {
                 Console.WriteLine("Enter first number");
                 int n1 = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Enter second number");
                 int n2 = Convert.ToInt32(Console.ReadLine());

                 if (twinPrime(n1, n2))
                     Console.WriteLine("Twin Prime");
                 else
                     Console.WriteLine("Not Twin Prime");
             }*/



            //Print the Series
            //2 12 36 80 150 252....upto 10 terms


            /*
             Logic: -
             2 = 1² +1³

             12 = 2² +2³

             36 = 3² +3³

             80 = 4² +4³*/

            /* Console.WriteLine("Enter the number of terms for the series: ");
             int n = Convert.ToInt32(Console.ReadLine());


             for (int i = 1; i <= n; i++)

             {

                 int a = i * i + i * i * i;

                 Console.Write(a + " ");

             }*/



            // 1! + 2! + 3! + 4!...n WAP a program to find sum
            /*
                        Console.WriteLine("Enter a number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        int sum = 0;
                        int fact = 1;

                        for (int i = 1; i <= num; i++)
                        {
                            fact = fact * i;
                            sum = sum + fact;

                        }
                        Console.WriteLine(sum);*/


           /* //WAP to print fibbo series upto 20 terms
            int prv = 0, pre = 1, trm, i, n;

            Console.Write("\n\n");
            Console.Write("Display the first n terms of fibonacci series:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of terms to be display : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Here is the fibonacci series upto  to {0} terms : \n", n);
            Console.Write("{0}    {1}", prv, pre);

            for (i = 3; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write("  {0}  ", trm);
                prv = pre;
                pre = trm;
            }
            Console.Write("\n");*/

            //WAP to print number from 1 to 50 if number is even then print as it is
            //and number is odd then print negative number with its square

            /*
             for(int i = 1; i <= 50; i++)
             {
                 if(i%2 == 0)
                 {
                     Console.WriteLine(i);
                 }
                 else if(i%2 == 1)
                 {
                     Console.WriteLine("-"+i*i);
                 }

 */
            /*
                        int i = 1;
                        while (i <= 5)
                        {
                            int j = 1;
                            while (j <= 5)
                            {
                                if (j == 2)
                                {
                                    break;
                                    Console.WriteLine(j);
                                }
                                j++;
                            }
                            Console.WriteLine(i);
                        }
            */

        }



    }


}

               





