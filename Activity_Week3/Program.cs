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
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("(1: Transfer,\t4: Check Balance,\n2: Withdraw,\t5: Pay Bills,\n3: Change Pin,\t6: Exit)");
                        /*Console.WriteLine("(1: Transfer, 2: Withdraw, 3: Change Pin, 4: Check Balance, 5: Pay Bills, 6: Exit)");*/
                        Console.WriteLine("________________________________\n");

                        responseMenu = Console.ReadLine();

                        if (responseMenu == "1") 
                        {
                            var transfer = new Transfer();
                            transfer.run();

                        }

                        else if (responseMenu == "2") 
                        {
                            var withdraw = new Withdraw();
                            withdraw.run();
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

                        else if (responseMenu == "4")
                        {
                            Balance balance = new Balance();

                            balance.getBalance();

                            balance.run();
                        }

                        else if (responseMenu == "5")
                        {
                            var bills = new Bills();
                            bills.run();
                        }

                        else if (responseMenu == "6")
                        {
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
    }
}
