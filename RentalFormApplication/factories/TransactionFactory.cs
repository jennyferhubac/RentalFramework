using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.factories;
using RentalFramework.entities;
using RentalFramework.dto;

namespace RentalFormApplication.factories
{
    public class TransactionFactory : ITransactionFactory
    {

        public ATransaction create(ATransactionDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
