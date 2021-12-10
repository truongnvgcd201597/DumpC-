using System;
using System.Collections.Generic;
using System.Linq;

namespace Asm1
{
    public class Display
    {
        public List<Input> inputsInfo = new List<Input>();
        public Display()
        {

        }

        public void FieldBlank()
        {
            do
            {
                Input student = new Input();
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
            foreach(var meta in inputsInfo)
            {
                meta.Show();
            }
        }

        public void RankingList()
        {
            int select = 0;
            do
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Please choose another one to excutable: ");
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
        
        public void Decrease()
        {
            Console.WriteLine("Result: ");
            inputsInfo.Sort((x, y) => (int)(x._Grade - y._Grade));
            Show();
        }
        public void Increase()
        {
            Console.WriteLine("Result: ");
            inputsInfo.Sort((x, y) => (int)(y._Grade - x._Grade));
            Show();
        }
        public void Highest()
        {
            Console.WriteLine("Result: ");
            var result = inputsInfo.OrderByDescending(student => student._Grade).ToList();
            foreach(var student in result)
            {
                if(student._Grade == result[0]._Grade)
                {
                    student.Show();
                }
            }
        }
    }
}
