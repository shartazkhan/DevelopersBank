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
        private Account[] myBank;
        public static int size;
        public int flag = 0;
       
        public Bank(string bankName,int size)
        {
            Bank.size = size;
            this.bankName = bankName;
            myBank = new Account[size];
        } 

        
        public Account[] MyBank
        {
            set { this.myBank = value; }
            get { return this.myBank; }
        }




        public void Transaction( double tempAmount, string transType, params string[] tempAcn)
        {
            int length = myBank.Length;


            for (int i = 0; i < length; i++)
            {
               
                if (myBank[i] == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("\t\t\tAccount Not Found!!");
                    Console.WriteLine("----------------------------------------------------------------");
                    break;
                   
                }
                else if (tempAmount < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t\tAmount of Transaction can not be a negative!!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else if ( myBank[i].AccountNumber == tempAcn[0] && transType == "deposit")
                {
                   
                    myBank[i].Deposit(tempAmount);
                    
                    break;
                }
                else if (myBank[i].AccountNumber == tempAcn[0] && transType == "withdraw")
                {

                    myBank[i].Withdraw(tempAmount);
                    
                    break;

                }
                else if (myBank[i].AccountNumber == tempAcn[0] && transType == "transfer")
                {

                    for (int j = 0; j < length; j++)
                    {
                        if (myBank[j].AccountNumber == tempAcn[1])
                        {   
                            myBank[i].Withdraw(tempAmount);
                            myBank[j].Transfer(tempAmount,tempAcn[1]);
                            break;
                        }
                        else
                        { continue; }
                    }
                    break;
                }
                else
                {
                    continue;
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\tAccount Created Successfully!!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
        }


        
        public void PrintAllAccounts()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t----------------- Account Info -----------------");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].PrintAccount();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t---------------------" + "######" + "--------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        
    }
}
