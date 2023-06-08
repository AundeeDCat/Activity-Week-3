using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Week3
{
    internal class Change_PIN
    {
        public string inputOldPin = "";
        public string inputNewPin = "New";
        public string confirmNewPin = "Confirm";

        public void title() {
             
            Console.WriteLine("");
            Console.WriteLine("Welcome to Changing PIN");
            Console.WriteLine("________________________________");
            Console.WriteLine("");
        }
        public void oldPinConfirm() {
            Console.Write("Input your old PIN: ");
            inputOldPin = Console.ReadLine();
            
        }

        public void newPinInput() {
            Console.Write("Input your new PIN: ");
            inputNewPin = Console.ReadLine();


        }

        public void newPinConfirm() {
            Console.Write("Confirm new PIN: ");
            confirmNewPin = Console.ReadLine();

        }
    }
}
