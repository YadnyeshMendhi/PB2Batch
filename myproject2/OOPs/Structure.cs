using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{
    class Structure
    {

        private String pen;
        private String refil;
        private int caplength;
        private String brand;
        private String inkcolour;
        private int length;
        private String nib;
        private String materialtype;
        private int width;


        public String Pen
        {
            get { return pen; }
            set { this.pen = value; }

        }

        public String Refil
        {
            get { return refil; }
            set { this.refil = value; }

        }

        public int Caplength
        {
            get { return caplength; }
            set { this.caplength = value; }

        }

        public String Brand 
        {
            get { return brand; }
            set { this.brand = value; }

        }

        public String Inkcolour
        {
            get { return inkcolour; }
            set { this.inkcolour = value; }

        }

        public int Length
        {
            get { return length; }
            set { this.length = value; }

        }

        public String Nib
        {
            get { return nib; }
            set { this.nib = value; }

        }

        public String Materialtype
        {
            get { return materialtype; }
            set { this.materialtype = value; }

        }

        public int Width
        {
            get { return width; }
            set { this.width = value; }

        }


        static void Main(String [] args)
        {
            Structure str = new Structure();
            str.pen = "cello";
            str.refil = "plastic";
            str.caplength = 4;
            str.brand = "trimax";
            str.inkcolour = "Black";
            str.length = 4;
            str.nib = "Metal";
            str.materialtype = "plastic";
            str.width = 5;
            Console.WriteLine(str.pen);
            Console.WriteLine(str.refil);
            Console.WriteLine(str.Caplength);
            Console.WriteLine(str.Brand);
            Console.WriteLine(str.Inkcolour);
            Console.WriteLine(str.length);
            Console.WriteLine(str.Nib);
            Console.WriteLine(str.Materialtype);
            Console.WriteLine(str.Width);
            

    }
    }
}
