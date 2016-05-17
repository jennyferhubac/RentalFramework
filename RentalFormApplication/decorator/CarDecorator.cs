using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.decorator;
using RentalFramework.entities;

namespace RentalFormApplication.decorator
{
    public class CarDecorator : AItemDecorator
    {
        private String Make;
        private String Model;
        private String Category;
        private Double Price;

        public CarDecorator(IItem item, String Make, String Model, String Category, Double Price)
            : base(item)
        {
            //base implement get/setter for ItemID
            this.Make = Make;
            this.Model = Model;
            this.Category = Category;
            this.Price = Price;
	    }

        public String getMake()
        {
            return Make;
        }


        public String getModel()
        {
            return Model;
        }



        public String getCategory()
        {
            return Category;
        }

  

        public double getPrice()
        {
            return Price;
        }

    }
}
