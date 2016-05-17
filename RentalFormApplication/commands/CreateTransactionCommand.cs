using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.dto;
using RentalFramework.services;
using RentalFramework.commands;

namespace RentalFormApplication.commands
{
    public class CreateTransactionCommand : AbstractTransactionCommand
    {
        private ATransactionDTO transactionDto;

        public CreateTransactionCommand(ITransactionService transactionService, ATransactionDTO transactionDto) : base(transactionService)
        {
            this.transactionDto = transactionDto;
        }

        public override void exeute()
        {
            throw new NotImplementedException();
        }
    }
}
