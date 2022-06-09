using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class FriendsAgeYourAge
    {
        static void Main(string[] args)
        {
            int yourage , friendsage;
            Console.WriteLine("Enter yourage");
            yourage = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter friendsage");
            friendsage = Convert.ToInt32(Console.ReadLine());
           

            if(friendsage < yourage) 
            {
               
                    Console.WriteLine("HII");

            }
            else if(yourage > friendsage) 
            {
                Console.WriteLine("GOOD MORNING");
            }
            else
            {
                Console.WriteLine("HOW ARE YOU ?");
            }
            
        }
    }
}
