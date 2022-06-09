using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ExceptionHandler
{
    
     //User defined or Custom Exception

        public class InvalidAgeException : Exception // inherit Exception class
        {
            public InvalidAgeException(String message) : base(message)
            {

            }
        }

        public class TestUserDefinedException
        {
            static void Validate(int age)
            {
                if (age < 18)
                {
                    // throw the exception explicitly
                    throw new InvalidAgeException("Sorry , Age must be greater than 18");
                }
            }
            public static void Main(string[] args)
            {
                try
                {
                    Validate(12);
                }
                catch (InvalidAgeException obj)
                {
                    Console.WriteLine("An Exception has occured" + obj.Message);
                }

            }
        }
    
}
