using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.CSharpCollections
{
    /*
         public class InvalidAgeException : Exception
         {
             public InvalidAgeException(String msg) : base(msg)
             {

             }
         }

         public class AssignmentCollecProg2
         {
             // static method
             static void Validate(int age)
             {
                 if (age < 18)
                 {


                     throw new InvalidAgeException("Sorry , Age should be greater than 18");
                 }
             }

             static void Main(String[] args)
             {
                 try
                 {
                     Validate(15);
                 }
                 catch (InvalidAgeException obj)
                 {
                     Console.WriteLine(obj.Message);
                 }
             }*/

    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base(message)
        {

        }
    }
    public class AssignmentCollecProg2
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                validate(12);
            }
            catch (InvalidAgeException e) { Console.WriteLine(e); }
            Console.WriteLine("Rest of the code");
        }

    }
    
}
