using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.entities
{
    public abstract class ATransaction : ITransaction
    {
        private String transactionID;
        private DateTime transactionDate;



    }
}
