using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DALlayer;

namespace BusinessLayer
{
    public class UserAccess
    {
        public static void createCashiers(string _id, string _password, string _name, string _address, string _phone,
            string _email, DateTime _date)
        {
            UserCreatnRegister.createCashier(_id, _password, _name, _address, _phone, _email, _date);
        }

        public static void createCustomer(string _id, string _password, string _name, string _address, string _phone, string _email)
        {
            UserCreatnRegister.createCustomer(_id, _password, _name, _address, _phone, _email);
        }

        public static string GetCashierPasswords(string _usr)
        {
            string pwd = UserCreatnRegister.GetCashPassword(_usr);
            return pwd;
        }

        public static List<string> GetCustomerPasswords(string _usr)
        {
            // DataTable data = new DataTable();
            List<string> data = new List<string>();
            data = UserCreatnRegister.GetCusPassword(_usr);
            return data;
        }

        public static bool GetAccount(string _custID, string _AccountType)
        {
            return UserCreatnRegister.GetAccount(_custID, _AccountType);

        }

        public static void EditCustomer(string _CustID, string _address, string _phone, string _email)
        {
            UserCreatnRegister.EditCustomer(_CustID, _address, _phone, _email);
        }

        public static List<string> GetCustomers(string _CustID)
        {
            return UserCreatnRegister.GetCustomer(_CustID);
        }

        public static bool checkCustomer(string _CustID)
        {
            return UserCreatnRegister.checkCustomer(_CustID);
        }
    }
}
