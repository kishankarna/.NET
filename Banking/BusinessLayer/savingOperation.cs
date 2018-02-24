﻿using System;
using System.Collections.Generic;
using System.Data;
using DALlayer;

namespace BusinessLayer
{
   public class savingOperation
    {
        public static double AccountBalance(string _accountID)
        {
            double bal = savingSQL.GetBalance(_accountID);
            return bal;
        }
        public static DataTable GetTransactions(string _accountID)
        {
            DataTable data = new DataTable();
            data = savingSQL.GetTransaction(_accountID);
            return data;
        }

    }
}
