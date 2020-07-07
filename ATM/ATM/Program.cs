using System;

namespace ATM
{
    class Program
    {
        static public decimal Balance = 1000;

        static void Main(string[] args)
        {

            Console.WriteLine(ViewBalance());
            Console.WriteLine(WithDraw(500));

        }

        /// <summary>
        /// Displays the current balance to the user.
        /// </summary>
        /// <returns>The current balance.</returns>
        public static decimal ViewBalance()
        {
            return Balance;
        }

        /// <summary>
        /// Subtracts from the Balance.
        /// </summary>
        /// <param name="amount">Amount to withdraw.</param>
        /// <returns>The new Balance.</returns>
        public static decimal WithDraw(decimal amount)
        {
            return Balance - amount;
        }
    }
}
