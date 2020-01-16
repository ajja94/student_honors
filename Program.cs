using System;

namespace Student_Gpa
{
    class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student("jim", "art", 3.6);
            student student2 = new student("kate", "business", 2.8);
            student student3 = new student("William", "computer sience", 3.9);
            student student4 = new student("jane", "helth", 1.9);
            student student5 = new student("kim", "sience", 4.0);
            student student6 = new student("paul", "music", 2.5);
            student student7 = new student("hans", "astro fysisc", 3.9);
            student student8 = new student("eric", "theater", 2.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.WriteLine(student3.HasHonors());
            Console.WriteLine(student4.HasHonors());
            Console.WriteLine(student5.HasHonors());
            Console.WriteLine(student6.HasHonors());
            Console.WriteLine(student7.HasHonors());
            Console.WriteLine(student8.HasHonors());


            Console.ReadLine();
        }
    }
}
