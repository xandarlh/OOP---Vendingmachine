using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Vendingmachine
{
    public class Transaction
    {
        private int amountEntered;       
        public int AmountEntered
        {
            get { return amountEntered; }
            set { amountEntered = value; }
        }
        private int amountReturn;
        public int AmountReturn
        {
            get { return amountReturn; }
            set { amountReturn = value; }
        }
        
        public Transaction(int amountEntered, int amountReturn)
        {
            this.AmountEntered = amountEntered;
            this.AmountReturn = amountReturn;
        }
        public Transaction()
        {

        }
           
        
    }
}
