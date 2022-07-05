using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ExceptionHandler
{

    //Custom exceptions can be used to add clear, meaningful, and user-friendly
    //information to exceptions when errors occur while your program is running.
    //The base class for all exceptions in . Net is Exception

    class InvalidPasswordException : ApplicationException
    {
        public InvalidPasswordException(String msg)
        {
            Console.WriteLine();
        }

    }
    class CustomException
    {


        String name;
        long number;
        string password;

        public void accpet()
        {

            Console.WriteLine("Enter name , mobile number , password");
            name = Console.ReadLine();
            number = long.Parse(Console.ReadLine());
            password = Console.ReadLine();


        }
        void validate()
        {
            /*if (password.Length < 8)
            {
                throw new InvalidPasswordException("Password should be greater than 8");
            }
            if (ValidMobile() == false)
            {
                throw new InvalidMobileException();
            }

        }
        bool ValidMobile
        }*/
        }
    }
}





    

