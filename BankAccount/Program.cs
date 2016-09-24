﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            SavingsAccount savings = new SavingsAccount();
            CheckingAccount checking = new CheckingAccount();
            ReserveAccount reserve = new ReserveAccount();
            Account lebron = new Account();

            while(true)
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
                        lebron.ClientInfo();
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
                                break;

                            case 2:
                                savings.Deposit(deposit);
                                Console.WriteLine("The new balance is " + savings.AccountBalance);
                                break;

                            case 3:
                                reserve.Deposit(deposit);
                                Console.WriteLine("The new balance is " + reserve.AccountBalance);
                                break;
                        }
                        break;

                    case 6:
                        break;

                    case 7:
                        Quit();
                        break;

                    default:
                        Quit();
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
                    Quit();
                }

            }
        }

        //static void DepositCase()
        //{

        //    SavingsAccount savings = new SavingsAccount();
        //    CheckingAccount checking = new CheckingAccount();
        //    ReserveAccount reserve = new ReserveAccount();


        //    Console.WriteLine("Where would you like to make a deposit?");
        //    Console.WriteLine("1: Checking Account");
        //    Console.WriteLine("2: Savings Account");
        //    Console.WriteLine("3: Reserve Account");

        //    int choice = int.Parse(Console.ReadLine());

        //    Console.WriteLine("How much would you like to deposit?");

        //    int deposit = int.Parse(Console.ReadLine());

        //    switch(choice)
        //    {
        //        case 1:
        //            checking.Deposit(deposit);
        //            Console.WriteLine("The new balance is " + checking.AccountBalance);
        //            break;

        //        case 2:
        //            savings.Deposit(deposit);
        //            Console.WriteLine("The new balance is " + savings.AccountBalance);
        //            break;

        //        case 3:
        //            reserve.Deposit(deposit);
        //            Console.WriteLine("The new balance is " + reserve.AccountBalance);
        //            break;
        //    }

        //}

        static void Quit()
        {
            Console.WriteLine("Thank you, have a nice day.");
            Environment.Exit(0);
        }
    }
}
