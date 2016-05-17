using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.entities;
using RentalFramework.dal;

namespace RentalFramework.dal
{
    public interface ITransactionDAO : IDAO<ATransaction, ATransaction>
    {
        bool add(ATransaction t);

        ATransaction find(String transactionID);

        IEnumerable<ATransaction> getAll();
    }
}
