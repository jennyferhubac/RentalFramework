using RentalFramework.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFormApplication.entities
{
    public class Book : IItem
    {
        private String ItemID;

        public string getItemID()
        {
            return this.ItemID;
        }

        public void setItemID(string ItemID)
        {
            this.ItemID = ItemID;
        }
    }
}
