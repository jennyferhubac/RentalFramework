using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.dto;
using RentalFramework.entities;

namespace RentalFramework.factories
{
    public interface ITransactionFactory : IFactory<ITransactionDTO, ITransaction>
    {
       ITransaction create(ITransactionDTO dto);
    }
}
