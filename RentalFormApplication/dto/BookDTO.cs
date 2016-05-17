using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.dto;

namespace RentalFormApplication.dto
{
    public class BookDTO : ItemDTO
    {
        private String Title;
        private String Description;
        private String Category;
        private Double NumBorrowDays;


        public String getTitle()
        {
            return Title;
        }
        public void setTitle(String title)
        {
            Title = title;
        }
        public String getDescription()
        {
            return Description;
        }
        public void setDescription(String description)
        {
            Description = description;
        }
        public String getCategory()
        {
            return Category;
        }
        public void setCategory(String category)
        {
            Category = category;
        }
        public Double getNumBorrowDays()
        {
            return NumBorrowDays;
        }
        public void setNumBorrowDays(Double numBorrowDays)
        {
            NumBorrowDays = numBorrowDays;
        }
    }
}
