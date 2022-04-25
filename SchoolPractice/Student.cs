using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {

        private static int nextStudentId = 1;
        public string Name { get; set; } //Capital letter get/set; autoimplement here//
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }
        public string levelOfSchool;

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {//this. only used with vars local to a method//
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public string GetGradeLevel()
        {
            if(NumberOfCredits > 0 && NumberOfCredits < 30)
            {
                levelOfSchool = "Freshman";
            }
            else if (NumberOfCredits > 29 && NumberOfCredits < 60)
            {
                levelOfSchool = "Sophomore";
            }
            else if (NumberOfCredits > 60  && NumberOfCredits < 90)
            {
                levelOfSchool = "Junior";
            }
            else if (NumberOfCredits > 90)
            {
                levelOfSchool = "Senior";
            }
            return levelOfSchool;
            
        }
    }
}