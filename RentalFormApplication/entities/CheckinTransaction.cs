﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalFramework.entities;

namespace RentalFormApplication.entities
{
    public class CheckinTransaction : ATransaction
    {
        public CheckinTransaction(DateTime transactionDate, ARequest request) : base(transactionDate, request)
        {

        }
        public override double getTotal()
        {
            return 0;
        }

        public override double getPenalty()
        {
            return 0;
        }

        public override string getType()
        {
            return "CHECKIN";
        }
    }
}