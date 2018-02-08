using System;
using System.Collections.Generic;
using DALlayer;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class accounts
    {
        public static void FirstDeposit(string _accountID, string _name, double _balance, string _accountType)        
        {

            account.FirstDeposit(_accountID, _name, _balance, _accountType);
        }
        public static void Deposits(string _accountID, double _balance)
        {

            account.Deposit(_accountID, _balance);
        }

        public static double GetAccountBalance(string _accountID)
        {
            double balance = account.GetBalance(_accountID);
            return balance;
        }
    }
}
