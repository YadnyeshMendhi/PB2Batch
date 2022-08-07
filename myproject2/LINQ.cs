using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace myproject2
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
    }
    class TestClass
    {
        static void Main(string[] args)
        {
            List<Course> course = new List<Course>()
            {
                new Course{Id=101,Name="C#",Fees=2000 },
                  new Course{Id=102,Name="MVC", Fees=4000 },
                  new Course{Id=103,Name="SQL",Fees=6000 },
                  new Course{Id=104,Name="Core Java",Fees=8000 },
                  new Course{Id=105,Name="Ad Java",Fees=10000 },
             };

            //var result1=from c in coures
            //            select c;

            //LINQ Expression

            //select * from course where fees< 8000 orderby Name desc;
            var result2 = from c in course
                          where c.Fees < 8000
                          orderby c.Name descending
                          select c;

            var result3 = from c in course
                          where c.Name.StartsWith('C')
                          select c;
            foreach (Course c in result3)
            {
                Console.WriteLine($"{c.Id}  {c.Name} {c.Fees}");
            }
            Console.WriteLine(".................................................");
            foreach (Course c in result2)
            {
                Console.WriteLine($"{c.Id}  {c.Name} {c.Fees}");
            }

            Console.WriteLine(".............................");
            
            //using LABDA expression
            // =>  arrow operator  also called lambda expression

            var result4 = course.Where(x => x.Fees < 8000).OrderByDescending(y => y.Name).ToList();

            var result5 = course.Where(x => x.Id == 101).FirstOrDefault();

            //display course which have fees greater then 5000 sort by name using lambda expression
            var result6 = course.Where(X => X.Fees > 5000).OrderBy(y => y.Name).ToList();

            foreach (Course c in result6)
            {
                Console.WriteLine($"{c.Id}  {c.Name} {c.Fees}");
            }
        }
    }
}




