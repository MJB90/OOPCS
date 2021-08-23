using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day3.InheritanceII
{
    public class Account
    {
        /**
         * TODO: create attributes
         * This class has 3 attributes:
         * acctNumber : string, private
         * acctHolderId : string, private
         * balance: double, private
         */
        private string acctNumber, acctHolderId;
        private double balance;

        public Account() { }

        /**
         * TODO: create constructor
         * This contructor receives 3 values
         * and initializes the 3 attributes accordingly
         */
        public Account(string acctNumber, string acctHolderId, double balance)
        {
            this.acctNumber = acctNumber;
            this.acctHolderId = acctHolderId;
            this.balance = balance;
        }

        /**
         * TODO: create properties
         * These properties expose the private attributes
         *
         * Note: acctNumber should be read-only, i.e. can not be
         * set from outside
         */
        public string AcctNumber
        {
            get { return acctNumber; }
        }

        public string AcctHolderId
        {
            get { return acctHolderId; }
            set { acctHolderId = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }



        /**
         * TODO: implement method Deposit
         * This method increases the account balance 
         * by the given amount
         */
        public void Deposit(double deposit)
        {
            balance += deposit;
        }

        /**
         * TODO: implement method Withdraw
         * This method decreases the account balance
         * by the given amount. Balance must NOT be negative.
         * It makes sure that there is enough balance to
         * widthdraw
         */

        public virtual bool Withdraw(double withdraw)
        {
            if (withdraw <= balance)
            {
                balance -= withdraw;
                return true;
            }
            else return false;
        }


        /**
         * TODO: implement method TransferTo
         * This method transfers a given amount to another given 
         * account. It makes sure that this sender has enough
         * balance before transfering
         */
        public bool TransferTo(Account ac1, Account ac2, double amount)
        {
            if (amount < ac1.balance)
            {
                ac1.balance -= amount;
                ac2.balance += amount;
                return true;
            }
            else return false;
        }

        /**
         * TODO: override method ToString
         * This method returns the values of the attributes
         * of the current object in a more readable format
         * For example: 
         * Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
         */
        override
        public string ToString()
        {
            string result = $"Account : accountNumber = {acctNumber}, accountHolder = {acctHolderId}, balance = {balance}";
            return result;
        }

        public virtual double CalculateInterest()
        {
            return 0;
        }

        public virtual void CreditInterest()
        {
            
        }

    }
}
