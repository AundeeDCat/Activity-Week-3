using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Week3
{
    public class Transfer
    {

        public static int amount;
        public void run()
        {
            Console.WriteLine("Transfer Money");

            Console.Write("Account Number: ");
            int account_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Account Name: ");
            string Name = Convert.ToString(Console.ReadLine());
            Console.Write("Amount :");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Cancel");
            int typenum = Convert.ToInt32(Console.ReadLine());

            if (typenum == 1)
            {
                Console.WriteLine("Your deposit is " + amount);
                Console.WriteLine("Transfer is done.");
            }
            else
            {

            }
        }
    }
}
