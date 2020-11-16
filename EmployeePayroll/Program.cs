using System;

namespace EmployeePayroll
{
    class Program
    {
        /// <summary>
        /// The main function is written to Implement Employee Payroll Diagram
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Service.");
            ImplementEmployeePayroll();
        }

        /// <summary>
        /// The function is written to take user input and perform the corresponding action
        /// </summary>
        public static void ImplementEmployeePayroll()
        {
            Console.WriteLine("Enter 1 to see all the data in the database" +
                "\n2 to Update the basic pay of an employee" +
                "\n3 to see the employees joine between the data range" +
                "\n4 to see data grouped by gender" +
                "\n5 to add an employee" +
                "\n6 to remove an employee from the database" +
                "\n7 to exit.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    HandleDatabase.RetrieveFromDataBase();
                    break;
                case 2:
                    Console.WriteLine("Enter the name and the updated basic pay of the employee");
                    string name = Console.ReadLine();
                    int newBasicPay = Convert.ToInt32(Console.ReadLine());
                    HandleDatabase.UpdateDataBase(name, newBasicPay);
                    break;
                case 3:
                    Console.WriteLine("Employee joined between the date range 01/01/2000 and 01/01/2000");
                    HandleDatabase.JoinedInDateRange(Convert.ToDateTime("01/01/2000"), Convert.ToDateTime("01/01/2000"));
                    break;
                case 4:
                    Console.WriteLine("Grouping By Gender");
                    HandleDatabase.GroupByGender();
                    break;
                case 5:
                    EmployeeDetails employeeDetails = new EmployeeDetails()
                    {
                        EmployeeID = 20,
                        Name = "New Name 20",
                        StartDate = Convert.ToDateTime("06/04/2020"),
                        Gender = "F",
                        Phone = "7889564512",
                        SalaryID = 120,
                        Address = "New Address",
                        IsActive = 0
                    };
                    CompanyData companyData = new CompanyData()
                    {
                        DepartmentID = 515,
                        DepartmentName = "New Department"
                    };
                    Department department = new Department()
                    {
                        DepartmentID = 515,
                        EmployeeID = 20
                    };
                    int basicPay = 7900;
                    PayrollDetails payrollDetails = new PayrollDetails()
                    {
                        SalaryID = 120,
                        BasicPay = basicPay,
                        Deduction = (int)(basicPay * .2),
                        IncomeTax = (int)((basicPay - (int)(basicPay * .2)) * .1),
                        NetPay = (int)(basicPay - (int)((basicPay - (int)(basicPay * .2)) * .1)),
                        Taxable = basicPay - (int)(basicPay * .2)
                    };
                    HandleDatabase.AddAnEmployee(employeeDetails, companyData, department, payrollDetails);
                    break;
                case 6:
                    Console.WriteLine("Enter the employee id of the employee to be remmoved");
                    int empid = Convert.ToInt32(Console.ReadLine());
                    HandleDatabase.RemoveFromDataBase(empid);
                    break;
            }
        }
    }
}
