using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Delegates
{
    //Delegate provides a way to pass a method as argument to other method.
    //To create a Callback in C#, function address will be passed inside a variable.
    //So, this can be achieved by using Delegate.

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
    class call2
    {

        static void M2(string str)
        {
            Console.WriteLine(str);
        
        }
        static void M3(string str, Action<string> functionpointer)
        {
            Console.WriteLine("I have started the task");
            functionpointer(str);
        
        }
        static void Main(string[] args)
        {
            M3("I have completed the task", M2);

        
        
        }
    
    
    
    
    }


   
}
