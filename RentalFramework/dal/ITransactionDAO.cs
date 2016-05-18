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

        void delete(String id);

        ATransaction find(String transactionID);

        ATransaction update(ATransaction t);

        IEnumerable<ATransaction> getAll();
    }
}
