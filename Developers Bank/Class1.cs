using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class Class1
    {
        /*
         override public void Withdraw(double amount, string tempType)
        {
            this.transCount++;
            if (tempType == "savings" && this.balance - amount >= 500)
            {

                this.balance = this.balance - amount;
                Console.WriteLine("Withdaw Successful");

            }
            else if (tempType == "savings" && this.balance - amount < 500)
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
                    Console.WriteLine("Transaction method dipo");
                    break;
                }
                else if (myBank[i].AccountNumber == tempAcn[0] && transType == "withdraw")
                {
                  
                    Console.WriteLine("withdraw working");
                    myBank[i].Withdraw(teampAmmount, myBank[i].AccountType);
                   // check = true;
                    break;
                }
                else if (myBank[i].AccountNumber == tempAcn[0] && transType == "transfer")
                {
                    

                    for (int j = 0; j < length; j++)
                    {
                        if (myBank[j].AccountNumber == tempAcn[1])
                        {
                            myBank[i].Withdraw(teampAmmount, myBank[i].AccountType);
                            myBank[j].Transfer(teampAmmount, myBank[j].AccountType);
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
        
          //Tranfer
        public void Transfer( double amount, string receiver)
        {
            this.transCount++;
            Console.WriteLine("Transfer working");
            Console.WriteLine(receiver);
            Console.WriteLine(amount);

            this.balance = this.balance + amount;
            Console.WriteLine("Transfer Successfully Completed");


        }

        //Deposite
        public void Deposite(double amount)
        {
            this.transCount++;
            this.balance = this.balance + amount;
            Console.WriteLine("Deposited!!");
        }
        
         
         
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
                    case "deposite":

                        Console.WriteLine("Please Enter a Account Number: \n");
                        teampAccount = Console.ReadLine();

                        Console.WriteLine("Please Enter Diposit Amount: \n");
                        teampAmount = Convert.ToDouble(Console.ReadLine());

                        Transaction(teampAmount, chooice, teampAccount);
                      

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
                        Console.WriteLine("Please Enter Your Account Number: \n");
                        teampAccount = Console.ReadLine();

                        Console.WriteLine("Please Enter Transfer Amount: \n");
                        teampAmount = Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine("Receiver Account Number: ");
                         receiver = Console.ReadLine();

                        Transaction(teampAmount, chooice, teampAccount,receiver);

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

            }*/
    }
}
