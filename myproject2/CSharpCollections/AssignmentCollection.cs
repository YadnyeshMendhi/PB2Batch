using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
{
    
    class AssignmentCollection
    {
/*
        // DividebyZero Exception
        static void divide(int a, int b)
        {
            Console.WriteLine("Division=" + a / b);
        }
*/

        static void Main(String[] args)
        {

            // Write a code to remove duplicate elements from above list. 
            // Final Arraylist should contain(Sun, Mon, Sat);

            /*  ArrayList al = new ArrayList();

              al.Add("Sun");// 4
              al.Add("Mon");// 3
              al.Add("Sat");// 3
              al.Add("Sun");
              al.Add("Mon");
              al.Add("Sat");
              al.Add("Sun");
              al.Add("Sat");
              al.Add("Sun");
              al.Add("Mon");


              al.RemoveRange(3, 7);

              foreach (object item in al)
              {
                  Console.WriteLine(item);
              }
  */



            //Sort Arraylist of String in reverse order of its natural sorting. 



            /*  ArrayList list = new ArrayList();

              Console.WriteLine("MONTHS");
              Console.WriteLine("...........................");
              list.Add("January");
              list.Add("February");
              list.Add("March");
              list.Add("April");
              list.Add("May");
              list.Add("June");
              list.Add("July");
              list.Add("Augest");
              list.Add("September");
              list.Add("Octomber");
              list.Add("November");
              list.Add("December");


              list.Reverse();

              foreach(object item in list)
              {
                  Console.WriteLine(item);
              }*/


            // Create ArrayList of T20 Players. Create a class Player (playerid, Name, Country, team)
            // e.g.   (1,”MSDhoni”,”India”,”Chennai Super Kings”)


            /*ArrayList players = new ArrayList();

            players.Add(" 1 "  +" , "+ " MSDhoni " +" , "+ " India " +" , "+ " Chennei Super Kings ");
            players.Add(" 2 " +" , "+ " ViratKohali " +" , "+ " India " +" , "+ "Kings 11 Punjab ");
            players.Add(" 3 " +" , "+ " HardikPandya " +" , "+ " India " +" , "+ " Mumbai Indians");
            players.Add(" 4 " +" , "+ " YuzvendraChahal " +" , "+ " India " +" , "+ " Rajasthan Royals ");
            
            foreach(object items in players)
            {
                Console.WriteLine(items);
            }*/

            //WAP to catch multiple exceptions. i.e IndexOutOfRangeException, NullReferenceException , DivideByZeroException.

            // IndexOutOfRangeException exception
            /*int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            try
            {
                Console.WriteLine(arr[7]);
            }
            catch (IndexOutOfRangeException obj)
            {
                Console.WriteLine("An Exception has occured : " + obj.Message);
            }
            //DivideByZeroException Exception
            try
            {
                divide(10, 0);
            }
            catch (DivideByZeroException obj1)
            {
                Console.WriteLine("An exception has occured : " + obj1.Message);
            }
            // NullReferenceException
            String str = null;
            try
            {
                Console.WriteLine(str.Substring(0, 6));
            }
            catch (NullReferenceException obj3)
            {
                Console.WriteLine("Please check the string str.");
                Console.WriteLine(obj3.Message);
            }
            Console.WriteLine("Continue with other statemnts");
*/


            // WAP to show exception and use multiple catch block with universal Exception handler.


          /*  int[] arr = { 19, 25, 0, 56 };

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }
            catch (IndexOutOfRangeException obj1)
            {
                Console.WriteLine("An Exception has ocuured : " + obj1.Message);
            }
            catch (DivideByZeroException obj2)
            {
                Console.WriteLine("An  Exception has occured : " + obj2.Message);
            }
            catch (ArgumentException obj3)
            {
                Console.WriteLine("An exception has occured : " + obj3.Message);
            }
            catch (SystemException e)
            {
                Console.WriteLine("An exception has occured : " + e.Message);
            }
*/





        }
    }
    
}
