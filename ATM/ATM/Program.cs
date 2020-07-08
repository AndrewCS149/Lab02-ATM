using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ATM
{
    public class Program
    {
        static public decimal Balance = 1000.00M;
        static public List<string> transactions = new List<string>();

        /// <summary>
        /// Calls the application method which runs the ATM
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            application();
        }

        /// <summary>
        /// Displays the current balance to the user
        /// </summary>
        /// <returns>The current balance</returns>
        public static decimal ViewBalance()
        {
            Console.WriteLine($"Current balance: {Balance:C} \n");
            return Balance;
        }

        /// <summary>
        /// Subtracts from the current balance
        /// </summary>
        /// <param name="amount">Amount to withdraw</param>
        /// <returns>The new balance</returns>
        public static decimal WithDraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Funds.\n");
                return Balance;
            } else if (amount < 0)
            {
                Console.WriteLine("Cannot withdraw a negative amount.\n");
                return Balance;
            }

            Balance -= amount;
            Console.WriteLine($"Remaining balance: {Balance:C} \n");
            Transactions($"-{amount}");
            return Balance;
        }

        /// <summary>
        /// Adds to the current balance
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        /// <returns>The new balance</returns>
        public static decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Cannot deposit a negative amount.\n");
                return Balance;
            }

            Balance += amount;
            Console.WriteLine($"Remaining balance: {Balance:C} \n");
            Transactions($"+{amount}");
            return Balance;
        }

        /// <summary>
        /// ATM navigation. Displays ATM options and directs user to appropriate methods
        /// </summary>
        public static void application()
        {
            Console.WriteLine("Welcome to Smith's Auto Teller. \n");

            // loop to continuously display the menu options until the user selects "4" for exit
            bool running = true;
            while (running == true)
            {
                // Greeting with Options
                Console.WriteLine("Please select from the following options:");
                Console.WriteLine("1) Check Your Balance \n" +
                                  "2) Make a Withdrawal \n" +
                                  "3) Make a Deposit \n" +
                                  "4) Exit");

                string choice = Console.ReadLine();

                // get the balance
                if (choice == "1")
                {
                    Console.Clear();
                    ViewBalance();
                }
                // WithDraw
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.Write("Please Enter the amount you would like to withdraw: ");
                    string strAmount = Console.ReadLine();
                    decimal amount = Convert.ToDecimal(strAmount);
                    WithDraw(amount);
                }
                // Deposit
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.Write("Please Enter the amount you would like to deposit: ");
                    string strAmount = Console.ReadLine();
                    decimal amount = Convert.ToDecimal(strAmount);
                    Deposit(amount);
                }
                // Exit ATM
                else if (choice == "4")
                {
                    Console.Clear();
                    running = false;
                }
                // Invalid selection
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Selection.\n");
                }
            }
            Console.WriteLine("\nThank you for using Smith's Auto Teller!\n");
            PrintReceipt();
        }

        /// <summary>
        /// Keep Track of all of the transactions
        /// </summary>
        /// <param name="amount">The deposit / withdrawal amount</param>
        public static void Transactions(string amount)
        {
            transactions.Add(amount);
        }

        /// <summary>
        /// Prints out all of the transactions
        /// </summary>
        public static void PrintReceipt()
        {
            Console.WriteLine("Receipt:\n");
            foreach (var item in transactions)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nFinal Balance: {Balance:C}");
        }
    }
}
