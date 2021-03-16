using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private decimal monthlySalary;

        //construct that initializes the above varible
        public Employee(string first, string last, decimal salary)
        {
            firstName = first;
            lastName = last;
            monthlySalary = salary;

        }

        //get and set properties for the FirstName
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        //get and set properties for the LastName
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        //get and set properties for the Salary
        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
             
                if (value >= 0)
                {
                    monthlySalary = value;
                  
                }

                else
                {
                    monthlySalary = 0;
                    
                }


            }
        }

        //method handling the yearly salary
        public decimal YearlySalary()
        {
            monthlySalary = monthlySalary * 12;
            return monthlySalary;
        
        }

        //method handling the yearly salary after 10% raise
        public decimal YearlyRaise()
        {

            monthlySalary =  monthlySalary + (monthlySalary * 0.1M);
            return monthlySalary;
        }
    }
}
