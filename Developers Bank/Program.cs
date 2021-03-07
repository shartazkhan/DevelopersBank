using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
     class Program
    {

        public static bool flag = true;  //this flag is used for iteration and all exit the menu
        public static string choice;
        public static string choice2;

        private static void Main(string[] args)
        {
            Console.Title = "Developers Bank LTD";
            Bank theBank = new Bank("Developer's bank", 100);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine(" \t\tWelcome to Developers Bank LTD");
            Console.WriteLine("----------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            // While loop for 
            while (flag)
            {
                bool flag2 = true;
                bool flag3 = true;
                Console.WriteLine("Please Enter a Command to Progress: \n");
                Console.WriteLine("open --> To Open an account\naccount --> To Perform transactions on an account\nquit --> To Exit the application\n");
                Console.ForegroundColor = ConsoleColor.Red;
                choice = Console.ReadLine();   //take input for menu
                Console.ForegroundColor = ConsoleColor.White;
                // Menu 
                switch (choice)
                {
                    case "open":

                        while (flag2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.WriteLine(" \t  Creat an Account with Developers Bank LTD");
                            Console.WriteLine("----------------------------------------------------------------\n");
                           
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Name: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("\nDate of Birth \n");
                            Console.Write("Day: ");
                            string day = Console.ReadLine();
                            Console.Write("Month: ");
                            string month = Console.ReadLine();
                            Console.Write("Year: ");
                            string year = Console.ReadLine();
                            string dob = day + month + year;
                            
                            Console.Write("House no: ");
                            int houseNo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Road no: ");
                            int roadNo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("City: ");
                            string city = Console.ReadLine();
                            Console.Write("Country: ");
                            string country = Console.ReadLine();

                            Console.Write("Starting Ammount: ");
                            double ammount = Convert.ToDouble(Console.ReadLine());
                            

                            Console.WriteLine("\nPlease Enter a Command to Progress: \n");
                            Console.WriteLine("savings --> Open a savings account\nchecking --> Open a checking account\nquit --> Exit the application ");

                            Console.ForegroundColor = ConsoleColor.Red;
                            choice2 = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;

                            switch (choice2)
                            {
                                case "savings":
                                    theBank.AddAccount(new Savings(name, dob, choice2, ammount, new Address(houseNo, roadNo, city, country)));
                                    flag2 = false;
                                    break;

                                case "checking":
                                    theBank.AddAccount(new Checking(name, dob, choice2, ammount, new Address(houseNo, roadNo, city, country)));
                                    flag2 = false;
                                    break;

                                case "quit":

                                    flag2 = false;

                                    break;
                                default:
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Wrong Input!\nPlease try Again.");
                                    Console.WriteLine("--------------------------------");
                                    break;
                            }

                        }
                        Console.WriteLine("--------------------------------");
                        theBank.PrintAllAccounts();
                        Console.WriteLine("--------------------------------");
                        break;

                    case "account":

                        while (flag3)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.WriteLine(" \t  Make a  Transactions  With Developers Bank LTD");
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nPlease Enter a Command to Progress: \n");
                            Console.WriteLine("deposit --> Make a deposit\nwithdraw --> Make a withdrawal\ntransfer --> Make a transfer\nshow --> Show the number transactions and balance\nquit --> Exit the application\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            choice = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;

                            switch (choice)
                            {
                                
                                case "deposit":

                                    Console.WriteLine("Please Enter a Account Number: \n");
                                    string teampAccount = Console.ReadLine();

                                    Console.WriteLine("Please Enter Deposit Amount: \n");
                                    double  teampAmount = Convert.ToDouble(Console.ReadLine());
                                    
                                    
                                    theBank.Transaction(teampAmount, choice, teampAccount);

                                    Console.WriteLine("----------------------------------------------------------------");

                                    break;

                                case "withdraw":
                                    //12312
                                    Console.WriteLine("Please Enter a Account Number: \n");
                                    teampAccount = Console.ReadLine();

                                    Console.WriteLine("Please Enter Withdraw Amount: \n");
                                    teampAmount = Convert.ToDouble(Console.ReadLine());

                                    theBank.Transaction(teampAmount, choice, teampAccount);

                                    Console.WriteLine("----------------------------------------------------------------");

                                    break;

                                case "transfer":
                                    Console.WriteLine("Please Enter Your Account Number: \n");
                                    teampAccount = Console.ReadLine();

                                    Console.WriteLine("Please Enter Transfer Amount: \n");
                                    teampAmount = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Receiver Account Number: ");
                                    string receiver = Console.ReadLine();

                                    theBank.Transaction(teampAmount, choice, teampAccount, receiver);
                                    Console.WriteLine("----------------------------------------------------------------");
                                    break;
                                case "show":
                                    
                                    Account.Show();

                                    break;
                                case "quit":

                                    flag3 = false;
                                    Console.WriteLine("----------------------------------------------------------------");
                                    break;
                                default:
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Wrong Input!\nPlease try Again.");
                                    Console.WriteLine("--------------------------------");
                                    break;
                            }

                        }
                        Console.WriteLine("----------------------------------------------------------------");
                        break;

                    case "quit":
                        
                        flag = false;
                        //Console.WriteLine("----------------------------------------------------------------");
                        break;
                    default:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Wrong Input!\nPlease try Again.");
                        Console.WriteLine("--------------------------------");
                        break;

                }

            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine(" \t\tThank you for staying with us!");
            Console.WriteLine("----------------------------------------------------------------");
           
            Console.ReadKey();
        }

    }
}
