using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ExceptionHandler
{
    class InvalidPasswordException : ApplicationException
    {
        public InvalidPasswordException(String msg)
        {

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





    

