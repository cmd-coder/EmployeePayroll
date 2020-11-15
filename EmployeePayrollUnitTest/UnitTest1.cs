using EmployeePayroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EmployeePayrollUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUpdateDatabaseOfHandleDatabaseClassPassNameAndNewBasicPayAndGetUpdatedBasicPay()
        {
            int actualBasiccPay = HandleDatabase.UpdateDataBase("Name2", 1223);
            Assert.AreEqual(1223, actualBasiccPay);
        }

        [TestMethod]
        public void TestAddIntoDatabaseOfHandleDatabseClassPassEmployeeDetailsObejctsAndGetTheNumberOfRowsAffected()
        {
            EmployeeDetails employeeDetails = new EmployeeDetails()
            {
                EmployeeID = 12,
                Name = "New Name",
                StartDate = Convert.ToDateTime("05/04/2020"),
                Gender = "F",
                Phone = "7889564512",
                SalaryID = 115,
                Address = "New Address"
            };
            CompanyData companyData = new CompanyData()
            {
                DepartmentID = 510,
                DepartmentName = "New Department 5"
            };
            Department department = new Department()
            {
                DepartmentID = 510,
                EmployeeID = 12
            };
            PayrollDetails payrollDetails = new PayrollDetails()
            {
                SalaryID = 115,
                BasicPay = 7889,
                Deduction = 78,
                IncomeTax = 56,
                NetPay = 7715,
                Taxable = 156
            };
            int actual = HandleDatabase.AddAnEmployee(employeeDetails, companyData, department, payrollDetails);

            Assert.AreEqual(4, actual);
        }
    }
}
