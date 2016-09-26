using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {

        //fields

        private int accountBalance;
        private string accountNumber;


        //properties
        //so program can access private fields

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

        public SavingsAccount(string holderName):base(holderName)
        {
            this.accountNumber = "90210";
            this.accountBalance = 3000000;
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
            Console.WriteLine("The account balance in your savings account is " + AccountBalance);
        }
    }
}
