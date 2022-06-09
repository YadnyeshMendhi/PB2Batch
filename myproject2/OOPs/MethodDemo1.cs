using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class MethodDemo1
    {

        static string Trainername;


        public void show_Data()//method defination
        {
            Console.WriteLine("hii i am show"); //method body
        }
        public void addition(int a, int b)
        {
            Console.WriteLine("Addition = " + (a + b));
        }
        public String myfoo()
        {

            return "hello";
        }
        public int add()
        {
            return 10 + 30;
        }
        public float areaOfCircle(int r, float PI)
        {
            float area = PI * r * r;
            return area;
        }
        static void setTrainername(string tvm)
        {
            Trainername = tvm;
        }


        static void Main(string[] args)
        {
            MethodDemo1 m = new MethodDemo1();
            m.show_Data();
            m.addition(7, 5);

            Console.WriteLine(m.myfoo());
            int ans = m.add();
            Console.WriteLine(ans);

            float a = m.areaOfCircle(4 , 3.14f);

            Console.WriteLine("Area of circle = "+a);

            Console.WriteLine(MethodDemo1.Trainername);
            MethodDemo1.setTrainername("deepa");
        }
    }
}

