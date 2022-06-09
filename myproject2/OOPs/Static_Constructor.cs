using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{
    class Static_Constructor
    {
        // static constructor
        static Static_Constructor()
        {
            Console.WriteLine("Example of static constructor");
        
        }
        // instance constructor
        public Static_Constructor(int j)
        {
            Console.WriteLine("Instance Constructor " + j);
        }
        //instance method

        public string get_name(string name, string batch)
        {

            return " Name : " + name + " Batch : " + batch;
        
        }
       
        public static void Main(string[] args)
        {
            Static_Constructor s = new Static_Constructor(2);
            Console.WriteLine(s.get_name("Rohan", "Java"));

            Static_Constructor f = new Static_Constructor(2);
            Console.WriteLine(f.get_name("Prahar" , "Python"));
        }
    }
}
