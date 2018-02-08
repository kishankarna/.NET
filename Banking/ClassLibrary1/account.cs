using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DALlayer
{
    public class account
    {
        public static double GetBalance(string accountID)
        {
            double balance = 0 ;
            //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            { 
                cn.Open();
                string query = "select * from accountSummary where accountID=@accountID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@accountID", accountID);
                SqlDataReader dr= cmd.ExecuteReader();
                if(dr.Read())
                    return Convert.ToDouble(dr[2]);
            }
            return balance;
        }
        public static void FirstDeposit(string accountID,string name, double balance, string accountType)        //for account summary table
        {
            //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            try
            {
                SqlConnection cn = new SqlConnection(cs);
                cn.Open(); //Insert into tablename values(@id, @name, @address)";  
                string query = "insert into [accountSummary] values(@accountID,@name,@balance,@accountType )";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@accountID", accountID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@balance", balance);
                cmd.Parameters.AddWithValue("@accountType", accountType);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        public static void Deposit(string accountID, double balance)        //for account summary table
        {
            //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            try
            {
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();               
                string query = "update [accountSummary] set balance=@balance where accountID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);            
                cmd.Parameters.AddWithValue("@balance", balance);
                cmd.Parameters.AddWithValue("@id", accountID);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

    }
}
