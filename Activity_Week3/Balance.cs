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

        public void Balance() {
            currentBal = 50000;                
            
        }

        public String getBalance(){
           return $"\nYour current balance is: {currentBal}";
        }

        public void setBalance(int bal){
            currentBalance = bal;
        }
    }
}
