using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.services;

namespace RentalFramework.commands
{
    public abstract class AbstractTransactionCommand : ICommand
    {
        protected AbstractTransactionService transactionService;

        public AbstractTransactionCommand(AbstractTransactionService transactionService) : base()
        {
            this.transactionService = transactionService;
        }

        public abstract void exeute();
    }
}
