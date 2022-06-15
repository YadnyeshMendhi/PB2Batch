using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Delegates
{
    class Call_Back
    {
        class call
        { 
            static void greet(string nm)
            {
                Console.WriteLine(nm + " , Welcome to online tutorial"); ;
            }
            static void m3(string name , Action<string> fuctionponter)
            {
                Console.WriteLine("Welcome to TQ");
                fuctionponter(name);
            }
            static void Main(string[] args)
            {
                m3("Reginold" , greet);
            }
        
        }


    }
}
