using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace myproject2.CSharpCollections
{
    public class Student : IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;

        }
    }
    public class compareStudent : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
    class TestStudent
    {
        static void Main(string[] args)
        {
            Student s1 = new Student { Sid = 103, Name = "Ajay", Class = 10, Marks = 575.00f };
            Student s2 = new Student { Sid = 106, Name = "Staurt", Class = 10, Marks = 412.00f };
            Student s3 = new Student { Sid = 102, Name = "Venkat", Class = 10, Marks = 570.00f };
            Student s4 = new Student { Sid = 105, Name = "Ajay", Class = 10, Marks = 410.00f };

            List<Student> Students = new List<Student>() { s1, s2, s3, s4 };
            Students.Sort();

            compareStudent obj = new compareStudent();
            Students.Sort();


            foreach (Student S in Students)
            {
                Console.WriteLine(S.Sid+" "+S.Name+" "+S.Class+" "+S.Marks);
            }

        }
    }
}
