using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class Account
    {

        //fields
        protected string nameOnAccount = "Lebron James";


        //properties

        //methods

        public abstract int Deposit(int money);


        public abstract int Withdrawal(int money);
        
    }
}
