using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.ExceptionHandler
{

    //User defined or Custom Exception
    //Custom exceptions can be used to add clear, meaningful, and user-friendly
    //information to exceptions when errors occur while your program is running.
    //The base class for all exceptions in . Net is Exception


    public class InvalidAgeException : Exception // inherit Exception class
    {
        public InvalidAgeException(String message) : base(message)
        {
            Console.WriteLine("An Exception has occured");
        }
    }

        public class TestUserDefinedException
        {
            static void Validate(int age)
            {
            if (age < 18)
            {
                // throw the exception explicitly
                throw new InvalidAgeException("Sorry,Age must be greater than 18");
               
            }
            else if (age > 18)
            {
                Console.WriteLine("Congragulations,Your age is greater than 18");
            }
            }
            public static void Main(string[] args)
            {
                 Console.WriteLine("Enter a your Age");
                 int Age = int.Parse(Console.ReadLine());
                try
                {
                    Validate(Age);
                }
                catch (InvalidAgeException obj)
                {
                    Console.WriteLine("An Exception has occured "+obj.Message);
                }

            }
        }
    
}
