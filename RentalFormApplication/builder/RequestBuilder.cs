using RentalFramework.builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.entities;
using RentalFormApplication.entities;

namespace RentalFormApplication.builder
{
    public class RequestBuilder : ARequestBuilder
    {

        private String requestID;
        private AUser requester;
        private AUser respondent;
        private List<IItem> items = new List<IItem>();

        public ARequestBuilder setRequestID(String requestID)
        {
            this.requestID = requestID;
            return this;
        }

        public ARequestBuilder setRespondent(AUser respondent)
        {
            this.respondent = respondent;
            return this;
        }
        public override ARequestBuilder setRequester(AUser requester)
        {
            this.requester = requester;
            return this;
        }

        public ARequestBuilder addItem(IItem item)
        {
            this.items.Add(item);
            return this;
        }


        public override ARequest create()
        {
            return new Request(requestID, requester, items, respondent);
        }
    }
}
