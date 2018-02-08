using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace DalLayer
{
    public class EmployeeSqlHelper

    {
        static SqlConnection cn = null;
        static string cs = ConfigurationManager.ConnectionStrings["dbKarna"].ConnectionString;
        
        //For display
        public static DataTable EmployeeData()
        {

            using (cn = new SqlConnection(cs))
            {
                cn.Open();
                string query = "select * from tblEmployee";
                SqlCommand cmd = new SqlCommand(query, cn);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;

            }

        }

        //For Input
        public static void AddEmployee( string name, string gender, string city, int departmentId) {

            using (cn = new SqlConnection(cs))
            {
                cn.Open();
                string query = "insert into tblEmployee values(@Name,@Gender,@City,@Department_ID)";
                SqlCommand cmd = new SqlCommand(query, cn);
               
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Department_ID", departmentId);
                cmd.ExecuteNonQuery();

            }


        }
        // For Edit
        public static void EditEmployee(int id, string name, string gender, string city, int departmentId)
        {
            using (cn = new SqlConnection(cs))
            {
                cn.Open();
                string query = "update [tblEmployee] set Name=@Name, Gender=@Gender,City=@City," +
                    "Department_ID=@Department_ID where id=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Department_ID", departmentId);
                cmd.ExecuteNonQuery();

            }


        }
        // For delete
        public static void DeleteEmployee(int id)
        {
            using (cn = new SqlConnection(cs))
            {
                cn.Open();
                string query = "delete from [tblEmployee] where id=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

            }


        }




    }
}
