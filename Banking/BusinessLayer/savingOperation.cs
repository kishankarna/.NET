using System;
using System.Collections.Generic;
using System.Data;
using DALlayer;

namespace BusinessLayer
{
   public class savingOperation
    {
        public static double AccountBalance(string _accountID)
        {
            double bal = checkingSQL.GetBalance(_accountID);
            return bal;
        }
        public static DataTable GetTransactions(string _accountID)
        {
            DataTable data = new DataTable();
            data = checkingSQL.GetTransaction(_accountID);
            return data;
        }

    }
}
