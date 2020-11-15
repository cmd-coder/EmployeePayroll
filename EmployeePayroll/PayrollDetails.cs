using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll
{
    public class PayrollDetails
    {
        public int SalaryID { get; set; }

        public int BasicPay { get; set; }

        public int Deduction { get; set; }

        public int Taxable { get; set; }

        public int IncomeTax { get; set; }

        public int NetPay { get; set; }
    }
}
