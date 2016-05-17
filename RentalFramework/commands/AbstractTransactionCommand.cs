using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.services;

namespace RentalFramework.commands
{
    abstract class AbstractTransactionCommand : ICommand
    {
        protected ITransactionService transactionService;

        public AbstractTransactionCommand(ITransactionService transactionService) : base()
        {
            this.transactionService = transactionService;
        }

        public abstract void exeute();
    }
}
