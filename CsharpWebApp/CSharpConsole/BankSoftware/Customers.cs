using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharpConsole.BankSoftware
{
    
    class Customers : Account
    {
        //public List<string> CustDetail = null;
        //get ACcID from account
        private string CU_ID;
        private string name;
        private string Address;
        private string Phone;
        private string Email;

        public string CustomerName
        {
            get { return name; }
            set { name = value; }
        }
        public string CustEmail
        {
            get { return Email; }
            set { Email = value; }
        }

        public string CustPhone
        {
            get { return Phone; }
            set { Phone = value; }
        }

        public string CustAddress
        {
            get { return Address; }
            set { Address = value; }
        }


        public string CustomerID
        {
            get { return CU_ID; }
            set { CU_ID = value; }
        }

       

        public void createAccount()
        {
           // CustDetail = new List<string>();
            //List<string> data = new List<string>();

            Console.WriteLine("Enter  Following data to create Account!!");
            Console.WriteLine("****************************************** ");
            Console.Write("Create Customer USER ID: ");
            string cID = Console.ReadLine();
            Console.Write("Create Customer Password: ");
            string cPSS = Console.ReadLine();
            Console.Write("Re-enter Customer Password: ");
            string cRE_PSS = Console.ReadLine();
            Console.Write("Enter Customer Name: ");
            string cName = Console.ReadLine();
            Console.Write("Enter Customer Address: ");
            string cAddres = Console.ReadLine();
            Console.Write("Enter Customer Phone no: ");
            string cPhn = Console.ReadLine();
            Console.Write("Enter Customer Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Opening Amount: ");
            string balanceAmount = Console.ReadLine();
            string aID = cID+"AC/ID";
            Console.WriteLine("");

            Regex regex = new Regex(@"^[0-9]+$");

            if (cPSS != cRE_PSS)
               Console.WriteLine("Make Password correction");
            else if (!regex.IsMatch(balanceAmount))
               Console.WriteLine("Make Balance Amount correction"); 
            else {
                CustDetail.Add(cID);
                CustDetail.Add(aID);
                CustDetail.Add(cPSS);
                CustDetail.Add(cRE_PSS);
                CustDetail.Add(cName);
                CustDetail.Add(cAddres);
                CustDetail.Add(cPhn);
                CustDetail.Add(email);
                CustDetail.Add(balanceAmount.ToString());

                AccountBalance = Convert.ToDouble(CustDetail[8]);       //depositing amount
                //for rest of all
                Console.WriteLine("=========================================");
                Console.WriteLine("Account created & added Successfully");
                Console.WriteLine("=========================================");
            }

           
        }
        
        public void Login(string id, string password) {
            try
            {
                if (id.Equals(CustDetail[0]) && password.Equals(CustDetail[2]))
                {
                    Console.WriteLine("Login Successfull");
                    Console.WriteLine("***************************************");
                    AccountTransaction();
                }
                else
                {
                    Console.WriteLine(CustDetail[0]);
                    Console.WriteLine("Wrong cust detail Credentials!!");
                }
            }
            catch (Exception ex) { Console.WriteLine("Wrong Wrong Credentials!!"); }
        }
        public void AccountTransaction()
        {
            Console.WriteLine("Account Logging");
            Console.WriteLine("***********************************");

            char acnChoice;

            do
            {
                //After accoun creation
                Console.WriteLine("Enter the option to perform: ");
                Console.WriteLine("=========================================");
                Console.WriteLine("Enter the option to perform: 1-->Depoist");
                Console.WriteLine("Enter the option to perform: 2-->Withdraw");
                Console.WriteLine("Enter the option to perform: 3-->Check Balance");
                Console.WriteLine("Enter the option to perform: 4-->Sign out!! ");
                acnChoice = Convert.ToChar(Console.ReadLine());
                switch (acnChoice)
                {

                    case '1':
                        Console.WriteLine("This is Deposit");
                        Console.WriteLine("Enter the amount to Deposit");
                        string amt = Console.ReadLine();
                        Deposit = Convert.ToDouble (amt);
                        break;
                    case '2':
                        Console.WriteLine("Withdrawing Amount");
                        Console.WriteLine("Enter the amount to Withdraw");
                        break;
                    case '3':
                        Console.WriteLine("Checking Balance");
                        CheckBalance();
                        
                        break;
                    case '4':
                        Console.WriteLine("Signing Out!!!!!!!!");
                        break;
                    default:
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                        Console.WriteLine("Please Enter Correct Option");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                        break;

                }

            } while (acnChoice != '4');

        }
    }
}
