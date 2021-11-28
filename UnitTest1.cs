using System;
using Xunit;
using Lektion2;

namespace Lektion2.Tests
{
    public class UnitTest1
    {

        [Fact] // IsZero() checked if amount is 0 and neither above or below zero
        public void TestIsEmpty()
        {
            var kronor = new Kronor(0, 0);
            Assert.True(kronor.isZero());
            Assert.False(kronor.isNegative());
            Assert.False(kronor.IsPositive());
        }

        [Fact] //isNegative() checked if amount was above 0, changed from greater than, to less than 0
        public void TestIsNegative()
        {
            var kronor = new Kronor(10, 10);
            Assert.False(kronor.isNegative());
        }

        [Fact] // Checking KronorPart(), öre needs to be divided by 100, not 10
        public void TestKronorPart()
        {
            int amount = 10;
            var kronor = new Kronor(amount, 0);

            Assert.Equal(kronor.KronorPart(), amount);
        }

        [Fact] // Checking KronorPart(), öre needs to be modulus by 100, not 10
        public void TestÖrenPart()
        {
            int amount = 10;
            var kronor = new Kronor(100, amount);

            Assert.Equal(kronor.ÖrenPart(), amount);
        }

        [Fact] // Checking Add(), forgot to multiply first kronorPart() by 100
        public void TestKronorAdd()
        {
            var kronor = new Kronor(10, 5);
            var kronor2 = new Kronor(5, 0);
            var kronor3 = new Kronor(5, 0);

            Assert.Equal(kronor.KronorPart(), kronor2.Add(kronor3).KronorPart());
        }

        [Fact] // Checking Subtract(), forgot to multiply first kronorPart() by 100
        public void TestKronorSubtract()
        {
            var kronor = new Kronor(0, 0);
            var kronor2 = new Kronor(5, 0);
            var kronor3 = new Kronor(5, 0);

            Assert.Equal(kronor.KronorPart(), kronor2.Subtract(kronor3).KronorPart());
        }
    }
}
