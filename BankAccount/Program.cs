using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter accountReserve = new StreamWriter("ReserveAccount.txt");
            StreamWriter accountSavings = new StreamWriter("SavingsAccount.txt");
            StreamWriter accountChecking = new StreamWriter("CheckingAccount.txt");

            //ask for name

            Console.WriteLine("Please enter your name for your password.");
            string holderName = Console.ReadLine();
            
            Console.Clear();

            SavingsAccount savings = new SavingsAccount(holderName);
            CheckingAccount checking = new CheckingAccount(holderName);
            ReserveAccount reserve = new ReserveAccount(holderName);


            accountChecking.WriteLine("Account Holder: " + holderName);
            accountChecking.WriteLine("Account Number: " + checking.AccountNumber);
            accountChecking.WriteLine("Account Type: Checking Account");
            accountChecking.WriteLine("Account Balance: " + checking.AccountBalance);

            accountSavings.WriteLine("Account Holder: " + holderName);
            accountSavings.WriteLine("Account Number: " + savings.AccountNumber);
            accountSavings.WriteLine("Account Type: Savings Account");
            accountSavings.WriteLine("Account Balance: " + savings.AccountBalance);

            accountReserve.WriteLine("Account Holder: " + holderName);
            accountReserve.WriteLine("Account Number: " + reserve.AccountNumber);
            accountReserve.WriteLine("Account Type: Reserve Account");
            accountReserve.WriteLine("Account Balance: " + reserve.AccountBalance);

            while (true)
            {
                //menu
                Console.WriteLine("Welcome! What would you like to do?");
                Console.WriteLine("1: View Client Information");
                Console.WriteLine("View Account Balance of:");
                Console.WriteLine("\t2: Checking Account");
                Console.WriteLine("\t3: Savings Account");
                Console.WriteLine("\t4: Reserve Account");
                Console.WriteLine("5: Deposit Funds");
                Console.WriteLine("6: Withdrawal Funds");
                Console.WriteLine("7: Exit");

                int action = int.Parse(Console.ReadLine());

                Console.Clear();

                switch(action)
                {
                    case 1:
                        savings.ClientInfo();
                        break;

                    case 2:
                        checking.ViewAccountBalance();
                        break;

                    case 3:
                        savings.ViewAccountBalance();
                        break;

                    case 4:
                        reserve.ViewAccountBalance();
                        break;

                    case 5:
                        Console.WriteLine("Where would you like to make a deposit?");
                        Console.WriteLine("1: Checking Account");
                        Console.WriteLine("2: Savings Account");
                        Console.WriteLine("3: Reserve Account");

                        int choice = int.Parse(Console.ReadLine());

                        Console.WriteLine("How much would you like to deposit?");

                        int deposit = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                checking.Deposit(deposit);
                                Console.WriteLine("The new balance is " + checking.AccountBalance);
                                accountChecking.WriteLine("+ " + deposit + " " + DateTime.Now);
                                accountChecking.WriteLine("Account Balance: " + checking.AccountBalance);
                                break;

                            case 2:
                                savings.Deposit(deposit);
                                Console.WriteLine("The new balance is " + savings.AccountBalance);
                                accountSavings.WriteLine("+ " + deposit + " " + DateTime.Now);
                                accountSavings.WriteLine("Account Balance: " + savings.AccountBalance);
                                break;

                            case 3:
                                reserve.Deposit(deposit);
                                Console.WriteLine("The new balance is " + reserve.AccountBalance);
                                accountReserve.WriteLine("+ " + deposit + " " + DateTime.Now);
                                accountReserve.WriteLine("Account Balance: " + reserve.AccountBalance); 
                                break;

                            default:
                                break;

                        }
                        break;

                    case 6:
                        Console.WriteLine("Where would you like to make a withdrawal?");
                        Console.WriteLine("1: Checking Account");
                        Console.WriteLine("2: Savings Account");
                        Console.WriteLine("3: Reserve Account");

                        int pick = int.Parse(Console.ReadLine());

                        Console.WriteLine("How much would you like to withdrawal?");

                        int withdrawal = int.Parse(Console.ReadLine());

                        switch (pick)
                        {
                            case 1:
                                checking.Withdrawal(withdrawal);
                                Console.WriteLine("The new balance is " + checking.AccountBalance);
                                accountChecking.WriteLine("- " + withdrawal + " " + DateTime.Now);
                                accountChecking.WriteLine("Account Balance: " + checking.AccountBalance);
                                break;

                            case 2:
                                savings.Withdrawal(withdrawal);
                                Console.WriteLine("The new balance is " + savings.AccountBalance);
                                accountSavings.WriteLine("- " + withdrawal + " " + DateTime.Now);
                                accountSavings.WriteLine("Account Balance: " + savings.AccountBalance);
                                break;

                            case 3:
                                reserve.Withdrawal(withdrawal);
                                Console.WriteLine("The new balance is " + reserve.AccountBalance);
                                accountReserve.WriteLine("- " + withdrawal + " " + DateTime.Now);
                                accountReserve.WriteLine("Account Balance: " + reserve.AccountBalance);
                                break;
                        }
                        break;
                       
                    case 7:
                        break;

                    default:
                        break;
                       
                }

               
                Console.WriteLine("Would you like to do something else? Y or N?");
                string yesOrNo = Console.ReadLine();
                if(yesOrNo.ToLower()=="y")
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    break;
                }

            }

            accountReserve.Close();
            accountSavings.Close();
            accountChecking.Close();

            Quit();
        }



        static void Quit()
        {
            Console.WriteLine("Thank you, have a nice day.");
            Environment.Exit(0);
        }
    }
}
