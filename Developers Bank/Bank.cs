using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
     class Bank
    {
        private string bankName;
        private static Account[] myBank;
        public static int size;
        public int flag = 0;
        //public string chooice;
       //private string teampAccount;
        //private double teampAmount;
       // private string receiver;
       
       
        public Bank(string bankName,int size)
        {
            Bank.size = size;
            this.bankName = bankName;
            myBank = new Account[size];
        }
        public void AccessAccount()
        {
           
        }

        

        public Account[] MyBank
        {
            get
            {
                return myBank;
            }
            set
            {
                myBank = value;
            }
        }
        public Account[] Accounts
        {
            set { Bank.myBank = value; }
            get { return Bank.myBank; }
        }

        public int Flag
        {
            set { this.flag = value; }
            get { return this.flag; }
        }


        public void Transaction( double teampAmmount, string transType, params string[] tempAcn)
        {
            int length = myBank.Length;

            for (int i = 0; i < length; i++)
            {
               
                if (myBank[i] == null)
                {
                    Console.WriteLine("Transaction method null case");
                    continue;
                   
                }
                else if ( myBank[i].AccountNumber == tempAcn[0] && transType == "deposite")
                {
                   
                    myBank[i].Deposite(teampAmmount);
                    Console.WriteLine("Dipo method working");
                    break;
                }
                else if (myBank[i].AccountNumber == tempAcn[0] && transType == "withdraw")
                {

                    myBank[i].Withdraw(teampAmmount);
                    Console.WriteLine("withdraw working");
                    break;

                }
                else if (myBank[i].AccountNumber == tempAcn[0] && transType == "transfer")
                {

                    for (int j = 0; j < length; j++)
                    {
                        if (myBank[j].AccountNumber == tempAcn[1])
                        {   
                            myBank[i].Withdraw(teampAmmount);
                            myBank[j].Transfer(teampAmmount,tempAcn[1]);
                            break;
                        }
                        else
                        { continue; }
                    }
                        break;
                }
                else
                {
                    Console.WriteLine("Transaction method no case");
                }

            }

            PrintAllAccounts();

        }

      

        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }


        
        public void PrintAllAccounts()
        {
            Console.WriteLine("-----------------" + bankName + "-----------------");
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].PrintAccount();
            }
            Console.WriteLine("-----------------" + "######" + "-----------------");
        }

        
    }
}
