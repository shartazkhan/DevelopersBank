using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    abstract class Account
    {
        protected string accountNumber;
        protected string accountName;
        protected string accountType;
        protected static double balance;
        protected string dateOfBirth;
        protected Address address;
        protected int start = 999;
        protected static int transCount = 0;
        public Account(string accountName,  string dateOfBirth, string accountType, double balance, Address address)
        {
            this.accountName = accountName;
            Account.balance = balance;
            this.address = address;
            this.accountType = accountType;
            this.dateOfBirth = dateOfBirth;
        }

        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }
        public double Balance
        {
            get { return Account.balance; }
            set { Account.balance = value; }
        }
        public string DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }
        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        //Withdraw 
        public abstract void Withdraw(double amount);

        //Transfer
        public abstract void Transfer(double amount, string receiver);

        //Deposit
        public abstract void Deposit(double amount);
       

        public void PrintAccount()
        {

            Console.WriteLine("\n\tAccount No:{0}\n\tAccount Name:{1}\n\tBalance:{2}\n\tDate of Birth: {3} ", this.accountNumber, this.accountName, Account.balance, this.dateOfBirth);
            this.address.PrintAddress();
        }

        public static void Show()
        {

            Console.WriteLine("\tTrans: {0}\n\tBalance: {1}", Account.transCount, Account.balance);
            
        }


    }
}
