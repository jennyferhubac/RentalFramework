using RentalFramework.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.builder;

namespace RentalFramework.builder
{
    public abstract class ARequestBuilder : IBuilder<ARequest>
    {
        public abstract ARequest create();
        public abstract ARequestBuilder setRequester(AUser requester);

    }
}
