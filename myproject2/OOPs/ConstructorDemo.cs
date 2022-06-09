using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ConstructorDemo
    {

        public ConstructorDemo()
        {
            Console.WriteLine("Hii i am default");
           
        }
        public ConstructorDemo(int x)
        {
            Console.WriteLine("This is my parameterized constructor");
        }
        static ConstructorDemo()
        {
            Console.WriteLine("This is static constructor");
        }
        void add()
        {

        }
        private ConstructorDemo(String name)
        {
            Console.WriteLine(name);
        }
        static void Main(String [] args)
        {
            ConstructorDemo d = new ConstructorDemo();
            ConstructorDemo d1 = new ConstructorDemo(400);

            ConstructorDemo d3 = new ConstructorDemo("Pune ");
           
        }
    }
}
