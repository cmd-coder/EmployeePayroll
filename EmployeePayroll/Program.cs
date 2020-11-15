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
            //Console.WriteLine("Employee joined between the date range");
            //HandleDatabase.JoinedInDateRange(Convert.ToDateTime("01/01/2000"), Convert.ToDateTime("01/01/2000"));

            //Use Case 6
            //Console.WriteLine("Grouping By Gender");
            //HandleDatabase.GroupByGender();

            //Use Case 7
            EmployeeDetails employeeDetails = new EmployeeDetails()
            {
                EmployeeID = 10,
                Name = "New Name",
                StartDate = Convert.ToDateTime("05/04/2020"),
                Gender = "F",
                Phone = "7889564512",
                SalaryID=109,
                Address="New Address"
            };
            CompanyData companyData = new CompanyData()
            {
                DepartmentID = 505,
                DepartmentName = "New Department"
            };
            Department department = new Department()
            { 
                DepartmentID=505,
                EmployeeID=10
            };
            PayrollDetails payrollDetails = new PayrollDetails()
            {
                SalaryID=109,
                BasicPay=7889,
                Deduction=78,
                IncomeTax=56,
                NetPay=7715,
                Taxable=156
            };
            HandleDatabase.AddAnEmployee(employeeDetails, companyData, department, payrollDetails);
        }
    }
}
