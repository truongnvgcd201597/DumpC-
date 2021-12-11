using System;
using System.Collections.Generic;

namespace Asm1
{
    public class Student 
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Idcode { get; set; }
        public string ClassName { get; set; }
        public double Grade { get; set; }
        string users;
        public Student(string fullName, string gender, string idCode, string className, double grade)
        {
            this.FullName = fullName;
            this.Gender = gender;
            this.Idcode = idCode;
            this.Grade = grade;
        }

        public Student()
        {
        }

        public void Enter()
        {

                Console.Write("Please enter student name: ");
                FullName = Console.ReadLine().ToLower();
                Console.WriteLine("You just entered: {0}", FullName);
                Console.Write("Please enter studentID: ");
                Idcode = Console.ReadLine();
                Console.WriteLine("You just entered: {0}", Idcode.ToUpper());
                Console.Write("Please enter student grade: ");
                Grade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("You just entered: {0}", Grade);
               

        }
        public void Show()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Name: {0}   |    ID: {1}    |  Grade: {2}", FullName, Idcode, Grade);
            Console.WriteLine();
        }
        public void ViewChoose()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Please choose another one to excutable: ");
            Console.WriteLine("View grade ranking (low - high)");
            Console.WriteLine("View grade ranking (high - low)");
            Console.Write("Choose: ");
        }
        public void ViewTopStudentGrade()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Please choose another one to excutable: ");
            Console.WriteLine("View student with highest grade");
            Console.WriteLine("View student with lowest grade");
            Console.Write("Choose: ");
        }

    }
}
