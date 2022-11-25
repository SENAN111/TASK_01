using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Models
{
    internal class Employee
    {
        public string _name;
        public bool _isuccesful;
        public double _salary;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Trim().Length > 3 && value.Trim().Length < 30)
                {
                    _name = value.Trim();
                }
            }
        }
        public bool Isuccesful
        {
            get { return _isuccesful; }
            set
            {
                if(value=true)
                {
                    
                }
                else
                {
                    Console.WriteLine("unsuccesful employee")
                }
            }
        }
        

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value > 300)
                {
                    _salary = value;
                }
            }
        }
}    }

