using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Staticclass
    {


        static int y = 20;
        int x = 400;

        int x1 = 0;
        static int c = 0;

        static Staticclass()
        {
            Console.WriteLine("Hii this is default");
        }

        void show()
        {
            y = 20;
            Console.WriteLine("Hii this is show" +y+" "+x);
        }

        static void read()
        {
            Staticclass m = new Staticclass();
            Console.WriteLine("Hii this is read"+y+" "+m.x);
        }
       
        public Staticclass()
        {
            x++;
            Console.WriteLine("x=" +x1);

            c++;
            Console.WriteLine("c="+c);
        }
        
        static void Main(String [] args)
        {
            Staticclass d = new Staticclass();
            d.show();
            Staticclass.read();
            Console.WriteLine(d.x);
            Console.WriteLine(c);

        }
    }
}
