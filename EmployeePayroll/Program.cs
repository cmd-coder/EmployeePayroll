using System;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Service.");
            HandleDatabase.RetrieveFromDataBase();
            //Use Case  3
            //Console.WriteLine("Enter the name and the updated basic pay of the employee");
            //string name = Console.ReadLine();
            //int newBasicPay = Convert.ToInt32(Console.ReadLine());
            //HandleDatabase.UpdateDataBase(name, newBasicPay);

            //Use Case 5
            Console.WriteLine("Employee joined between the date range");
            HandleDatabase.JoinedInDateRange(Convert.ToDateTime("01/01/2000"), Convert.ToDateTime("01/01/2000"));
        }
    }
}
