using System;

namespace Asm1
{
    class Program
    {
        static void Main(string[] args)
        {
            Processing studentInfo = new Processing();
            int choose = 0;
            do
            {
                ShowMenu();
                int.TryParse(Console.ReadLine(), out choose);
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
                        Console.WriteLine("Invalid option, please choose again.\n");
                        break;
                }
            } while (choose != 7);
            Console.WriteLine("Thank you for using our Student Management System.");
            Console.ReadKey();
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("       STUDENT MANAGEMENT SYSTEM");
            Console.WriteLine("=================================\n");
            Console.WriteLine("1. Enter student information");
            Console.WriteLine("2. Show all student information");
            Console.WriteLine("3. Show statistics for all grades");
            Console.WriteLine("4. Show highest and lowest grades");
            Console.WriteLine("5. Show average grade");
            Console.WriteLine("6. Find student information by grade");
            Console.WriteLine("7. Exit\n");
            Console.Write("Please enter your choice (1-7): ");
        }
    }
}
