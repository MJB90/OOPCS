﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPCS.day3.InheritanceII;

namespace OOPCS.day4.Polymorphism
{
    class Test
    {
        public static void Main()
        {
            /**
             * TODO: create a branch, add accounts and  
             * call methods to test.
             * 
             * You many uncomment each part of the following 
             * code to use for your testing. You're encouraged
             * to add your own test cases.
             */

            Account savingAccount = new SavingsAccount("0000111", "S1111111A", 2000);
            Console.WriteLine(savingAccount.ToString());
            Account currentAccount = new CurrentAccount("0000222", "S2222222B", 2000);
            Console.WriteLine(currentAccount.ToString());
            Account overdraftAccount1 = new OverdraftAccount("0000333", "S3333333C", 2000);
            Console.WriteLine(overdraftAccount1.ToString());
            Account overdraftAccount2 = new OverdraftAccount("0000444", "S1111111A", -2000);
            Console.WriteLine(overdraftAccount2.ToString());

            BankBranch branch = new BankBranch("KOKO Bank Branch");
            branch.AddAccount(savingAccount);
            branch.AddAccount(currentAccount);
            branch.AddAccount(overdraftAccount1);
            branch.AddAccount(overdraftAccount2);

            Console.WriteLine();
            Console.WriteLine("Print all accounts");
            branch.PrintAccounts();

            Console.WriteLine();
            Console.WriteLine("Total deposits: {0}", branch.TotalDeposits());
            Console.WriteLine("Total interest paid: {0}", branch.TotalInterestPaid());
            Console.WriteLine("Total interest earned: {0}", branch.TotalInterestEarned());

            Console.WriteLine();
            Console.WriteLine("Print all customers");
            branch.PrintCustomers();

            Console.ReadLine();

        }
    }
}
