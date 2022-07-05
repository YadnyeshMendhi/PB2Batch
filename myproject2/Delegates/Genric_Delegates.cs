using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Delegates
{
    class Genric_Delegates
    {
/*
        public delegate void mydel1(int x, float y, double z);
        public delegate double mydel2(int x, float y, double z);
        public delegate bool mydel3(string str);*/

        class Delegates
        {
            public void Addnum1(int x, float y, double z)//Non return type method
            {
                Console.WriteLine("Addition=" + (x + y + z));
            }
            public static double Addnum2(int x, float y, double z)//return type method
            {
                return x + y + z;
            }
            public static bool check(string str)//boolean return type method
            {
                if (str.Length > 5)
                    return true;
                else
                    return false;
            }
        }
        static void Main(string[] args)
        {
            Delegates d = new Delegates();
            Action<int , float , double> a1= d.Addnum1;
            a1(12, 34.22f, 56.44);

            Func<int,float,double,double> a2 = Delegates.Addnum2;
            double result = a2(12, 34.23f, 56.5);
            Console.WriteLine(result);


            // in a place of predicate delegate we can use Func<string,bool>
            Predicate<string> d3 = Delegates.check;
            bool status = d3("Welc");
            Console.WriteLine(status);



        }

    }
}

