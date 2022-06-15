using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Delegates
{
    class ClassDemo
    {
       

        //Delegates : is variable which holds referance of function
        //A delegate is an object which refers to a method or
        //you can say it is a reference type variable that can hold a reference to the methods.
        //Delegates in C# are similar to the function pointer in C/C++.
        //is a variable which holdes reference of method and then call method for excecution.
        //
        public delegate void mydelegate(int x, int y);
        public delegate void mydelegate2(string n);
     
      
        static void add(int a, int b)
        {
            Console.WriteLine("Sum="+(a+b));
        
        }
        void  greet(string nm)
        {
            Console.WriteLine("Welcome"+nm);
        }
        public void product(int a, int b)
        {
            Console.WriteLine("Product="+(a+b));
        }
        static void Main(String[] args)
        {
            /*
                        //single cast delegate
                        ClassDemo obj = new ClassDemo();
                       mydelegate d1 = add;
                        mydelegate2 d2 = obj.greet;

                        //multicast delegate
                        mydelegate d3 = obj.product;
                       // mydelegate d1 = product;
                        //d1 += add;
                        d1.Invoke(12, 9);
                        d3 += add;
                        d1.Invoke(12, 90);
                        d2("Yadnyesh");*/

            // single cast delegate
            ClassDemo c = new ClassDemo();
            mydelegate ad = new mydelegate(ClassDemo.add);
            //mydelegate ad = ClassDemo.add;
            ad.Invoke(10, 20); ad(45, 5);

            mydelegate2 ad2 = new mydelegate2(c.greet);
            //mydelegate2 ad2 = c.greet;
            ad2("Yadnyesh"); ad2("Mendhi");
           
          



        }
    }
}
