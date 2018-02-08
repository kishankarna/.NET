using System;
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

        public static void createCustomer(string _id, string _password, string _name, string _address, string _phone, string _email,
            string _accountID, string _accountType, DateTime _date, double _money, string _cashierID)
        {
            UserCreatnRegister.createCustomer(_id, _password, _name, _address, _phone, _email, _accountID, _accountType, _date,_money,_cashierID);
        }
        public static string GetCashierPasswords(string _usr)
        {
            string pwd= UserCreatnRegister.GetCashPassword(_usr);
            return pwd;
        }

        public static DataTable  GetCustomerPasswords(string _usr)
        {
            DataTable data = new DataTable();
             data = UserCreatnRegister.GetCusPassword(_usr);
            return data;
        }

    }
}
