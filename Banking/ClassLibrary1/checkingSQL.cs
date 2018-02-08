using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace DALlayer
{
   public  class checkingSQL
    {
        public static DataTable GetTransaction(string accountID)
        {
            DataTable data = new DataTable();
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();
                string query = "select convert(varchar,cast(tranDate as Date),6) as Date,tranType as [Transaction], tranPlace as Description, " +
                    "Amount='$' +convert(varchar,tranAmount,1), Balance='$' +convert(varchar,Balance,1) from [transaction] where accountID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", accountID);
                data.Load(cmd.ExecuteReader());

                //SqlDataAdapter dr = new SqlDataAdapter(cmd);

               // dr.Fill(data);
                //cn.Close();
                return data;
            }
               
        }
        public static double GetBalance(string accountID)
        {
            double balance = 0;
            //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            { 
                cn.Open();
                string query = "select * from accountSummary where accountID=@accountID";
                 SqlCommand cmd = new SqlCommand(query, cn);
                 cmd.Parameters.AddWithValue("@accountID", accountID);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                    return Convert.ToDouble(dr[2]);
            }
            return balance;
        }
    }
}
