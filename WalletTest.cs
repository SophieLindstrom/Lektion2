using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Lektion2;
namespace Lektion2.Tests
{
    public class WalletTest
    {
        [Fact]
        public void Wallet_ChecksIfWalletIsEmpty()
        {
            var wallet = new Wallet();
            Assert.True(wallet.amount.isZero());
        }

        [Fact]
        public void Wallet_ChecksIfMoneyIsAddedToWallet()
        {
            var wallet = new Wallet(new Kronor(0,0));
            var kronor = new Kronor(10, 0);
            wallet.Add(kronor);
           
            var actualValue = wallet.amount.KronorPart();

            Assert.False(wallet.amount.isZero());
            Assert.True(wallet.amount.IsPositive());
            Assert.False(wallet.amount.isNegative());

            Assert.Equal(10, actualValue);
        }

        [Fact]
        public void Remove_MoneyFromWallet()
        {
            var wallet = new Wallet(new Kronor(10, 0));
            var kronor = new Kronor(10, 0);
            wallet.Remove(kronor);

            var actualValue = wallet.amount.KronorPart();
            Assert.Equal(0, actualValue);
        }

        [Fact]
        public void Remove_MoneyFromWalletNegativeValue()
        {
            var wallet = new Wallet(new Kronor(10, 0));
            var kronor = new Kronor(11, 0);

            Action act = () => wallet.Remove(kronor);

            Assert.Throws<ArgumentException>(act);
        }
        [Fact]
        public void RemoveAll_MoneyFromWallet()
        {
            var wallet = new Wallet(new Kronor(10, 0));
            
            wallet.RemoveAll();

            var actualValue = wallet.amount.KronorPart();
            Assert.Equal(0, actualValue);
        }

    }
}
