using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.decorator;
using RentalFramework.entities;

namespace RentalFormApplication.decorator
{
    public class BookDecorator : AItemDecorator
    {
        private String Title;
        private String Description;
        private String Category;
        private Double NumBorrowDays;

        public BookDecorator(IItem item, String Title, String Description, String Category, Double NumBorrowDays)
            : base(item)
        {
            //base implement get/setter for ItemID
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
