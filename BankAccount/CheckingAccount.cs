using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {

        //fields

        private int accountBalance;
        private string accountNumber;


        //properties

        public int AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //constructor

        public CheckingAccount(string holderName): base(holderName)
        {
            this.accountNumber = "54321";
            this.accountBalance = 1000000;
        }

        //methods 

        public override int Deposit(int money)
        {
            this.accountBalance += money;
            return this.accountBalance;
        }

        public override int Withdrawal(int money)
        {
            this.accountBalance -= money;
            return this.accountBalance;
        }

        public override void ViewAccountBalance()
        {
            Console.WriteLine("The account balance in your checking account is " + AccountBalance);
        }
    }
}
