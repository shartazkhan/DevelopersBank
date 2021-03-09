using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class Checking : Account
    {
        
        public Checking(string accountName, string dateOfBirth, string accountType, double balance, Address address) : base(accountName,  dateOfBirth,  accountType,  balance,  address)
        {
            this.accountName = AccountName;
            Account.balance = Balance;
            this.address = Address;
            this.accountType = AccountType;
            this.dateOfBirth = DateOfBirth;
            Idgenerator obj = new Idgenerator();
            this.AccountNumber = "2-" + obj.Generator();
        }

        //Withdraw
        public override void Withdraw(double amount)
        {
           
            // this.transCount++;
            ++Account.transCount;
            if (Account.balance - amount >= 0)
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
            else if (Account.balance - amount < 0)
            {
                Console.WriteLine("Withdraw Not possible. \nSavings Account balance can not be less than 0 TAKA.");
            }
        }

        //Transfer
        public override void Transfer(double amount, string receiver)
        {
            ++Account.transCount;
            Console.WriteLine(Account.transCount);
            Console.WriteLine("Transfer working");
            Console.WriteLine(receiver);
            Console.WriteLine(amount);

            Account.balance = Account.balance + amount;
            Console.WriteLine("Transfer Successfully Completed");


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
