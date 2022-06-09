using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ExceptionHandler
{
    class Example2
    {
        /* static int divide(int a, int b)
         {
             try
             {
                 Console.WriteLine("in division=");
                 return a / b;
             }
             catch (DivideByZeroException ob)
             {
                 Console.WriteLine("An Exception has occured : " + ob.Message);
             }
             finally
             {
                 Console.WriteLine("in finally");
             }
             return 0;
         }
         static void Main(string[] args)
         {
             Console.WriteLine("main starts");
             int result = divide(10, 2);
             Console.WriteLine("Answer" + result);
             Console.WriteLine("Main Ends");
         }*/


        //
        /*  static void Main()
          {
              String str =null;


                  if (str.Length > 0)
                  {
                      Console.WriteLine(str);
                  }


          }*/

        static int divide(int a, int b)
        {
            try
            {
                Console.WriteLine("in division=");
                return a / b;
            }
            catch (DivideByZeroException obj)
            {
                Console.WriteLine("An Exception has occured : " + obj.Message);
            }
            finally
            {
                Console.WriteLine("in finally");
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            int Result = divide(10, 2);
            Console.WriteLine("Result=" + Result);
            Console.WriteLine("Main ends");
        }
    }
}
       

    

    
