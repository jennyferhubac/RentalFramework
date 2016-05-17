using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.entities;

namespace RentalFramework.dto
{
    public abstract class ATransactionDTO : IDTO
    {
        private String transactionID;

        private DateTime transactionDate;

        private Double totalAmount;

        private Double penaltyAmount;

        private ARequest request;

        public ARequest Request
        {
            get { return request; }
            set { request = value; }
        }

        public String TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }

        public DateTime TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }

        public Double TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public Double PenaltyAmount
        {
            get { return penaltyAmount; }
            set { penaltyAmount = value; }
        }
    }
}
