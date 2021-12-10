using System;
using System.Collections.Generic;

namespace Asm1
{
     class Program
    {
        static void Main(string[] args)
        {
            Display studentInfo = new Display();
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
                        studentInfo.Highest();
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
            Console.WriteLine("1. Enter student information");
            Console.WriteLine("2. Show all student information");
            Console.WriteLine("3. Show highest grade");
            Console.Write("Your choose: ");
        }
    }
}
