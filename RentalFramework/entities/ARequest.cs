using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.entities
{
    public abstract class ARequest : IRequest
    {
        private String requestID;
        protected List<IItem> arrItems;

        public ARequest(String requestID)
        {
            this.requestID = requestID;
            arrItems = new List<IItem>();
        }

        public String RequestID
        {
            get { return requestID; }
            set { requestID = value; }
        }

        public abstract void addItem(IItem item);

        
    }
}
