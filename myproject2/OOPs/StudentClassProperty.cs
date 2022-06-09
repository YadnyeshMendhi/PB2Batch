using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class StudentClassProperty
    {
        private int id;
        private String name;
        private double percentage;

        public int Id
        {
            get { return id;  }
            set { this.id = value;  }
        }
        public String Name
        {
            get { return name; }
            set { name  = value; }
        }
        public double Percentage
        {
            get { return percentage; }
            set { this.percentage = value; }
        }
        static void Main(String [] args)
        {
            StudentClassProperty e = new StudentClassProperty();
            e.Id = 1;
            e.Name = "Yadnyesh";
            e.percentage = 87;
            Console.WriteLine(e.Id);
            Console.WriteLine(e.Name);
            Console.WriteLine(e.Percentage);
        }



    }
}
