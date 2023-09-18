using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOO
{
    public class Human
    {
        //instance fields
        private double _height;
        private double _weight;
        private string _name;

        //properties
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public double BMI
        {
            get
            {
                return _weight / Math.Pow(_height, 2); //(_height * _height);
            }
        }

        public Human(string name, double height, double weight)
        {
            _name = name;
            _height = height;
            _weight = weight;
        }

    }
}
