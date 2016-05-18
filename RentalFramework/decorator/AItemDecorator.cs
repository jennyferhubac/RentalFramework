using RentalFramework.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.decorator
{
    public abstract class AItemDecorator : IItem
    {

        private String ItemID;

        public AItemDecorator(IItem item)
            : base()
        {
            this.ItemID = item.getItemID();
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
