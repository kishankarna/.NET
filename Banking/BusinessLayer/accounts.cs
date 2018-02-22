using System;
using System.Collections.Generic;
using DALlayer;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class accounts
    {
        public static void createAccounts(string _accountID, string _accountType, double _moneyBalance, string _preparer, DateTime _date, string _custID)
        {
            account.createAccounts(_accountID, _accountType, _moneyBalance, _preparer, _date, _custID);
        }

        public static string CheckingAccountIDs(string _custID)
        {
           return account.CheckingAccountID(_custID);

        }

        public static string SavingAccountIDs(string _custID)
        {
            return account.SavingAccountID(_custID);

        }

        public static string CreditAccountIDs(string _custID)
        {
            return account.CreditAccountID(_custID);

        }

        public static void FirstDeposit(string _accountID, string _custID, double _balance, string _accountType)        
        {

            account.FirstDeposit(_accountID, _custID, _balance, _accountType);
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
