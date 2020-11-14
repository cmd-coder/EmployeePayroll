using EmployeePayroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeePayrollUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUpdateDatabaseOfHandleDatabaseClassPassNameAndNewBasicPayAndGetUpdatedBasicPay()
        {
            int actualBasiccPay=HandleDatabase.UpdateDataBase("Name2", 1223);
            Assert.AreEqual(1223, actualBasiccPay);
        }
    }
}
