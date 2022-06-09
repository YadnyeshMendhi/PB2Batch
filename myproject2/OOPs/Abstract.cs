using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{

    public abstract class GeeksForGeeks
    {

        // abstract method 'gfg()'
        public abstract void gfg();

    }

    // class 'GeeksForGeeks' inherit
    // in child class 'Geek1'
    public class Geek1 : GeeksForGeeks
    {

        // abstract method 'gfg()'
        // declare here with
        // 'override' keyword
        public override void gfg()
        {
            Console.WriteLine("class Geek1");
        }
    }

    // class 'GeeksForGeeks' inherit in
    // another child class 'Geek2'
    public class Geek2 : GeeksForGeeks
    {

        // same as the previous class
        public override void gfg()
        {
            Console.WriteLine("class Geek2");
        }
    }

    // Driver Class
    public class Abstract
    {

        // Main Method
        public static void Main(String[] args)
        {

            // 'g' is object of class
            // 'GeeksForGeeks' class '
            // GeeksForGeeks' cannot
            // be instantiate
            GeeksForGeeks g;

            // instantiate class 'Geek1'
            g = new Geek1();

            // call 'gfg()' of class 'Geek1'
            g.gfg();

            // instantiate class 'Geek2' 
            g = new Geek2();

            // call 'gfg()' of class 'Geek2'
            g.gfg();

        }
    }
 }

