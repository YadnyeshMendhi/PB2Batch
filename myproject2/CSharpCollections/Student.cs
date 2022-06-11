using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.CSharpCollections
{
    class Student
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(29);
            list.Add(56);
            list.Add(45);
            list.Add(36);

            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
