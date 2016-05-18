using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.dal;
using RentalFramework.entities;

using RentalFormApplication.database;

namespace RentalFormApplication.dal
{
    public class TransactionDAOImpl : IDAOImpl<ATransaction,ATransaction>
    {
        public bool isExist(string id)
        {
            return DBTables.TRANSACTION_TABLE.Any(trans => trans.getTransactionID().Equals(id));
        }

        public bool add(ATransaction t)
        {
            if(isExist(t.getTransactionID()))
            {
                return false;
            }
            else
            {
                DBTables.TRANSACTION_TABLE.Add(t);
                return true;
            }
        }

        public void delete(ATransaction t)
        {
           if(isExist(t.getTransactionID()))
           {
               DBTables.TRANSACTION_TABLE.Remove(t);
           }
        }

        public ATransaction find(string str)
        {
            if (isExist(str))
            {
                return DBTables.TRANSACTION_TABLE.Where(x => x.getTransactionID().Equals(str)).FirstOrDefault();
            }
            return null;
        }

        public ATransaction update(ATransaction t)
        {
            if(isExist(t.getTransactionID()))
            {
                ATransaction tran = find(t.getTransactionID());
                delete(tran);
                add(t);
            }
            return t;
        }

        public IEnumerable<ATransaction> getAll()
        {
            return DBTables.TRANSACTION_TABLE;
        }
    }
}
