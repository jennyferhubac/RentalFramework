using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.entities
{
    public abstract class AItem
    {
        private String ItemID;

        public AItem(String ItemID): base()
        {
            
            this.ItemID = ItemID;
	    }

        public String getItemID()
        {
            return ItemID;
        }
        public void setItemID(String ItemID)
        {
            this.ItemID = ItemID;
        }
    
    }
}
