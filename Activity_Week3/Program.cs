using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean confirmPin = false;
            string responsePIN = "N";
            string responseMenu = "";
            Balance balance = new Balance();

            int PIN = 12345;

            int inputPIN;
            int wrongCount = 0;

            Console.WriteLine("Welcome to Console ATM.");
            Console.WriteLine("________________________________");
            Console.WriteLine("");

            while (wrongCount < 3) {

                while (confirmPin == false) {
                    Console.Write("Please input your PIN: ");
                    inputPIN = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Is the above PIN correct?(Y/N): ");
                    responsePIN = Console.ReadLine();

                    switch (responsePIN.ToUpper()) {
                        case "Y":
                            confirmPin = true;
                            break;

                        case "N":
                            confirmPin = false;
                            break;
                    }
                }

                if (PIN == inputPIN) {
                    while (responseMenu != "Exit") {
                        Console.WriteLine("");
                        Console.WriteLine("---What would you like to do?---");
                        Console.WriteLine("(1: Transfer     4: Check Balance)");
                        Console.WriteLine("(2: Withdraw     5: Pay Bills)");
                        Console.WriteLine("(3: Change Pin   6: Exit")
                        Console.WriteLine("___________________________________\n");

                        responseMenu = Console.ReadLine();

                        if (responseMenu == "1") {
                            var transfer = new Transfer();
                            transfer.run();

                        }

                        else if (responseMenu == "2") {
                            //var withdraw = new Withdraw();
                            //withdraw.run();

                            Console.Write("Enter amount: ");
                            int amount = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter PIN: ");
                            int withdrawPIN = Convert.ToInt32(Console.ReadLine());

                            if (wrongCount > 2 && withdrawPIN != PIN) { 
                                Console.WriteLine("Too many retries, program will now close.")
                                Console.ReadKey();
                                Environment.Exit(0);
                            }

                            else if (withdrawPIN != PIN) {
                                Console.Write("Wrong PIN, try again: ");
                                withdrawPIN = Convert.ToInt32(Console.ReadLine);
                                wrongCount++;
                            }

                            else {
                                Console.WriteLine("1. Confirm\n2. Cancel");
                                int input = Convert.ToInt32(Console.ReadLine());

                                if (amount > balance.getBalance() && input == 1)
                                    Console.WriteLine("Insufficient Balance");

                                else if (input == 1)
                                    printReceipt(amount);
                            }

                        }

                        else if (responseMenu == "3") // AUNDEE YOUR OVER HEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER
                        {
                            var changePin = new Change_PIN(); 
                            changePin.title();

                            changePin.oldPinConfirm();

                            while (Convert.ToInt32(changePin.inputOldPin) != PIN)
                            {
                                if (Convert.ToInt32(changePin.inputOldPin) != PIN)
                                {
                                    Console.WriteLine("PIN is Incorrect. Try again.");
                                }

                                changePin.oldPinConfirm();
                            }

                            while (changePin.inputNewPin != changePin.confirmNewPin)
                            {
                                changePin.newPinInput();
                                changePin.newPinConfirm();

                                if (changePin.inputNewPin != changePin.confirmNewPin)
                                {
                                    Console.WriteLine("PINs do not match. Try again.");
                                }
                            }

                            PIN = Convert.ToInt32(changePin.confirmNewPin);

                            Console.WriteLine("PIN has been changed.");


                        }

                        else if (responseMenu == "4") {
                            balance.getBalance();

                        }

                        else if (responseMenu == "5") {
                            var bills = new Bills();
                            bills.run();
                        }

                        else if (responseMenu == "6") {
                            Environment.Exit(0);
                        }

                        else {
                            Console.WriteLine("We do not have that feature. Please make sure your input is correct.");
                        }
                    }

                }

                else {
                    Console.WriteLine("PIN is incorrect. Try again.");
                    wrongCount = wrongCount+ 1;
                    confirmPin = false;

                    Console.ReadKey();
                }

            }

            Environment.Exit(0);
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
