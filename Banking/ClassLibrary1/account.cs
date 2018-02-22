using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DALlayer
{
    public class account
    {

        public static void createAccounts(string accountID, string accountType, double moneyBalance, string preparer, DateTime date, string custID)
        {

            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();
                string query = "insert into accounts values(@accountID,@accountType,@moneyBalance,@preparer,@date,@custID)";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@accountID", accountID);
                cmd.Parameters.AddWithValue("@accountType", accountType);
                cmd.Parameters.AddWithValue("@moneyBalance", moneyBalance);
                cmd.Parameters.AddWithValue("@preparer",preparer);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@custID", custID);

                cmd.ExecuteNonQuery();
            }
        }
        public static string CheckingAccountID(string custID)
        {
            
            //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();
                string query = "select accountID from accounts where AccountType='Checking' and custID=@custID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@custID", custID);
                string data = cmd.ExecuteScalar().ToString();
                return data;
            }

        }

        public static string SavingAccountID(string custID)
        {

            //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();
                string query = "select accountID from accounts where AccountType='Saving' and custID=@custID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@custID", custID);
                string data = cmd.ExecuteScalar().ToString();
                return data;
            }

        }

        public static string CreditAccountID(string custID)
        {

            //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();
                string query = "select accountID from accounts where AccountType='Credit'and custID=@custID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@custID", custID);
                string data = cmd.ExecuteScalar().ToString();
                return data;
            }

        }
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
        public static void FirstDeposit(string accountID,string custID, double balance, string accountType)        //for account summary table
        {
            //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            try
            {
                SqlConnection cn = new SqlConnection(cs);
                cn.Open(); //Insert into tablename values(@id, @name, @address)";  
                string query = "insert into [accountSummary] values(@accountID,@custID,@balance,@accountType )";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@accountID", accountID);
                cmd.Parameters.AddWithValue("@custID", custID);
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
