using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    //Containment is the simple approach,
    //in which a class B, that needs access to the members of class A,
    //contains an instance/object of class A, rather then inheriting the class A.

    class Engine
    {
        String ename;

        public Engine(String ename)
        {
            this.ename = ename;
        }

        public void show()
        {
            Console.WriteLine(ename);
        }
    }
        
    class Car
    {

            int id;
            String name;
            int price;
            Engine ename;

            public Car(int id , String name , int price, Engine ename)
            {
                this.id = id;
                this.name = name;
                this.price = price;
                this.ename = ename;
            }
            void display()
            {
                Console.WriteLine(id+" "+name+" "+price);
                ename.show();
            }
            static void Main(String [] args)
            {
                Engine e = new Engine("Petrol");
                Car c = new Car(101, "Swift", 100000 , e);
                c.display();

            }

        
    }
    


}