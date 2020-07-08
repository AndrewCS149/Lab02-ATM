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
    }
}
