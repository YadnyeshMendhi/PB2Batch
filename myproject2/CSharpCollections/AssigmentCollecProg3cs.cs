using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
{


    class order
    {
        int orderid;
        string custname;
        string city;
        ArrayList items;

        public order(int orderid, string custname, string city, ArrayList items)
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
    class AssigmentCollecProg3cs
    {
        static void Main(string[] args)
        {
            // crate a Arraylist of 5 orders in which data will be accepted dynamically.


            ArrayList orderlist = new ArrayList();

            for(int i = 1; i<=5; i++)
            {
                Console.WriteLine("enter orderid , custname , city");
                int id = int.Parse(Console.ReadLine());
                string nm = (Console.ReadLine());
                string city = Console.ReadLine();
                Console.WriteLine("enter how many items u want to order");
                int c = int.Parse(Console.ReadLine());
                ArrayList itemlist = new ArrayList();

                for(int j=1; j <= c; j++)
                {
                    Console.WriteLine("Add {j} item in ur order");
                    string item = Console.ReadLine();
                    itemlist.Add(item);
                }
                orderlist.Add(new order(id, nm, city, itemlist));
               

            }
        }
    }
}
