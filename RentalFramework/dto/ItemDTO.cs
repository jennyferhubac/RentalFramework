using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.dto
{

    public abstract class ItemDTO : IDTO
    {
        private String ItemID;

        public String getItemID()
        {
            return ItemID;
        }
        public void setItemID(String ItemID)
        {
            this.ItemID = ItemID;
        }

        private String ItemType;

        public String getItemType()
        {
            return ItemType;
        }
        public void setItemType(String ItemType)
        {
            this.ItemType = ItemType;
        }
    }
}
