using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalLab12_11_22
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        private string _designation { get; set; }

        public string Designation
        {
            get
            {
                return _designation;
            }
            set
            {
                if (value == "Trainee")
                {
                    salary = 5000;
                    _designation = value;

                }
                else if (value == "Manager")
                {
                    salary = 200000;
                    _designation = value;

                }
                else if (value == "Senior Developer")
                {
                    salary = 100000;
                    _designation = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }
        }
        private int salary { get; set; }


        public int Salary { get { return salary; } set { salary = value; } }

        public void Getdata()
        {
            Console.WriteLine("Enter the Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Department");
            Department = Console.ReadLine();
            Console.WriteLine("Enter the Designation");
            Designation = Console.ReadLine();
        }
    }
}

