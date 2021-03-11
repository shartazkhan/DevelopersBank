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
        public override void Withdraw(double amount)
        {

            if (Account.balance - amount > 0) 
            {
                if (amount < 0)
                {
                    amount = -amount;
                    Account.balance = Account.balance - amount;
                    Console.WriteLine("Withdraw Successful");
                    ++Account.transCount;

                }
                else
                {
                    Account.balance = Account.balance - amount;
                    Console.WriteLine("Withdraw Successful");
                    ++Account.transCount;
                }

            }
            else if (Account.balance - amount <= 0)
            {
                Console.WriteLine("Withdraw Not possible. \nSavings Account balance can not be 0 TAKA.");
            }
            

        }

        //Transfer
        public override void Transfer(double amount, string receiver)
        {
            Account.balance = Account.balance + amount;
            Console.WriteLine("Transfer Successfully Completed");
            ++Account.transCount;
        }

        //Deposit
        public override void Deposit(double amount)
        {
            ++Account.transCount;
            Console.WriteLine(Account.transCount);

            Account.balance = Account.balance + amount;
            Console.WriteLine("Deposited!!");
        }


    }
}
