using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.entities
{
    public abstract class ATransaction : ITransaction
    {
        protected String transactionID;
        protected DateTime transactionDate;

        protected Double totalAmount;
        protected Double penaltyAmount;

        private ARequest request;

        public ATransaction()
        {

        }

        public ATransaction(DateTime transactionDate, ARequest request)
        {
            this.transactionDate = transactionDate;
            this.request = request;
        }

        public ARequest getRequest()
        {
            return request;
        }

        public void setRequest(ARequest request)
        {
            this.request = request;
        }

        public String getTransactionID()
        {
            return transactionID;
        }

        public void setTransactionID(String transactionID)
        {
            this.transactionID = transactionID;
        }

        public abstract double getTotal();
        public abstract double getPenalty();
    }
}
