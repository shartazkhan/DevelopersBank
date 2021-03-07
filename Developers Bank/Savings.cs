using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
     class Savings : Account
    {
        public Savings (string accountName, string dateOfBirth, string accountType, double balance, Address address) : base(accountName, dateOfBirth, accountType, balance, address)
        {
            this.accountName = accountName;
            Account.balance = balance;
            this.address = address;
            this.accountType = accountType;
            this.dateOfBirth = dateOfBirth;
            Idgenerator obj = new Idgenerator();
            this.AccountNumber = "1-" + obj.Generator();
            
        }

        //Withdraw 
        override public void Withdraw(double amount)
        {
            Console.WriteLine("Withdaw savings");

            if (Account.balance - amount > 0)
            {
                Account.balance = Account.balance - amount;
                Console.WriteLine("Withdaw Successful");
                ++Account.transCount;
                Console.WriteLine(Account.transCount);
            }
            else if (Account.balance - amount <= 0)
            {
                Console.WriteLine("Withdaw Not possible. \nSavings Account balance can not be 0 TAKA.");
            }
            

        }

        //Tranfer
        override public void Transfer(double amount, string receiver)
        {
           
            
            
            Console.WriteLine(receiver);
            Console.WriteLine(amount);

            Account.balance = Account.balance + amount;
            Console.WriteLine("Transfer Successfully Completed");
            ++Account.transCount;
            Console.WriteLine(Account.transCount);
        }

        //Deposite
        override public void Deposit(double amount)
        {
            ++Account.transCount;
            Console.WriteLine(Account.transCount);

            Account.balance = Account.balance + amount;
            Console.WriteLine("Deposited!!");
        }


    }
}
