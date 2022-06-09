using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{
    class Vehicle
    {

        public int wheels = 0;

        void myvehical()
        {
            Console.WriteLine(wheels);
        }


       static void Main(String [] args)
        {
            Bus b = new Bus();
            b.output();
            Car c = new Car();
            c.show();

        }

    }
    class Car : Vehicle
    {
        public void show()
        {
             wheels = 4;
            Console.WriteLine("car Wheels = " + wheels);
        }
    }
    class Bus : Vehicle
    {
        public void output()
        {
            wheels = 6;
            Console.WriteLine("Wheels = " +wheels);
        }
    }
}
