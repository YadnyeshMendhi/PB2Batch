using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ExceptionHandler
{
    class MultipleTryCatch
    {
        static void Main(String[] args)
        {
            /* try
             {
                 //statement that may cause an exception
             }
             catch (//Exception obj)
             {
                 //handler code
             }
             catch (//specific exception obj)
             { 
                 //handler code
             }
             finally
             {
                 //default code
             }*/

            //Multiple try Catch blocks

            //Multiple try and catch blocks use when we not 
            //sure about exception type may be genrated,
            //we write different blocks to tackle any
            //type of exception that is encountered. 

            int[] arr = { 19, 0, 75, 53 };

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("An Exception has occured : {0}" , e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("An Exception has occured : {0}" , e.Message);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("An Exception has occured : {0}" , e.Message);
            }
            finally
            {
                for(int i=0; i<arr.Length; i++)
                {
                    Console.WriteLine("{0}" , arr[i]);
                }
            }
        }
    }
}
