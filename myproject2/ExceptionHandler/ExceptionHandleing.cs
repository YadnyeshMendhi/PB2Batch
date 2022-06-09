using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ExceptionHandleing
    {

        static void Main(String[] args)
        {
            /* try
             {
                 //statemnts that may cause an exception 
             }
             catch(//Exception obj)
             {
                 //handler code
             }*/

            //using try and catch block

            int[] arr = { 1, 2, 3, 4, 5 };

            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

            try
            {

                Console.WriteLine(arr[7]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("An Exception has occured : {0}" , e.Message);
            }




        
        }
    }
}
