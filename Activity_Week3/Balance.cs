using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Week3
{
    internal class Balance
    {
        private int currentBal;

        public Balance() {
            currentBal = 50000;

        }

        public int getBalance() {
            return currentBal;
        }

        public void setBalance(int bal) {
            currentBal = bal;
        }
    }
}
