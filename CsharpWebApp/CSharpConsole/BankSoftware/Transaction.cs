using System;
using System.Collections.Generic;

namespace CSharpConsole.BankSoftware
{
    class Transaction
        
    {
        public static List<string> CustDetail = new List<string>(); //got from customers class

        private string t_ID;
        private DateTime time;
        private double t_Amount;
        //get  accout ID from customer
        private static double withdrawAmount;
        private static double depostiAmount;
        public double TransactionAmount
        {
            get { return t_Amount; }
            set { t_Amount = value; }
        }


        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }


        public string TransactionID
        {
            get { return t_ID; }
            set { t_ID = value; }
        }

        public static double Deposit
        {
            get { return depostiAmount; }
            set { depostiAmount = value;
                string bal = Convert.ToString(depostiAmount);
                CustDetail.Add(bal);
                
            }
        }

        public static double Withdraw
        {
            get { return withdrawAmount; }
            set { withdrawAmount = value; }
        }
        public static void CheckBalance()
        {
            //getting accountBalance from Customers class:Account

            Console.WriteLine("The Balance on this account is : " + Account.AccountBalance);
        }

    }
}
