using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class Account
    {
        private string accountNumber;
        private string accountName;
        private string accountType;
        private double balance;
        private string dateOfBirth;
        private Address address;
        

        public Account(string accountName,  string dateOfBirth, string accountType, double balance, Address address)
        {
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
            this.accountType = accountType;
            this.dateOfBirth = dateOfBirth;
            AccountNumberGen();
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
            get { return this.balance; }
            set { this.balance = value; }
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

        //This method will auto generate account number. 
        public void AccountNumberGen()
         {
             // 1- is for saving account and 2- is for cheking
             int start = 999;
             
             if(this.accountType == "savings")
             {
                start++;
                this.accountNumber = "1-"  + dateOfBirth + start;
                
             }
             else
             {
                start++;
                this.accountNumber = "2-" + dateOfBirth + start;
              
            }
             
         }

        
      /*  public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }*/


       

        //Withdraw 
        public void Withdraw(double amount,string tempType)
        {
            
            if (tempType == "savings" && this.balance - amount >= 500 )
            {
               
                this.balance = this.balance - amount;
                Console.WriteLine("Withdaw Successful");

            }
            else if(tempType == "savings" && this.balance - amount < 500)
            {
             
                Console.WriteLine("Withdaw Not possible");
            }
            else if (tempType == "checking" && this.balance - amount >= 0)
            {
                this.balance = this.balance - amount;
                Console.WriteLine("Withdaw Successful");
            }
            else
            {
                
              Console.WriteLine("Withdaw Not possible");
                

            }

           

        }

        //Tranfer
        public void Transfer(ref string receiver, double amount)
        {
            Console.WriteLine("Transfer working");
            Console.WriteLine(receiver);
            Console.WriteLine(amount);

            this.balance = this.balance + amount;
            Console.WriteLine("Transfer Successfully Completed");


        }

        //Deposite
        public void Deposite(double amount)
        {

            this.balance = this.balance + amount;
            Console.WriteLine("Deposited!!");
        }

        public void PrintAccount()
        {

            Console.WriteLine("\nAccount No:{0}\nAccount Name:{1}\nBalance:{2}\nDate of Birth: {3} ", this.accountNumber, this.accountName, this.balance, this.dateOfBirth);
            this.address.PrintAddress();
        }

    }
}
