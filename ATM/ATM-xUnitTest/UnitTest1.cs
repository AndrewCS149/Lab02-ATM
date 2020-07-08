using System;
using Xunit;
using static ATM.Program;

namespace ATM_xUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestViewBalance()
        {
            decimal value = ViewBalance();
            Assert.Equal(1000, value);
        }
    }
}
