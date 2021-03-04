using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class Bank
    {
        public int flag = 1;
        public string chooice;
        public Bank()
        {
            while (Convert.ToBoolean(flag))
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(" \t  Make a  Transactions  with Developers Bank LTD");
                Console.WriteLine("----------------------------------------------------------------");

                Console.WriteLine("Please Enter a Command to Progress: \n");
                Console.WriteLine("deposit --> Make a deposit\nwithdraw --> Make a withdrawal\ntransfer --> Make a transfer\nshow --> Show the number transactions and balance\nquit --> Exit the application ");
                chooice = Console.ReadLine();

                switch (chooice)
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
