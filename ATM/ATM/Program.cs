using System;
using System.Security.Cryptography;

namespace ATM
{
    class Program
    {
        static public decimal Balance = 1000;

        static void Main(string[] args)
        {

            Console.WriteLine(ViewBalance());
            Console.WriteLine(WithDraw(500));
            Console.WriteLine(Deposit(1000));

        }

        /// <summary>
        /// Displays the current balance to the user
        /// </summary>
        /// <returns>The current balance</returns>
        public static decimal ViewBalance()
        {
            return Balance;
        }

        /// <summary>
        /// Subtracts from the current balance
        /// </summary>
        /// <param name="amount">Amount to withdraw.</param>
        /// <returns>The new balance</returns>
        public static decimal WithDraw(decimal amount)
        {
            Balance -= amount;
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
            return Balance;
        }
    }
}
