using System;
using Xunit;
using Lektion2;

namespace Lektion2.Tests
{
    public class KronorTest
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
            var kronor = new Kronor(-10, 0);
            Assert.True(kronor.isNegative());
            Assert.False(kronor.isZero());
            Assert.False(kronor.IsPositive());
        }

        [Fact] //isNegative() checked if amount was above 0, changed from greater than, to less than 0
        public void TestIsPositive()
        {
            var kronor = new Kronor(10, 5);
            Assert.False(kronor.isNegative());
            Assert.False(kronor.isZero());
            Assert.True(kronor.IsPositive());
        }
        [Fact]
        public void KronorPart_ReturnsTheKronorPartOfTheKronor()
        {
            //arrange
            Kronor myKronor = new Kronor(5, 0);

            //act
            var actualValue = myKronor.KronorPart();

            //assert
            Assert.Equal(5, actualValue);
        }
        [Fact]
        public void ÷renPart_ReturnsThe÷renPartOfTheKronor()
        {
            //arrange
            Kronor myKronor = new Kronor(1, 5);

            //act
            var actualValue = myKronor.÷renPart();

            //assert
            Assert.Equal(5, actualValue);
        }
                
            [Fact] // Checking Add(), forgot to multiply first kronorPart() by 100
            public void TestKronorAdd()
        {
            var kronor = new Kronor(10, 0);
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
