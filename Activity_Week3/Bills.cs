using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Week3
{
    internal class Bills
    {
        public void run()
        {
            int balance = 10000;
        loop:

            Console.Write("Enter your payment: ");
            int bills = Convert.ToInt32(Console.ReadLine());
            int sum = balance - bills;
            balance = sum;
            Console.WriteLine("your balance is now " + sum);
        }
    }
}
