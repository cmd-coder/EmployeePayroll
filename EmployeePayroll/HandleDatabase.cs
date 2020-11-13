using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayroll
{
    class HandleDatabase
    {
        public static SqlConnection ConnectionSetUp()
        {
            return new SqlConnection(@"Data Source=DESKTOP-DKOUJ1R\SQLEXPRESS;Initial Catalog=payroll_service;Integrated Security=True");
        }
    }
}
