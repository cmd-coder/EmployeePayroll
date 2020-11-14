using System;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Service.");
            HandleDatabase.RetrieveFromDataBase();
            Console.WriteLine("Enter the name and the updated basic pay of the employee");
            string name = Console.ReadLine();
            int newBasicPay = Convert.ToInt32(Console.ReadLine());
            HandleDatabase.UpdateDataBase(name, newBasicPay);
        }
    }
}
