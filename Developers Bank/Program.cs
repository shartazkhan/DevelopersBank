using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class Program
    {
       
        public static bool flag = true;  //this flag is used for iteration and al exit the menu
        public static string chooice;

        static void Main(string[] args)
        {  
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine(" \t\tWelcome to Developers Bank LTD");
            Console.WriteLine("----------------------------------------------------------------");

            // While loop for 
            while (flag)
            {
                Console.WriteLine("Please Enter a Command to Progress: \n");
                Console.WriteLine("open --> To Open an account\naccount --> To Perform transactions on an account\nquit --> To Exit the application ");
                chooice = Console.ReadLine();   //take input for menu

                // Menu 
                switch (chooice)
                {
                    case "open":
                        Account accounts = new Account();
                        if (accounts.Flag == 0)
                        {
                            flag = false;
                        }

                            break;

                    case "account":
                        Bank myBank = new Bank();
                        if (myBank.Flag == 0)
                        {
                            flag = false;
                        }

                        break;

                    case "quit":
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine(" Thank you for staying with us!");
                        Console.WriteLine("--------------------------------");
                        flag = false;

                        break;
                    default:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Wrong Input!\nPlease try Again.");
                        Console.WriteLine("--------------------------------");
                        break;


                    

                }

            }

            Console.ReadKey();
        }

    }
}
