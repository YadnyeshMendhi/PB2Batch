using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.OOPs
{
    class PrivateAccessibiltyLevel
    {

        class parent
        {
            //private data member
           private  int value;

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
              //  Console.WriteLine("Value=" +value);
            }
        }
        static void Main(string[] args)
        {
            parent obj = new parent();
            obj.setvalue(10);
            int ans = obj.getvalue();
            Console.WriteLine("Value="+ans);
        }
    }
}
