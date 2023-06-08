using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Week3
{
    public class Bills
    {
        public static int balance;
        public void run()
        {
        loop:

            Console.Write("Enter your payment: ");
            int bills = Convert.ToInt32(Console.ReadLine());
            int sum = balance - bills;
            balance = sum;
            Console.WriteLine("Your balance is now " + sum);
        }
    }
}
