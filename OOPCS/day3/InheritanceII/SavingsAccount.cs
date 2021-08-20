﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day3.InheritanceII
{
    /**
     * This class should derive from class Account.
     * Savings Account earns 1% interest, but balance can not be negative
     */
    class SavingsAccount : Account
    {
        /**
         * TODO: attributes
         * Create static variable interest = 1
         */
        private static double interest = 1;



        /**
         * TODO: create a constructor that accepts 3
         * parametes. The constructor should make use
         * of its parent's constructor to initialize
         * its attributes
         */
        public SavingsAccount(string accountNumber,string accountHolderId,double balance) : base(accountNumber,accountHolderId,balance)
        {

        }




        /**
         * TODO: implement method CalculateInterest
         * The method return the interest of this account.
         * Savings Account earns 1% interest of its balance.
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */
        public override double CalculateInterest()
        {
            return (interest * this.Balance) / 100;
        }



        /**
         * TODO: implement method CreditInterest
         * The method deposit the interst amount, returns by
         * CalculateInterest() method of this
         * account to its balance.
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */

        public override void CreditInterest()
        {
            this.Balance += this.CalculateInterest();
        }


        /**
         * TODO: override method Widthraw
         * This method decreases the account balance
         * by the given amount. 
         * For a Savings Account, balance cannot be negative
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */




        /**
         * TODO: override method ToString
         * This method returns the values of the attributes
         * of the current object in a more readable format
         * For example: 
         * (SavingsAccout) Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
         * 
         * This method should make use of its parent's method
         */




    }
}
