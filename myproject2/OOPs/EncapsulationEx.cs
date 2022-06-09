using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{ 
    class EncapsulationEx
    {

      
        private String studentname;
        private int studentid;

        public String Name
        {
            set { studentname = value; }
            get { return studentname; }

        }
        public int Id
        {
            set { studentid = value; }
            get { return studentid; }

        }

        static void Main(String [] args)
        {
            EncapsulationEx en = new EncapsulationEx();

            en.Name = "Ankita";
            en.Id = 101;
            Console.WriteLine(en.Name);
            Console.WriteLine(en.Id);
        } 






    }
}
