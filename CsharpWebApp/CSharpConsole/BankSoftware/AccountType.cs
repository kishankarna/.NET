using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.BankSoftware
{
    class AccountType
    {
        private string accountTypeID;
        private string accountType;

        public string Account_Type
        {
            get { return accountType; }
            set { accountType = value; }
        }

        public string AccountTypeID
        {
            get { return accountTypeID; }
            set { accountTypeID = value; }
        }

    }
}
