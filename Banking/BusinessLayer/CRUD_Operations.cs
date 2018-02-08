using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using DALlayer;
namespace BusinessLayer
{
   public class CRUD_Operations
    {
        public static void Deposits(DateTime _tranDate, string _tranUserID, string _tranType, double _tranAmount, string _usrType, string _tranPlace, string _accountID, double _balance)
        {
            CRUD_Operation.Deposit( _tranDate, _tranUserID, _tranType, _tranAmount, _usrType, _tranPlace, _accountID, _balance);
            
        }
    }

}

