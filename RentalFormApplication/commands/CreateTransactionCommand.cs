using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.dto;
using RentalFramework.services;
using RentalFramework.commands;
using RentalFramework.entities;
using RentalFramework.factories;


using RentalFormApplication.factories;

namespace RentalFormApplication.commands
{
    public class CreateTransactionCommand : AbstractTransactionCommand
    {
        private ATransactionDTO transactionDto;
        ITransactionFactory tran = TransactionFactory.getFactory();

        public CreateTransactionCommand(AbstractTransactionService transactionService, ATransactionDTO transactionDto) : base(transactionService)
        {
            this.transactionDto = transactionDto;
        }

        public override void exeute()
        {
            //create transaction object using DTO object
            ATransaction atran = tran.create(transactionDto);
            
            transactionService.saveTransaction(atran);

        }
    }
}
