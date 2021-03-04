using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class Account
    {
        public int flag = 1;
        public string chooice;
        public Account()
        {

             while (Convert.ToBoolean(flag))
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(" \t  Creat an Account with Developers Bank LTD");
                Console.WriteLine("----------------------------------------------------------------");

                Console.WriteLine("Please Enter a Command to Progress: \n");
                Console.WriteLine("savings --> Open a savings account\nchecking --> Open a checking account\nquit --> Exit the application ");
                chooice = Console.ReadLine();
                
                switch(chooice)
                {
                    case "savings":


                        break;

                    case "checking":
                        

                        break;

                    case "quit":
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine(" Thank you for staying with us!");
                        Console.WriteLine("--------------------------------");
                        flag = 0;

                        break;
                    default:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Wrong Input!\nPlease try Again.");
                        Console.WriteLine("--------------------------------");
                        break;
                }

            }
        }

        public int Flag
        {
            get { return this.flag; }
        }

    }
}
