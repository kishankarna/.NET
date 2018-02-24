using System;
using System.Collections.Generic;
using System.Data;
using DalLayer;

namespace BusinessLayer
{
    public class creditOperation
    {
        public static double AccountBalance(string _accountID)
        {
            double bal = credit.GetBalance(_accountID);
            return bal;
        }
        public static DataTable GetTransactions(string _accountID)
        {
            DataTable data = new DataTable();
            data = credit.GetTransaction(_accountID);
            return data;
        }

    }
}
