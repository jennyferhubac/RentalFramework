using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.factories;
using RentalFramework.entities;
using RentalFramework.dto;

using RentalFormApplication.entities;

using System.Runtime.CompilerServices;


namespace RentalFormApplication.factories
{
    public class TransactionFactory : ITransactionFactory
    {
        //static unique instance
        private static ITransactionFactory factory;

        //private constructor
        private TransactionFactory()
        {
            
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ITransactionFactory getFactory()
        {
            if (factory == null)
             return factory = new TransactionFactory();
            else return factory;
        }

        public ATransaction create(ATransactionDTO dto)
        {
            ATransaction transaction = null;
            Random rand = new Random();

            switch(dto.Type)
            {
                case "CHECKIN": transaction = new CheckinTransaction(rand.Next(1,100).ToString(), DateTime.Now, dto.Request);
                    break;
                case "CHECKOUT": transaction = new CheckoutTransaction(rand.Next(1, 100).ToString(), DateTime.Now, dto.Request);
                    break;
            }

            return transaction;
        }
    }
}
