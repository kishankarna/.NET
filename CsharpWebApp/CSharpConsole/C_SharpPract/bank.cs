using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole
{
    class bankAccount {
        private int bankBalance;
        public bankAccount()
        {
            bankBalance = 100;
        }
        public void Deposit(int  val) {
            this.bankBalance += val;
            Console.WriteLine("Depositing {0} and new balance is {1}",val,this.bankBalance );
        }

        public void Withdraw(int val) {
            this.bankBalance -= val;

            Console.WriteLine("Withdrading {0} and your new balancae is {1}",val,this.bankBalance);

        }

        public void checkBalance() {
            Console.WriteLine("Your current bank balance is : "+this.bankBalance);
        }

    }
    class bank
    {
       

        static void Main() {
            bankAccount ob = new bankAccount();
            ob.Deposit(100);
            ob.checkBalance();
            Console.ReadKey();
        }
    }
}
