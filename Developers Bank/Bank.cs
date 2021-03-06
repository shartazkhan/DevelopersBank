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
        public string chooice;
        private string teampAccount;
        private double teampAmount;
        private string receiver;
      
       
        public Bank(string bankName,int size)
        {
            Bank.size = size;
            this.bankName = bankName;
            myBank = new Account[size];
        }
        public void AccessAccount()
        {
            while (flag == 0)
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(" \t  Make a  Transactions  With Developers Bank LTD");
                Console.WriteLine("----------------------------------------------------------------");

                Console.WriteLine("Please Enter a Command to Progress: \n");
                Console.WriteLine("deposit --> Make a deposit\nwithdraw --> Make a withdrawal\ntransfer --> Make a transfer\nshow --> Show the number transactions and balance\nquit --> Exit the application ");
                chooice = Console.ReadLine();

                switch (chooice)
                {
                    case "deposit":

                        Console.WriteLine("Please Enter a Account Number: \n");
                        teampAccount = Console.ReadLine();

                        Console.WriteLine("Please Enter Diposit Amount: \n");
                        teampAmount = Convert.ToDouble(Console.ReadLine());

                        Transaction(teampAmount, chooice, teampAccount);
                       /* if (myBank[temp].AccountNumber == teamp)
                        {
                            myBank[i].Deposite(amount);
                        }*/

                        break;

                    case "withdraw":
                        //12312
                        Console.WriteLine("Please Enter a Account Number: \n");
                        teampAccount = Console.ReadLine();

                        Console.WriteLine("Please Enter Withdraw Amount: \n");
                        teampAmount = Convert.ToDouble(Console.ReadLine());

                        Transaction(teampAmount, chooice ,teampAccount);

                        break;

                    case "transfer":
                        Console.WriteLine("Please Enter a Receiver Account Number: \n");
                        receiver = Console.ReadLine();

                        Console.WriteLine("Please Enter Transfer Amount: \n");
                        teampAmount = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Please Your Account Number: \n");
                        teampAccount = Console.ReadLine();

                        Transaction(teampAmount, chooice, teampAccount, receiver);


                        break;
                    case "show":



                        break;
                    case "quit":

                        flag = 1;

                        break;
                    default:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Wrong Input!\nPlease try Again.");
                        Console.WriteLine("--------------------------------");
                        break;
                }

            }
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


        public void Transaction( double teampAmmount, string transType, params string[] optionalParams)
        {
            string tempAcn;
            string tempAcn2;

           try
            {
                tempAcn = optionalParams[0];
                tempAcn2 = optionalParams[1];
               
            }
            catch (Exception e)
            {
                tempAcn = optionalParams[0];
                tempAcn2 = optionalParams[0];
            }

            for (int i = 0; i < myBank.Length; i++)
            {
               
                if (myBank[i] == null)
                {
                    continue;
                    Console.WriteLine("Transaction method null case");
                }
                else if ( myBank[i].AccountNumber == tempAcn && transType == "deposite")
                {
                    myBank[i].Deposite(teampAmmount);
                    Console.WriteLine("Transaction method dipo");
                    break;
                }
                else if (myBank[i].AccountNumber == tempAcn && transType == "withdraw")
                {
                    // accountType = teampAccount.Substring(0, 1);
                    Console.WriteLine("withdraw working");
                    myBank[i].Withdraw(teampAmmount, myBank[i].AccountType);
                   // check = true;
                    break;
                }
                else if (myBank[i].AccountNumber == tempAcn && transType == "transfer")
                {
                    Console.WriteLine("trans  working");
                    //accountType = teampAccount.Substring(0, 1);
                    myBank[i].Withdraw(teampAmmount, myBank[i].AccountType);
                    for (int j = 0; j < myBank.Length; j++)
                    {
                        if (myBank[j].AccountNumber == tempAcn2)
                        {
                            
                            myBank[j].Transfer(ref tempAcn2, teampAmmount);
                        }
                        else
                        {
                            Console.WriteLine("Receiver account not found"); //
                        }
                    }
                       

                   
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Transaction method no case");
                }

            }

        }

      /*  public void Transaction(int transactionType, double amount, params Account[] receiver)
        {
           // Console.WriteLine("-----------------" + BankName + "-----------------\n");
            Console.WriteLine("Please Enter a Account Number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (transactionType == 1 && myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i].Deposite(amount);
                    check = true;
                    break;
                }
                else if (transactionType == 2 && myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i].Withdraw(amount);
                    check = true;
                    break;
                }
                else if (transactionType == 3 && myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i].Transfer(receiver, amount);
                    check = true;
                    break;
                }

            }
            if (check == false)
            {
                Console.WriteLine("You Choose a Wrong Number!!!! ");
            }
        }*/

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

        public void Savings()
        {

        }

        public void Checking()
        {

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
