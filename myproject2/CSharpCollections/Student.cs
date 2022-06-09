using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MyProject1.CSharpCollections
{
    /*class Student:IComparable<Student>
    {
        int sid;
        string nm;
        int percentage;

        public Student(int sid, string nm, int percentage)
        {
            this.Sid = sid;
            this.Nm = nm;
            this.Percentage = percentage;
        }

        public int Sid { get => sid; set => sid = value; }
        public string Nm { get => nm; set => nm = value; }
        public int Percentage { get => percentage; set => percentage = value; }

        public int ComapreTo(Student other)
        {
            if (this.percentage > other.percentage)
                return 1;
            else if (this.percentage < other.percentage)
                return -1;
            else
                return 0;

        }
        public override bool Equals(object obj)
        {
            Student stud = (Student)obj;
            return sid == stud.sid && nm == stud.nm;
        }

        static void Main(string[] args)
        {
            SortedList<Student, string> ss = new SortedList<Student, string>();
            ss.Add(new Student(1, "Uddhav", 93), "Java");
            ss.Add(new Student(2, "Yogesh", 94), "python");
            ss.Add(new Student(3, "Amey", 84), "PHP");
            ss.Add(new Student(4, "kunal", 91), "java");

            foreach (KeyValuePair<Student, string> k in ss)
            {
                Console.WriteLine(k.Key + "--->" + k.Value);
            }

        }






    }*/
}
