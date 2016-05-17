using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.dto;
using RentalFramework.services;

namespace RentalFramework.commands
{
    public class CreateTransactionCommand : AbstractTransactionCommand
    {
        private ITransactionDTO transactionDto;

        public CreateTransactionCommand(ITransactionService transactionService, ITransactionDTO transactionDto) : base(transactionService)
        {
            this.transactionDto = transactionDto;
        }

        public override void exeute()
        {
            throw new NotImplementedException();
        }
    }
}
