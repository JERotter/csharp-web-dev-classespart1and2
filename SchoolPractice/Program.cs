using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student newStudent1 = new Student("Jenell", 2343, 77, 4.0 );//need get/set thing
            Console.WriteLine(newStudent1.Name);
            Console.WriteLine(newStudent1.GetGradeLevel());

        }
    }
}
