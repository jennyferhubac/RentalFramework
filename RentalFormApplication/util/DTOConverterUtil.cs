using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.dto;
using RentalFormApplication.dto;
using RentalFormApplication.entities;
using RentalFormApplication.decorator;

namespace RentalFormApplication.util
{
    class DTOConverterUtil
    {

        public static CarDTO getPojoFromAItemToCar(CarDecorator item)
        {
            CarDTO pp = new CarDTO();
            pp.setItemID(item.getItemID());
            pp.setItemType("Car");
            pp.setCategory(item.getCategory());
            pp.setMake(item.getMake());
            pp.setModel(item.getModel());
            pp.setPrice(item.getPrice());
            return pp;
        }


        public static BookDTO getPojoFromAItemToBook(BookDecorator item)
        {
            BookDTO pp = new BookDTO();
            pp.setItemID(item.getItemID());
            pp.setItemType("Book");
            pp.setTitle(item.getTitle());
            pp.setDescription(item.getDescription());
            pp.setCategory(item.getCategory());
            pp.setNumBorrowDays(item.getNumBorrowDays());
            return pp;
        }




    }
}
