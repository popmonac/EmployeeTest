using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Lawal", "Ayodeji", 5000.00M ); //Employee1 object

            Employee employee2 = new Employee("Japheth", "Khalid", 3000.00M); //Employee2 object

            //Displaying Employee1 informations
            Console.WriteLine ("Employee 1 = " + employee1.FirstName + " " + employee1.LastName);
            Console.WriteLine ("{0}", "Yearly salary is = " + employee1.YearlySalary() ) ;

            Console.WriteLine();
            //Displaying Employee2 informations
            Console.WriteLine("Employee 2 = " + employee2.FirstName + " " + employee2.LastName);
            Console.WriteLine("{0}", "Yearly salary is = " + employee2.YearlySalary());

            //Displaying the yearly salary after 10% raise
            Console.WriteLine();
            Console.WriteLine("Yearly salary review after 10% raise");
            Console.WriteLine();

            Console.WriteLine("MR " + employee1.FirstName + " " + employee1.LastName );
            Console.WriteLine("{0}\n", "Yearly salary is = " + employee1.YearlyRaise());

            Console.WriteLine();

            Console.WriteLine("MR " + employee2.FirstName + " " + employee2.LastName );
            Console.WriteLine("{0}\n", "Yearly salary is = " + employee2.YearlyRaise());


            Console.ReadLine();
        }
    }
}
