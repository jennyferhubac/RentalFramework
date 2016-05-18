using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.dto;
using RentalFramework.entities;

namespace RentalFormApplication.dto
{
    public class TransactionDTO : ATransactionDTO
    {

        public TransactionDTO(string transactionID, DateTime dateTime, double totalAmount, double penaltyAmount, string type, ARequest request)
        {
            TransactionID = transactionID;
            TransactionDate = dateTime;
            TotalAmount = totalAmount;
            PenaltyAmount = penaltyAmount;
            Type = type;
            Request = request;
        }
    }
}
