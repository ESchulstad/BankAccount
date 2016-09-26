using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {

        //fields
        
        private string nameOnAccount;
        private string address = "2016 Championship Lane, Cleveland, OH";
        private string phoneNumber = "232-323-2323";
        private string email = "cavs#1@gmail.com";
        private int accountBalance;


        //properties


        //constructor
        public Account(string holderName)
        {
            nameOnAccount = holderName;
        }

        //methods

        public virtual int Deposit(int money)
        {
            return accountBalance;
        }
        
        public virtual int Withdrawal(int money)
        {
            return accountBalance;
        }

        public virtual void ViewAccountBalance()
        {

        }

        public void ClientInfo()
        {
            Console.WriteLine("Name: " + nameOnAccount);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Phone Number: " + phoneNumber);
            Console.WriteLine("Email: " + email);
        }
        
    }
}
