using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Employee
    {
        private int employeeUserId;
        private string firstName;
        private string lastName;
        private double basicSalary;
        private double grossSales;
        private double commissionRate;

        public int EmployeeUserId { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BasicSalary { get; set; }
        public double GrossSales { get; set; }
        public double CommissionRate { get; set; }

        public Employee() {
            this.CommissionRate = 0.2;
            this.basicSalary = 2000.0;
        }

        public Employee(int employeeUserId, string firstName, double basicSalary) { }

        public double Earnings()
        {
                if (GrossSales <= 0)
                {
                    Console.Write("Your gross sales should be higher than zero. Please try again: ");
                    GrossSales = Convert.ToDouble(Console.ReadLine());
                    Earnings();
                }
                else if (CommissionRate < 0.1 || CommissionRate > 1.0)
                {
                    Console.Write("Your commission rate should be between 0.1 and 1.0. Please try again: ");
                    CommissionRate = Convert.ToDouble(Console.ReadLine());     
                    Earnings();
                }
            double EmployeeComission = CommissionRate * GrossSales + BasicSalary; 
            return EmployeeComission;
        }
    }
}
