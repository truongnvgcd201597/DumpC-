using System;
using System.Collections.Generic;

namespace Asm1
{
     class Program
    {
        static void Main(string[] args)
        {
            Processing studentInfo = new Processing();
            int choose = 0 ;
            do
            {
                ShowMenu();
                choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        studentInfo.FieldBlank();
                        break;
                    case 2:
                        studentInfo.Show();
                        break;
                    case 3:
                        studentInfo.RankingList();
                        break;
                    case 4:
                        studentInfo.ViewTopStudent();
                        break;
                    case 5:
                        studentInfo.markAvg();
                        break;
                    case 6:
                        studentInfo.findByGrade();
                        break;
                    default:
                        Console.WriteLine("Invalid, please re-enter");
                        break;
                }
            } while (choose != 5);
            Console.ReadKey();
        }
       static void ShowMenu()
{
    Console.WriteLine("===== STUDENT MANAGEMENT SYSTEM =====\n");
    Console.WriteLine("1. \tEnter student information");
    Console.WriteLine("2. \tShow all student information");
    Console.WriteLine("3. \tShow statistics for all grades");
    Console.WriteLine("4. \tShow highest and lowest grades");
    Console.WriteLine("5. \tShow average grade");
    Console.WriteLine("6. \tFind student information by grade\n");
    Console.Write("Enter your choice (1-6): ");
}
    }
}
