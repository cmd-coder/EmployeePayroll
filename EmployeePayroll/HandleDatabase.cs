﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayroll
{
    public class HandleDatabase
    {
        public static SqlConnection ConnectionSetUp()
        {
            return new SqlConnection(@"Data Source=DESKTOP-DKOUJ1R\SQLEXPRESS;Initial Catalog=payroll_service;Integrated Security=True");
        }

        public static void RetrieveFromDataBase()
        {
            SqlConnection sqlConnection = ConnectionSetUp();
            try
            {
                using (sqlConnection)
                {
                    string query = "select e.name, e.start_date, e.gender, e.phone, e.address ," +
                        " c.department_name, p.basic_pay, p.deduction, p.taxable, p.income_tax, " +
                        "p.net_pay from employee_details e inner join payroll_details p on p.salid=e.salid" +
                        " inner join department d on d.empid=e.empid inner join company c on d.department_id=c.department_id;";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        System.Console.WriteLine("Name -- Start Date -- Gender -- Phone -- Address -- Department Name -- Basic Pay -- Deduction -- Taxable Pay -- Income Tax -- Net Pay");
                        while (dr.Read())
                        {
                            Console.WriteLine(dr.GetString(0)+" -- "+ dr.GetDateTime(1) + " -- " + dr.GetString(2) + " -- " + dr.GetString(3) + " -- " + dr.GetString(4) + " -- " + dr.GetString(5) + " -- " + dr.GetInt32(6) + " -- " + dr.GetInt32(7) + " -- " + dr.GetInt32(8) + " -- " + dr.GetInt32(9) + " -- " + dr.GetInt32(10));
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");
                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        public static int UpdateDataBase(string name, int newBasicPay)
        {
            SqlConnection sqlConnection = ConnectionSetUp();
            int returnBasicPay = 0;
            try
            {
                using (sqlConnection)
                {
                    string query = "update payroll_details set payroll_details.basic_pay = "+newBasicPay+" from payroll_details p inner join employee_details e on e.salid=p.salid where e.name='"+name+"';";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    string queryCheck = "select e.name, e.start_date, e.gender, e.phone, e.address ," +
                        " c.department_name, p.basic_pay, p.deduction, p.taxable, p.income_tax, " +
                        "p.net_pay from employee_details e inner join payroll_details p on p.salid=e.salid" +
                        " inner join department d on d.empid=e.empid inner join company c on d.department_id=c.department_id where e.name='"+name+"';";
                    cmd = new SqlCommand(queryCheck, sqlConnection);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        System.Console.WriteLine("Name -- Start Date -- Gender -- Phone -- Address -- Department Name -- Basic Pay -- Deduction -- Taxable Pay -- Income Tax -- Net Pay");
                        while (dr.Read())
                        {
                            //returnBasicPay = dr.GetInt32(5);
                            Console.WriteLine(dr.GetString(0) + " -- " + dr.GetDateTime(1) + " -- " + dr.GetString(2) + " -- " + dr.GetString(3) + " -- " + dr.GetString(4) + " -- " + dr.GetString(5) + " -- " + (returnBasicPay = dr.GetInt32(6)) + " -- " + dr.GetInt32(7) + " -- " + dr.GetInt32(8) + " -- " + dr.GetInt32(9) + " -- " + dr.GetInt32(10));
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");
                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            return returnBasicPay;
        }

        public static int JoinedInDateRange(DateTime startDate, DateTime endDate)
        {
            int count = 0;
            SqlConnection sqlConnection = ConnectionSetUp();
            try
            {
                using (sqlConnection)
                {
                    string query = "select e.name, e.start_date, e.gender, e.phone, e.address ," +
                        " c.department_name, p.basic_pay, p.deduction, p.taxable, p.income_tax, " +
                        "p.net_pay from employee_details e inner join payroll_details p on p.salid=e.salid" +
                        " inner join department d on d.empid=e.empid inner join company c on d.department_id=c.department_id where e.start_date>='"+startDate+"' and e.start_date<='"+endDate+"';";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        System.Console.WriteLine("Name -- Start Date -- Gender -- Phone -- Address -- Department Name -- Basic Pay -- Deduction -- Taxable Pay -- Income Tax -- Net Pay");
                        while (dr.Read())
                        {
                            count++;
                            Console.WriteLine(dr.GetString(0) + " -- " + dr.GetDateTime(1) + " -- " + dr.GetString(2) + " -- " + dr.GetString(3) + " -- " + dr.GetString(4) + " -- " + dr.GetString(5) + " -- " + dr.GetInt32(6) + " -- " + dr.GetInt32(7) + " -- " + dr.GetInt32(8) + " -- " + dr.GetInt32(9) + " -- " + dr.GetInt32(10));
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");
                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            return count;
        }
    }
}
