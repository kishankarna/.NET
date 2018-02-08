using System;


namespace CSharpConsole.BankSoftware
{
    class Account :Transaction
    {
        private string accountID;
        //get accountType from account type
        private  static double balance;
        private float interest;
        private double overdraft;
        private DateTime date;

        public DateTime dateTime
        {
            get { return date; }
            set { date = value; }
        }
        public double AccountOverdraft
        {
            get { return overdraft; }
            set { overdraft = value; }
        }

        public float AccountInterestRate
        {
            get { return interest; }
            set { interest = value; }
        }

        public string AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }
     
        public static double AccountBalance
        {
            get { return balance; }
            set { balance = value; }
            
        }


    }
}
