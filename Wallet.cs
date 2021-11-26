using System;

namespace Lektion2
{
    public class Wallet
    {
        // Mängden pengar i plånboken, får aldrig vara negativt
        private Kronor amount;

        // Skapar en tom plånbok
        public Wallet()
        {

        }

        // Skapar en plånbok med pengar i
        public Wallet(Kronor money)
        {
            Add(money);
        }

        /* 
         * Lägger till pengar till plånboken.
         */
        public void Add(Kronor money)
        {
            amount = amount.Add(money);
        }

        /*
         * Tar pengar ur plånboken
         * Det ska inte gå att ta ut mer pengar än vad som finns i plånboken
         */
        public void Remove(Kronor money)
        {
            amount = amount.Add(money);
        }

        /*
         * Tar bort alla pengar ur plånboken
         */
        public void RemoveAll()
        {
            amount = new Kronor();
        }
    }
}
