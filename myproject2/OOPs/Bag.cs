using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{
    class Pen
    {
        String epen;

        public Pen(String epen)
        {
            this.epen = epen;
        }

        public void show()
        {
            Console.WriteLine(epen);
        }
        String colour;
        String name;
        Nib enib;

        public Pen(String colour, String name, Nib enib )
        {
            this.colour = colour;
            this.name = name;
            this.enib = enib;
        }
        void display()
        {
            Console.WriteLine(colour + " " + name + " ");
            enib.show();
        }




    }

    class Bag
    {
        String colour;
        String name;
        Pen epen;

        public Bag(String colour , String name , Pen epen)
        {
            this.colour = colour;
            this.name = name;
            this.epen = epen;
        }
        void display()
        {
            Console.WriteLine(colour+" "+ name+" ");
            epen.show();
        }

        static void Main(String [] args)
        {

            /*Nib n = new Nib("Metal");
            Pen p = new Pen("DOMS" ,n);
            Pen p1 = new Pen("Blue", "Cello" );
            Bag b = new Bag("Black", "Gucci", p);
*/
        }




    }

    class Nib
    {
        String enib;

        public Nib(String enib)
        {
            this.enib = enib;
        }

        public void show()
        {
            Console.WriteLine(enib);
        }
    }
}
