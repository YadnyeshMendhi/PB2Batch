using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
     class Property1
     {
        private int id;
        private String name;
        private String address;
        private int pincode;
        private String cityname;
        private String statename;

        public int Id
        {
            get { return id; }
            set { this.id = value; }

        }
        public String Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public String Address
        {
            get { return address; }
            set { this.address = value; }

        }
        public int Pincode
        {
            get { return pincode; }
            set { this.pincode = value; }
        }
        public String Cityname
        {
            get { return cityname; }
            set { this.cityname = value; }
        }
        public String Statename
        {
            get { return statename; }
            set { this.statename = value; }
        }

        static void Main(String [] args)
        {
            Property1 p = new Property1();
            p.id = 101;
            p.name = "Amit";
            p.address = "gopal nagar";
            p.pincode = 440022;
            p.cityname = "Nagpur";
            p.statename = "Maharashtra";
            Console.WriteLine(p.Id);
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Address);
            Console.WriteLine(p.Pincode);
            Console.WriteLine(p.Cityname);
            Console.WriteLine(p.Statename);
        }


     }
}
