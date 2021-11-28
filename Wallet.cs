using System;

namespace Lektion2
{
    public class Wallet
    {
        // Mängden pengar i plånboken, får aldrig vara negativt
        public Kronor amount = new Kronor();
        

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
            if (!(amount.Öre >= money.Öre))
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
    }
}
