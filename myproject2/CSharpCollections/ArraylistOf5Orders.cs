using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
{

    class constructor0
    {
        int orderid;
        string custname;
        string city;
        ArrayList items;

        public constructor0(int orderid, string custname, string city, ArrayList items)
        {
            this.Orderid = orderid;
            this.Custname = custname;
            this.City = city;
            this.Items = items;
        }

        public int Orderid { get => orderid; set => orderid = value; }
        public string Custname { get => custname; set => custname = value; }
        public string City { get => city; set => city = value; }
        public ArrayList Items { get => items; set => items = value; }
    }

    class ArraylistOf5Orders
    {

        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("enter orderid , custname , city");
                int id = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                string city = Console.ReadLine();
                Console.WriteLine("how many items you want to order");
                int c = int.Parse(Console.ReadLine());

                ArrayList list2 = new ArrayList();
                for (int j = 1; j <= c; j++)
                {
                    Console.WriteLine("Add {j} item in your order");
                    string item = Console.ReadLine();
                    list2.Add(item);
                }
                list.Add(new constructor0(id, name, city, list2));
            }

            // hardCode
           /* ArrayList list1 = new ArrayList();
            list1.Add("Watch");
            list1.Add("Earphones");
            list1.Add("Powerbank");
            constructor0 c = new constructor0(101, "yadnyesh", "Nagpur", list1);
            ArrayList list2 = new ArrayList();
            list2.Add("watch");
            list2.Add("Iphone");
            list2.Add("Laptop");
            constructor0 c1 = new constructor0(102, "Yash", "Pune", list2);*/
        }
    }
}
