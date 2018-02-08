using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace DALlayer
{
    public class CRUD_Operation
    {
        public static void Deposit(DateTime tranDate, string tranUserID, string tranType, double tranAmount, string usrType,string tranPlace,string accountID,double balance)
        {
            //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            try {
                SqlConnection cn = new SqlConnection(cs);
            
                cn.Open();
                // string query = "insert into cashier values(@id,@password,@name,@address,@phone,@email,@date)";
                
                string query = "insert into [transaction] values(@tranDate,@tranUserID,@tranType,@tranAmount,@usrType,@tranPlace,@accountID,@balance)";
                SqlCommand cmd = new SqlCommand(query, cn);
                //cmd.Parameters.AddWithValue("@tranID",tranID);
                cmd.Parameters.AddWithValue("@tranDate", tranDate);
                cmd.Parameters.AddWithValue("@tranUserID", tranUserID);
                cmd.Parameters.AddWithValue("@tranType", tranType);
                cmd.Parameters.AddWithValue("@tranAmount", tranAmount);
                cmd.Parameters.AddWithValue("@usrType", usrType);
                cmd.Parameters.AddWithValue("@tranPlace", tranPlace);
                cmd.Parameters.AddWithValue("@accountID", accountID);
                cmd.Parameters.AddWithValue("@balance", balance);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        
    }
}
