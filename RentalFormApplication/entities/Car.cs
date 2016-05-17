using RentalFramework.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFormApplication.entities
{
    public class Car : AItem
    {
        private String ItemID;
        private String Make;
        private String Model;
        private String Category;
        private Double Price;

        public Car(String ItemID,String Make,String Model,String Category,Double Price)
            : base(ItemID)
        {
            this.ItemID = ItemID;
            this.Make = Make;
            this.Model = Model;
            this.Category = Category;
            this.Price = Price;
	    }

        public String getItemId()
        {
            return this.ItemID;
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
