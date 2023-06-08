using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Week3
{
    internal class Withdraw
    {
        public void run()
        {
            /*int num = 2;
            int menu;
            Console.Write("Enter PIN: ");
            int realPin = 1234;
            int pin = Convert.ToInt32(Console.ReadLine());
            int balance = 10000;

            while (pin != realPin)
            {
                if (num > 0)
                { 
                    Console.Write("Wrong PIN, try again: ");
                    pin = Convert.ToInt32(Console.ReadLine());
                    num--;
                }
                else
                {
                    Console.WriteLine("Too many wrong PIN attempts. Press ENTER to close");
                    break;
                }
            }

            if (pin == realPin)
            {
                Console.WriteLine("1. Transfer Money ");
                Console.WriteLine("2. Withdraw ");
                Console.WriteLine("3. Change PIN ");
                Console.WriteLine("4. Check Balance ");
                Console.WriteLine("5. Pay Bills ");
                Console.WriteLine("6. Exit ");
                Console.Write("Choose your action: ");
                menu = Convert.ToInt32(Console.ReadLine());

                // Choosing withdraw
                if (menu == 2)
                {*/
            // Enter amount
            Console.Write("Enter amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            // Enter PIN
            Console.Write("Enter PIN: ");
            int wdPIN = Convert.ToInt32(Console.ReadLine());

            // To keep track of number of attempts for PINs
            while (num >= 0) {

                // Will exit if no more number of attempts
                if (num == 0 && wdPIN != realPin) {
                    Console.WriteLine("Too many retries, bye!!!!!");
                    break;
                }

                // Checking if PIN is wrong
                else if (wdPIN != realPin) {
                    Console.Write("Wrong PIN, try again: ");
                    wdPIN = Convert.ToInt32(Console.ReadLine());
                    num--;
                }

                // This will display "Confirm, Cancel" is there is no problem with the PIN
                else {
                    Console.WriteLine("1. Confirm\n2. Cancel");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (amount > balance && input == 1) {
                        Console.WriteLine("Insufficient Balance");
                        break; // Code here to go back to menu
                    }

                    // Prints Receipt if Confirm is chosen
                    else if (input == 1) {
                        printReceipt(amount);
                        break;
                    }

                    // (Cancel) Else it goes back to the menu
                    else
                        break;
                    // change break; to code to return to menu
                }
            }
        }
        static void printReceipt(int amount) {
            Console.WriteLine("---------------------");
            Console.WriteLine("-------Receipt-------\n\n");
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Date and Time: " + DateTime.Now);
            Console.WriteLine("\n\n---------------------");
            Console.WriteLine("---------------------");
        }
    }
}

