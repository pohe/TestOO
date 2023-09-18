using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestOO
{
    public class Car
    {
        //Instance fields
        private string _model;
        private string _regNo;

        //Properties
        public string Model
        {
            get { return _model; }
            
        }

        public string RegNo
        { 
            get { return _regNo; }
            set { _regNo = value; }
        }

        //Constructors
        public Car(string model, string regno)
        {
            _model = model;
            _regNo = regno;
        }

        public Car(string regNo)
        {
            _regNo=regNo;
            _model = "Unknown";
        }

        public Car()
        {
            _regNo = "Unknown";
            _model = "Unknown";
        }

        //Methods
        public void PrintInfo()
        {
            Console.WriteLine($"Bilens model {_model} registreringsnr {_regNo}");
        }
    }
}
