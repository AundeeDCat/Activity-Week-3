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

            Withdraw withdraw = new Withdraw();
            Balance balance = new Balance();
            Bills bills = new Bills();
            Deposit deposit = new Deposit();
            Transfer transfer = new Transfer();


            int PIN = Withdraw.realPin;
            Bills.balance = Balance.currentBal;
            Withdraw.balance = Balance.currentBal;
            int currentBal = Balance.currentBal;

            string inputPIN = "";
            int wrongCount = 0;

            Console.WriteLine("Welcome to Console ATM.");
            Console.WriteLine("________________________________");
            Console.WriteLine("");

            while (wrongCount < 3)
            {

                while (confirmPin == false)
                {
                    Console.Write("Please input your PIN: ");
                    inputPIN = Console.ReadLine();
                    Console.Write("Is the above PIN correct?(Y/N): ");
                    responsePIN = Console.ReadLine();

                    switch (responsePIN)
                    {
                        case "Y":
                            confirmPin = true;
                            break;

                        case "y":
                            confirmPin = true;
                            break;

                        case "N":
                            confirmPin = false;
                            break;

                        case "n":
                            confirmPin = false;
                            break;
                    }
                }

                if (PIN == Convert.ToInt32(inputPIN))
                {

                    while (responseMenu != "Exit")
                    {
                        //UPDATE BALANCE
                        Bills.balance = currentBal;
                        Withdraw.balance = currentBal;
                        Balance.currentBal = currentBal;
                        Deposit.balance = currentBal;


                        Console.WriteLine("");
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("(1: Deposit 2: Transfer, 3: Withdraw, 4: Change Pin, 5: Check Balance, 6: Pay Bills, 7: Exit)");
                        Console.WriteLine("________________________________");
                        Console.WriteLine("");

                        responseMenu = Console.ReadLine();

                        if (responseMenu == "1")
                        {
                            deposit.run();
                            currentBal = Deposit.balance;
                        }

                        else if (responseMenu == "2") 
                        {
                            transfer.run();
                            currentBal = currentBal - Transfer.amount;
                        }

                        else if (responseMenu == "3") 
                        {
                            withdraw.run();
                            currentBal = currentBal - Withdraw.amount;
                        }

                        else if (responseMenu == "4") 
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
                            Withdraw.realPin = Convert.ToInt32(changePin.confirmNewPin);

                            Console.WriteLine("PIN has been changed.");


                        }

                        else if (responseMenu == "5")
                        {
                            balance.run();
                        }

                        else if (responseMenu == "6")
                        {
                            bills.run();
                            currentBal = Bills.balance;
                        }

                        else if (responseMenu == "7")
                        {
                            Environment.Exit(0);
                        }

                        else
                        {
                            Console.WriteLine("We do not have that feature. Please make sure your input is correct.");
                        }
                    }

                }

                else
                {
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
