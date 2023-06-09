using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Week3
{
    internal class Deposit
    {
        public static int amount;
        public static int balance;

        public void run()
        {
            Console.WriteLine("");
            Console.Write("How much would you like to deposit?: ");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Confirm Depost amount? (1: Confirm, 2: Cancel)");
            string response = Console.ReadLine();

            if (response == "1")
            {
                balance = balance + amount;
                Console.WriteLine("You have deposited " + amount);
                Console.WriteLine("Your new balance is now " + balance);
            }

        }

    }
}
