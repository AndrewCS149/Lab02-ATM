using System;
using Xunit;
using static ATM.Program;

namespace ATM_xUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalanceTrue()
        {
            Balance = 100;
            decimal result = ViewBalance();
            Assert.Equal(Balance, result);
        }

        [Fact]
        public void ViewBalanceFalse()
        {
            Balance = 100;
            decimal result = ViewBalance();
            Assert.NotEqual(200, result);
        }

        [Fact]
        public void WithDrawTrue()
        {
            Balance = 2000;
            decimal amount = 500;
            decimal result = WithDraw(amount);
            Assert.Equal(1500, result);
        }

        [Fact]
        public void WithDrawFalse()
        {
            Balance = 2000;
            decimal amount = 500;
            decimal result = WithDraw(amount);
            Assert.NotEqual(2000, result);
        }

        [Fact]
        public void DepositTrue()
        {
            Balance = 2000;
            decimal amount = 500;
            decimal result = Deposit(amount);
            Assert.Equal(2500, result);
        }

        [Fact]
        public void DepositFalse()
        {
            Balance = 2000;
            decimal amount = 500;
            decimal result = Deposit(amount);
            Assert.NotEqual(3000, result);
        }
    }
}
