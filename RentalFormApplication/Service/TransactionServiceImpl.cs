using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.services;
using RentalFramework.dto;
using RentalFramework.entities;

using RentalFormApplication.factories;
using RentalFormApplication.dal;

namespace RentalFormApplication.Service
{
    public class TransactionServiceImpl : AbstractTransactionService
    {
        private static TransactionServiceImpl service;
        private ATransaction atran;
        private TransactionDAOImpl tranDAOImpl; 


        private TransactionServiceImpl() : base(new TransactionDAOImpl(), TransactionFactory.getFactory())
        {
            tranDAOImpl = (TransactionDAOImpl)getTranDAOImpl();
        }

        public static TransactionServiceImpl getService()
        {
            if (service == null)
                return service = new TransactionServiceImpl();
            return service;
        }

        public override bool saveTransaction(ATransactionDTO dto)
        {
            atran = getTranFactory().create(dto);
            
            return tranDAOImpl.add(atran);
        }

        public override bool saveTransaction(ATransaction atran)
        {
            return tranDAOImpl.add(atran);
        }

        public override ATransaction findTransaction(string transactionID)
        {
            return tranDAOImpl.find(transactionID);
        }

        public override IEnumerable<ATransaction> getAllTransactions()
        {
            return tranDAOImpl.getAll();
        }
    }
}
