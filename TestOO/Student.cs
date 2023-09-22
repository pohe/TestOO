using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOO
{
    public class Student
    {

        //Instance fields - gemmes data sålænge objektet eksisterer
        private string _name;
        private int _age;
        private string _education;
        private string _phone;
        private int _semester;

        


        private const int basicPrintPrice = 300;

        //Property, bruges til at tilgå instance fields

        private static int _counter = 0;//Tilhører klassen, fælles for alle objekter
        private int _studentID;

        public int StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }


        public string Name
        {
            get { return _name; }
            set {              
                _name = value; 
            }
        }




        //Constructor - bruges til at skabe og initialisere et objekt
        //har ingen returtype
        public Student(string name, int age, string education, string phone, int semester)
        {
            _name = name;
            _age = age;
            _education = education;
            _phone = phone;
            _semester = semester;
            _counter++;
            _studentID = _counter;
        }


        //Methods

        public void PrintInfo()
        {
            Console.WriteLine($"Student navn {_name} alder {_age} uddannelse {_education} tel {_phone} semester {_semester}");
        }


        public override string ToString()
        {
            return $"Student navn {_name} alder {_age} uddannelse {_education} tel {_phone} semester {_semester}";
        }


        public double CostPrPrint()
        {
            return  _semester * basicPrintPrice;
        }

        public void NextSemester()
        {
            _semester++;
            //_semester= _semester + 1; 
        }
    }
}
