using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DALlayer
{
    public class UserCreatnRegister
    {    public static string GetCashPassword(string usrID)
        {          
                //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
                string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
                using (SqlConnection cn = new SqlConnection(cs))
                { 
                    cn.Open();
                    string query = "select * from cashier where userID=@id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", usrID);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                        return dr[1].ToString();
                    return null;
                }          
        }

        public static DataTable GetCusPassword(string usrID)
        {
            DataTable data = new DataTable ();
            //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();
                string query = "select * from customer where custID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", usrID);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);

                dr.Fill(data);
                cn.Close();
                return data;
               
            }
            
        }
        

        public static void createCashier(string id, string password, string name, string address, string phone, string email, DateTime date)
        {
            try
            {
                string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                string query = "insert into cashier values(@id,@password,@name,@address,@phone,@email,@date)";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@date", date);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        public static void createCustomer(string id, string password, string name, string address, string phone, string email, 
            string accountID, string accountType, DateTime date, double money, string cashierID)
        {
           
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            { 
                cn.Open();
                string query = "insert into customer values(@id,@password,@name,@address,@phone,@email,@accountID,@accountType, @date,@money,@cashierName)";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@accountID", accountID);
                cmd.Parameters.AddWithValue("@accountType", accountType);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@money", money);
                cmd.Parameters.AddWithValue("@cashierName", cashierID);
                cmd.ExecuteNonQuery();
            }
         
        }
    }
}
