using System;
using System.Security.Cryptography;

namespace ATM
{
    public class Program
    {
        static public decimal Balance = 1000;

        static void Main(string[] args)
        {

            //Console.WriteLine(ViewBalance());
            //Console.WriteLine(WithDraw(500));
            //Console.WriteLine(Deposit(1000));
            Interface();

        }

        /// <summary>
        /// Displays the current balance to the user
        /// </summary>
        /// <returns>The current balance</returns>
        public static decimal ViewBalance()
        {
            Console.WriteLine($"Current balance: {Balance} \n");
            return Balance;
        }

        /// <summary>
        /// Subtracts from the current balance
        /// </summary>
        /// <param name="amount">Amount to withdraw</param>
        /// <returns>The new balance</returns>
        public static decimal WithDraw(decimal amount)
        {
            Balance -= amount;
            Console.WriteLine($"Remaining balance: {Balance} \n");
            return Balance;
        }

        /// <summary>
        /// Adds to the current balance
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        /// <returns>The new balance</returns>
        public static decimal Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Remaining balance: {Balance} \n");
            return Balance;
        }

        /// <summary>
        /// ATM navigation. Displays ATM options and directs user to appropriate methods
        /// </summary>
        public static void Interface()
        {
            Console.WriteLine("Welcome to Smith's Auto Teller. \n");

            bool running = true;
            while (running == true)
            {
                Console.WriteLine("Please select from the following options:");
                Console.WriteLine("1) Check Your Balance \n" +
                                  "2) Make a Withdrawal \n" +
                                  "3) Make a Deposit \n" +
                                  "4) Exit");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    ViewBalance();
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.Write("Please Enter the amount you would like to withdraw: ");
                    string strAmount = Console.ReadLine();
                    decimal amount = Convert.ToDecimal(strAmount);
                    WithDraw(amount);
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Please Enter the amount you would like to deposit: ");
                    string strAmount = Console.ReadLine();
                    decimal amount = Convert.ToDecimal(strAmount);
                    Deposit(amount);
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    running = false;
                }
            }
            Console.WriteLine("\nThank you for using Smith's Auto Teller!");
        }
    }
}
