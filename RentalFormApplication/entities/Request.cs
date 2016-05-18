using RentalFramework.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFormApplication.entities
{
    public class Request : ARequest
    {

        
        private AUser respondent;
        public Request(string requestId)
        {
            base.setRequestID(requestId);
        }



        public Request(string requestId, AUser requester,List<IItem> items,AUser respondent )
        {
            base.setRequestID(requestId);
            base.setRequester(requester);
            base.setItems(items);
            this.respondent = respondent;

        }

        public AUser getRespondent()
        {
            return respondent;
        }





    }
}
