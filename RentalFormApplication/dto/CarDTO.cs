using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.dto;

namespace RentalFormApplication.dto
{
    public class CarDTO : ItemDTO
    {
        private String Make;
        private String Model;
        private String Category;
        private Double Price;

        public String getMake()
        {
            return Make;
        }



        public void setMake(String make)
        {
            Make = make;
        }



        public String getModel()
        {
            return Model;
        }



        public void setModel(String model)
        {
            Model = model;
        }



        public String getCategory()
        {
            return Category;
        }



        public void setCategory(String category)
        {
            Category = category;
        }



        public double getPrice()
        {
            return Price;
        }



        public void setPrice(double price)
        {
            Price = price;
        }
    }
}
