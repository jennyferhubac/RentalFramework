using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.entities;
using RentalFramework.dal;

namespace RentalFramework.dal
{
    public interface ITransactionDAO : IDAO<ITransaction, ITransaction>
    {
        bool add(ITransaction t);

        ITransaction find(String name);

        List<ITransaction> getAll();
    }
}
