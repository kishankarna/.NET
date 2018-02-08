using System;
using System.Collections.Generic;

namespace CSharpConsole.BankSoftware
{
    class BankApp : Customers  
    {
       static  BankApp bankCustomer = null;
        // private double withdrawAmount;
        // private double depositAmount;
       // private string ID, PSS;
        private static string ID;
        private static string PSS;

        public static string USRPSS
        {
            get { return PSS; }
            set { PSS = value; }
        }

        public static string USRID
        {
            get { return ID; }
            set { ID = value; }
        }

        static void Main(string[] args)
        {
              bankCustomer = new BankApp();


            Console.WriteLine("This is Bank Software");
            Console.WriteLine("This software is developed by Karna Thapa");
            Console.WriteLine("=========================================");
            char LogCreate;
            do {
                Console.WriteLine("Enter the option to perform: ");
                Console.WriteLine("=========================================");
                Console.WriteLine("Enter the option to perform: 1-->Create Account");
                Console.WriteLine("Enter the option to perform: 2-->Login Account");
                Console.WriteLine("Enter the option to perform: 3-->Exit Program!!");
                Console.WriteLine("-----------------------------------------");
                Console.Write(": ");
                LogCreate = Convert.ToChar(Console.ReadLine());

                if (LogCreate == '1')
                   
                {
                    Console.WriteLine("Creating account!!");
                    bankCustomer.createAccount();

                }
                else if (LogCreate == '2')
                {
                    Console.WriteLine("logging account!!");
                    Console.WriteLine("Enter User Name: ");
                     USRID =Console.ReadLine();
                    
                    Console.WriteLine("Enter User Password: ");
                     USRPSS=Console.ReadLine();
                    bankCustomer.Login(USRID,USRPSS);
                }
                else if (LogCreate == '3')
                { Console.WriteLine("Prorgam Terminating!!");break; }
                else
                {
                    Console.WriteLine("***********************************");
                    Console.WriteLine("Please Provide The Correct option!!");
                    Console.WriteLine("***********************************");
                }

            } while (LogCreate != '3');
            Console.ReadKey();

            //Now Performing Operatin like depost, withdraw and check balance
            //****************************************************************




            //Console.WriteLine("Do you want to display data: 'y' for yes and 'n' for NO : ");
            //char dChoice = Convert.ToChar(Console.ReadLine());

            //    if (dChoice == 'y')
            //    {
            //    //foreach (var x in b.CustDetail)
            //        Console.WriteLine("************************************ ");
            //        Console.WriteLine("Custumer ID :    " +b.CustDetail[0]);
            //        Console.WriteLine("Custumer Acc No: "+b.CustDetail[1]);
            //        Console.WriteLine("Custumer Name:   "+b.CustDetail[2]);
            //        Console.WriteLine("Custumer Address:"+b.CustDetail[3]);
            //        Console.WriteLine("Custumer Phone:  "+b.CustDetail[4]);
            //        Console.WriteLine("Customer Email:  "+b.CustDetail[5]);
            //    }
            //    else if (dChoice == 'n') { Console.WriteLine("Good bye!!!......."); }
            //    else { Console.WriteLine("Choose wright option,,Try again!!"); }

        }//void main
       



        //
    }
}

