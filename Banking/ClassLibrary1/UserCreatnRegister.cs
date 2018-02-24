﻿using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

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

        public static List<string> GetCusPassword(string usrID)
        {
            //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            List<string> data = new List<string>();
            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();
                string query = "select Password,Name from customer where custID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", usrID);
                SqlDataReader dr= cmd.ExecuteReader();
                if (dr.Read())
                {
                    data.Add(dr[0].ToString());
                    data.Add(dr[1].ToString());
                    return data;
                }
                return null;
               
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

        public static void createCustomer(string id, string password, string name, string address, string phone, string email)
        {
           
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            { 
                cn.Open();
                string query = "insert into customer values(@id,@password,@name,@address,@phone,@email)";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
               
                cmd.ExecuteNonQuery();
            }
         
        }
        public static bool checkCustomer(string CustID)
        {
            bool flag = false;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            string val = null;
            try {
                using (SqlConnection cn = new SqlConnection(cs))
                {
                    cn.Open();
                    // string query = "insert into customer values(@id,@password,@address,@phone,@email)";
                    string query = "select CustID from [customer] where CustID=@id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", CustID);
                    val = cmd.ExecuteScalar().ToString();
                }
                if (val != null)
                {
                    flag = true;
                    return flag;
                }
                return flag;
            }
            catch (System.NullReferenceException ex) { return flag; }
            }
        public static bool GetAccount(string custID,string AccountType)
        {
            bool accounFound=false;
            //  string cs = ConfigurationManager.ConnectionStrings["bankcs"].ConnectionString;
            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();
                string query = "select AccountType from accounts where CustID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", custID);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())   //loop through for all acounts such that if the cust is present
                    {
                        if (dr[0].ToString() == AccountType)
                        {
                            accounFound = true;
                        }
                    }
                }
                return accounFound;
            }
        }

        public static void EditCustomer(string CustID, string address, string phone, string email)
        {

            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();
               // string query = "insert into customer values(@id,@password,@address,@phone,@email)";
                string query = "update [customer] set address=@address,phone=@phone,email=@email where CustID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", CustID);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);

                cmd.ExecuteNonQuery();
            }

        }

        public static List<string> GetCustomer(string CustID)
        {

            string cs = "server=NIKSON-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=bank ";
            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();
                 string query = "select Address, Phone, Email from customer where CustID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", CustID);
                SqlDataReader dr= cmd.ExecuteReader();
                List<string> data = new List<string>();
                if (dr.Read())
                {
                    data.Add(dr[0].ToString());
                    data.Add(dr[1].ToString());
                    data.Add(dr[2].ToString());
                    return data;
                }
                return null;
            }

        }

    }
}
