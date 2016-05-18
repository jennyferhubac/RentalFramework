using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.dal;
using RentalFramework.factories;
using RentalFramework.dto;
using RentalFramework.entities;

namespace RentalFramework.services
{
    public abstract class AbstractTransactionService : ITransactionService
    {
        protected IDAOImpl<ATransaction,ATransaction> tranDAOImpl;
        private ITransactionFactory tranFactory;

        public AbstractTransactionService(IDAOImpl<ATransaction, ATransaction> tranDAOImpl, ITransactionFactory tranFactory)
        {
            if (tranDAOImpl != null && tranFactory != null)
            {
                this.tranDAOImpl = tranDAOImpl;
                this.tranFactory = tranFactory;
            }
            else
            {
                throw new System.ArgumentException("Provided argument is null");
            }
        }

        public ITransactionFactory getTranFactory()
        {
            return tranFactory;
        }

        public IDAOImpl<ATransaction, ATransaction> getTranDAOImpl()
        {
            return tranDAOImpl;
        }

        public abstract bool saveTransaction(ATransactionDTO dto);
        public abstract bool saveTransaction(ATransaction dto);

        public abstract ATransaction findTransaction(string transactionID);

        public abstract IEnumerable<ATransaction> getAllTransactions();
    }
}
