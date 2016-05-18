using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.dal;
using RentalFramework.entities;

namespace RentalFormApplication.dal
{
    public class TransactionDAOImpl : IDAOImpl<ATransaction,ATransaction>
    {

        public bool add(ATransaction t)
        {
            throw new NotImplementedException();
        }

        public void delete(string id)
        {
            throw new NotImplementedException();
        }

        public ATransaction find(string name)
        {
            throw new NotImplementedException();
        }

        public ATransaction update(ATransaction t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ATransaction> getAll()
        {
            throw new NotImplementedException();
        }
    }
}
