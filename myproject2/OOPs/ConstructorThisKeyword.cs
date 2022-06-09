using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ConstructorThisKeyword
    {
        int x = 10;
        public ConstructorThisKeyword()
        {
            Console.WriteLine("Hii i am default");

        }
       

        void read(int x)
        {
            this.x = x;
            this.show();
        }

        void show()
        {
            Console.WriteLine(x);
        }

        static void Main(String[] args)
        {
            ConstructorThisKeyword d = new ConstructorThisKeyword();
            d.read(500);





        }
    }
}
