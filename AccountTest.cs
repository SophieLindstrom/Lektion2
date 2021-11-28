using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Lektion2;

namespace Lektion2.Tests
{
    public class AccountTest
    {
        [Fact]
        public void Account_ChecksIfAccountIsEmpty()
        {
            var account = new Account();
            Assert.True(account.amount.isZero());
        }

        [Fact]
        public void Deposit_InsertMoney()
        {
            var account = new Account(new Kronor(10, 0));
            account.Deposit(new Kronor(10, 0));
            var accountInsertedMoney = new Account(new Kronor(20, 0));
            Assert.Equal(accountInsertedMoney.amount.KronorPart(), account.amount.KronorPart());

        }

        [Fact]
        public void Withdraw_ReturnValueLeftInAccount()
        {
            var account = new Account(new Kronor(10, 0));
            account.Withdraw(new Kronor(9, 0));
            var MoneyLeft = new Account(new Kronor(1, 0));
            Assert.Equal(MoneyLeft.amount.KronorPart(), account.amount.KronorPart());

        }

        [Fact]
        public void Withdraw_Overdraft()
        {
            var account = new Account();
            account.amount = new Kronor(50, 0);
            var kronor = new Kronor(70, 0);

            
            Action act = () => account.Withdraw(kronor);

           
            Assert.Throws<ArgumentException>(act);

        }

        [Fact]
        public void Transfer_Test()
        {

            var kronor = new Kronor(11, 0);
            var account1 = new Account(kronor);
            var account2 = new Account();

            Account.Transfer(account1, account2, kronor);
            Assert.True(account1.amount.isZero());
            Assert.True(account2.amount.IsPositive());

        }
        [Fact]
        public void Transfer_FromToAccount_ReturnAmount()
        {
            var kronor = new Kronor(11, 0);
            var account1 = new Account(kronor);
            var account2 = new Account();

            Account.Transfer(account1, account2, kronor);
            var actualValue1 = account1.amount.KronorPart();
            var actualValue2 = account2.amount.KronorPart();

            Assert.Equal(0, actualValue1);
            Assert.Equal(11, actualValue2);
        }
        [Fact]
        public void Test_RemoveFromAccount()
        {
            var account = new Account(new Kronor(10,5));

            account.RemoveAll();

            var actualValue = account.amount.KronorPart();

            Assert.Equal(0, actualValue);

        }


    }
}

