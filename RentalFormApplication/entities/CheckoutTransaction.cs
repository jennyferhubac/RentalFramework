using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.entities;

namespace RentalFormApplication.entities
{
    public class CheckoutTransaction : ATransaction
    {
        public CheckoutTransaction(string transactionID, DateTime transactionDate, ARequest request) : base(transactionDate, request)
        {
            setTransactionID(transactionID);
        }
        public override double getTotal()
        {
            return 0;
        }

        public override double getPenalty()
        {
            return 0;
        }


        public override string getType()
        {
            return "CHECKOUT";
        }

        public override string ToString()
        {
            return "[Transaction ID: " + transactionID + " Date: " + transactionDate + "]";
        }
    }
}
