using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee(002, "bob", 20);

            Employee secondEmployee = new Employee();
            Console.Write("Please input your first name: ");
            secondEmployee.FirstName = Console.ReadLine();
            Console.Write("Please input your last name: ");
            secondEmployee.LastName = Console.ReadLine();
            Console.Write("Please input your base salary: ");
            secondEmployee.BasicSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please input your gross sales: ");
            secondEmployee.GrossSales = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please input your commission rate: ");
            secondEmployee.CommissionRate = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Your employee commission is: {secondEmployee.Earnings():c2}");
        }
    }
}
