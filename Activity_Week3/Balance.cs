using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Week3
{
    public class Balance
    {
        public static int currentBal = 10000;
        public void run()
        {
            Console.WriteLine($"\nYour current balance is: {currentBal}");
        }
    }
}
