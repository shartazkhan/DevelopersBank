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
       

        public static string chooice;
        public static string chooice2;

        static void Main(string[] args)
        {
            Bank theBank = new Bank("Developer's bank", 100);
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine(" \t\tWelcome to Developers Bank LTD");
            Console.WriteLine("----------------------------------------------------------------");

            // While loop for 
            while (flag)
            {
                bool flag2 = true;
                Console.WriteLine("Please Enter a Command to Progress: \n");
                Console.WriteLine("open --> To Open an account\naccount --> To Perform transactions on an account\nquit --> To Exit the application ");
                chooice = Console.ReadLine();   //take input for menu
                
                // Menu 
                switch (chooice)
                {
                    case "open":

                        while (flag2)
                        {
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.WriteLine(" \t  Creat an Account with Developers Bank LTD");
                            Console.WriteLine("----------------------------------------------------------------\n");

                            Console.WriteLine("Name: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("Date of Birth: ");
                            Console.WriteLine("Day:");
                            string day = Console.ReadLine();
                            Console.WriteLine("Month: ");
                            string month = Console.ReadLine();
                            Console.WriteLine("Year: ");
                            string year = Console.ReadLine();
                            string dob = day + month + year;

                            Console.WriteLine("House no: ");
                            int houseNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Road no: ");
                            int roadNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("City: ");
                            string city = Console.ReadLine();
                            Console.WriteLine("Country: ");
                            string country = Console.ReadLine();

                            Console.WriteLine("Starting Ammount: ");
                            double ammount = Convert.ToDouble(Console.ReadLine());
                            

                            Console.WriteLine("Please Enter a Command to Progress: \n");
                            Console.WriteLine("savings --> Open a savings account\nchecking --> Open a checking account\nquit --> Exit the application ");
                            chooice2 = Console.ReadLine();

                            switch (chooice2)
                            {
                                case "savings":
                                    theBank.AddAccount(new Account(name, dob, chooice2, ammount, new Address(houseNo, roadNo, city, country)));
                                    Console.WriteLine("--------------------------------");
                                    theBank.PrintAllAccounts();
                                    Console.WriteLine("--------------------------------");
                                    flag2 = false;
                                    break;

                                case "checking":

                                    theBank.AddAccount(new Account(name, dob, chooice2, ammount, new Address(houseNo, roadNo, city, country)));
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

                        theBank.AccessAccount();
                        if (theBank.Flag == 1)
                        {
                            flag = false;
                        }
                        break;

                    case "quit":
                        
                        flag = false;

                        break;
                    default:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Wrong Input!\nPlease try Again.");
                        Console.WriteLine("--------------------------------");
                        break;

                }

            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" Thank you for staying with us!");
            Console.WriteLine("--------------------------------");
            Console.ReadKey();
        }

    }
}
