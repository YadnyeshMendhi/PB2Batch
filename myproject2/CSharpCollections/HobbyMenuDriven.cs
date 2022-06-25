using System;
using System.Collections;
using System.Text;

namespace myproject2.CSharpCollections
{
    class person
    {
        string Name;
        ArrayList Hobbies;
        public person(string name, ArrayList hobbies)
        {
            this.Name = name;
            this.Hobbies1 = hobbies;

        }

        public string Name1 { get => this.Name; set => this.Name = value; }
        public ArrayList Hobbies1 { get => Hobbies; set => Hobbies = value; }
    }

    class HobbyMenuDriven
    { 
        static void Main(string[] args)
        {
            ArrayList plist = new ArrayList();

            do
            {
                Console.WriteLine("Enter a name");
                string nm = Console.ReadLine();
                Console.WriteLine("Enter number of hobbies you have");
                int c = int.Parse(Console.ReadLine());
                ArrayList hobbieslist = new ArrayList();
                for (int i = 1; i <= c; i++)
                {
                    Console.WriteLine($" {nm} enter your hobby");
                    string h = Console.ReadLine();
                    hobbieslist.Add(h);
                
                }
                person p = new person(nm, hobbieslist);
                plist.Add(p);

                Console.WriteLine("Do you want add one more person object yes/no");
                string choice = Console.ReadLine().ToLower();


                //break
                if (choice == "no")
                    break;



            } while (true);//Loop runs infifnite times
        }
    }
}
