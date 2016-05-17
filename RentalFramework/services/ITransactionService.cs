using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.dto;
using RentalFramework.entities;

namespace RentalFramework.services
{
    interface ITransactionService
    {
        bool saveParty(ITransactionDTO dto); 

        ITransaction findParty(String email);

        IEnumerable<ITransactionDTO> getAllParties();
    }
}
