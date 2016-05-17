using RentalFramework.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFormApplication.entities
{
    class Book : AItem
    {
        private String ItemID;
        private String Title;
        private String Description;
        private String Category;
        private Double NumBorrowDays;

        public Book(String ItemID, String Title, String Description, String Category, Double NumBorrowDays)
            : base(ItemID)
        {
            this.ItemID = ItemID;
            this.Title = Title;
            this.Description = Description;
            this.Category = Category;
            this.NumBorrowDays = NumBorrowDays;
	    }


        public String getTitle()
        {
            return Title;
        }
        public String getDescription()
        {
            return Description;
        }
        public String getCategory()
        {
            return Category;
        }
        public Double getNumBorrowDays()
        {
            return NumBorrowDays;
        }

    }
}
