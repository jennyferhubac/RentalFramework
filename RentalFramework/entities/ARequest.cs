using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.entities
{
    public abstract class ARequest : IRequest
    {
        private string requestID;
        private AUser requester;
        private List<IItem> arrItems;
        public void setRequester(AUser requester)
        {
            this.requester = requester;
        }
        public AUser getRequester()
        {
            return requester;
        }

        public void setItems(List<IItem> arrItems)
        {
            this.arrItems = arrItems;
        }

        public List<IItem> getItems()
        {
            return this.arrItems;
        }

        public string getRequestID()
        {
            return requestID;
        }

        public void setRequestID(string requestID)
        {
            this.requestID = requestID;
        }

    }
}
