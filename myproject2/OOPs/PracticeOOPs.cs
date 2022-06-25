using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.OOPs
{
    /* public class student
     {
         public int rollno;
         public string name;

         public student(int r, string n)
         {
             rollno = r;
             name = n;

         }
         public int getRollno()
         {
             return rollno;
         }
         public string getName()
         {
             return name;
         }

     }
     public class PracticeOOPs
     {
         static void Main(string[] args)
         {
             student s = new student(101, "Reginold");
             Console.WriteLine("RollNo=" + s.rollno);
             Console.WriteLine("name" + s.name);

             Console.WriteLine();

             Console.WriteLine("Roll no=" + s.getRollno());
             Console.WriteLine("name=" + s.getName());



         }
     }*/
    /*
        class X
        {
            // protected data member
             protected int  p;


            public X()
            {
                p = 10;

            }
        }
        class y : X
        { 
            public int getX()
            { 
                return p;
            }


        }
        class PracticeOOPs
        {
            static void Main(string[] args)
            {
                X obj = new X();
                y obj2 = new y();

                Console.WriteLine(obj2.getX());


            }

        }*/

    /*  internal class complex
      {

          public int real;
          public int img;


          public void setdata(int r , int i)
          {
              real = r;
              img = i;
          }
          public void displaydata()
          {
              Console.WriteLine(real);
              Console.WriteLine(img);

          } 
      }
      class PracticeOOPs
      {
          static void Main(string[] args)
          {
              complex c = new complex();
              c.setdata(10, 20);
              c.displaydata();

          }
      }*/

    /* class parent
     { 

         private int value;


         public void setvalue(int v)
         {
             value = v;
         }
         public int getvalue()
         {
             return value;

         }

     }
     class child : parent
     {

         public void showvalue()
         {
            // Console.WriteLine("Value="+value);

         }
     }
     class PracticeOOPs
     {
         static void Main(string[] args)
         {
             child c = new child();

             c.setvalue(3);
             c.getvalue();
             Console.WriteLine(c.getvalue());
         }*/
    /*
        public abstract class animal
        {
            //abstract method

            public abstract void animalsound();

            public void sleep()
            {
                Console.WriteLine("Zzzzz");

            }
        }
        public class pig : animal
        {
            public override void animalsound()
            {
                Console.WriteLine("Pig says:wee wee");
            }


        }
        class PracticeOOPs
        {
            static void Main(string[] args)
            {
                pig obj = new pig();
                obj.sleep();
                obj.animalsound();
            }


        }*/


    interface Iwish
    {
       void greet(string msg);
    
    }
    interface Imaths
    {
        void add(int a, int b);
        int divide(int x, int y);

    }
    class myinterfaces:Imaths,Iwish
    {
        public void greet(string msg)
        {
            Console.WriteLine("Good Morning");
        }
        public void add(int a, int b)
        {
            Console.WriteLine("Addition="+(a+b));
        
        }
        public int divide(int x, int y)
        {
            int r = (x / y);
            return r;
        }
    
    }
    class PracticeOOPs
    {
        static void Main(string[] args)
        {
            Imaths m = new myinterfaces();
            m.add(20, 30);
            int ans = m.divide(2,10);
            Console.WriteLine(ans);

        }
    
    
    }





}



