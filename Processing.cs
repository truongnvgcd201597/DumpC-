using System;
using System.Collections.Generic;
using System.Linq;

namespace Asm1
{
    public class Processing : Student
    {
        public List<Student> inputsInfo = new List<Student>();
        public Processing()
        {

        }

        public void FieldBlank()
        {
            do
            {
                Student student = new Student();
                student.Enter();
                inputsInfo.Add(student);
                Console.WriteLine("Do you want to continue the program? (Y/N): ");
                string fieldBlank;
                fieldBlank = Console.ReadLine();
                Console.WriteLine("You just entered: {0}", fieldBlank);
                if (fieldBlank.ToUpper().Equals("N"))
                {
                    Show();
                    break;
                }
            } while (true);
        }
         public void Show()
        {
            foreach(var iterator in inputsInfo)
            {
                iterator.Show();
            }
        }
       
        public void RankingList()
        {
            int select = 0;
            do
            {
                ViewChoose();
                select = Int32.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Decrease();
                        break;
                    case 2:
                        Increase();
                        break;

                }
            } while (select != 2);
        }
        public void ViewTopStudent()
        {
            int select = 0;
           
                ViewTopStudentGrade();
                select = Int32.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        FindHighestGrade();
                        break;
                    case 2:
                        FindLowestGrade();
                        break;

                }
        }

        public void Decrease()
        {
            Console.WriteLine("Result: ");
            inputsInfo.Sort((x, y) => (int)(x.Grade - y.Grade));
            Show();
        }
        public void Increase()
        {
            Console.WriteLine("Result: ");
            inputsInfo.Sort((x, y) => (int)(y.Grade - x.Grade));
            Show();
        }
        public void FindHighestGrade()
        {
            Console.WriteLine("Result: ");
            var result = inputsInfo.OrderByDescending(student => student.Grade).ToList();
            foreach (var student in result)
            {
                if (student.Grade == result[0].Grade)
                {
                    student.Show();
                }
            }
        }
        public void FindLowestGrade()
        {
            Console.WriteLine("Result: ");
            var result = inputsInfo.OrderBy(student => student.Grade).ToList();
            foreach (var student in result)
            {
                if (student.Grade == result[0].Grade)
                {
                    student.Show();
                }
            }
        }
        public void markAvg()
        {
           Console.WriteLine("The average score of all students is: {0}", inputsInfo.Sum(x => x.Grade)/inputsInfo.Count);
        }
        public void findByGrade()
        {
            Console.Write("Please enter the student grade you want to find: ");
            double findGradeStudent = double.Parse(Console.ReadLine());
            
        }

    }
}
