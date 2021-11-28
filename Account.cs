using System;

namespace Lektion2
{
    public class Account
    {
        /*
         * Mängden pengar i kontot.
         * Får vara negativt, men aldrig minska när det redan är negativt
         * Exempel:
         * 5 - 10 är tillåtet
         * -10 + 5 är tillåtet
         * -1 + 7 är tillåtet
         * -10 -5 är inte tillåtet
         */
        private Kronor _amount = new Kronor();
        public Kronor amount
        {
            get => _amount;
            set => _amount = value;
        }

        // Skapar ett tomt konto
        public Account()
        {

        }

        // Skapar ett konto med pengar i
        public Account(Kronor money)
        {
            Deposit(money);
        }

        /* 
         * Sätter in pengar på kontot.
         */
        public void Deposit(Kronor money)
        {
            amount = amount.Add(money);
        }

        /*
         * Tar ut pengar ur kontot
         * Minst 90% av pengarna måste finnas på kontot för att uttaget ska godkännas
         */
        public void Withdraw(Kronor money)
        {
            if (!(amount.Öre >= (money.Öre * 90 / 100)))
            {
                throw new ArgumentException("Insufficient balance");
            }
            amount = amount.Subtract(money);
        }

        /*
         * Tar bort alla pengar ur plånboken
         */
        public void RemoveAll()
        {
            amount = new Kronor();
        }

        /*
         * Överför pengar mellan två konton
         * Pengarna ska tas bort från from-kontot och läggas till till to-kontot
         * Övriga regler ska också upprätthållas
         */
        public static void Transfer(Account from, Account to, Kronor amount)
        {
            from.amount = amount;
            to.amount = amount;
        }
    }
}
