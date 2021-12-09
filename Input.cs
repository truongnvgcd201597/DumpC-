using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm1
{
    public class Input 
    {
        public string _FullName { get; set; }
        public int _Age { get; set; }
        public string _Address { get; set; }
        public string _Gender { get; set; }
        public string _Idcode { get; set; }
        public string _ClassName { get; set; }
        public string _Contact { get; set; }
        public double _Grade { get; set; }
        string users;
        public Input()
        {
            this._FullName = _FullName;
            this._Gender = _Gender;
            this._Idcode = _Idcode;
            this._Contact = _Contact;
            this._Grade = _Grade;
        }

        public void Enter()
        {

                Console.Write("Please enter student name: ");
                _FullName = Console.ReadLine();
                Console.WriteLine("You just entered: {0}", _FullName);
                Console.Write("Please enter studentID: ");
                _Idcode = Console.ReadLine();
                Console.WriteLine("You just entered: {0}", _Idcode);
                Console.Write("Please enter student grade: ");
                _Grade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("You just entered: {0}", _Grade);
               

        }
        public void Show()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Here is all information you just entered: \n" +
                "Name: {0}   |    ID: {1}    |  Grade: {2}", _FullName, _Idcode, _Grade);
            Console.WriteLine();
        }
        public void ViewChoose()
        {
            Console.WriteLine("View grade ranking (low - high)");
            Console.WriteLine("View grade ranking (high - low)");
        }
    }
}
