using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.factories;
using RentalFramework.entities;
using RentalFramework.dto;
using RentalFormApplication.entities;

namespace RentalFormApplication.factories
{
    public class ItemFactory : IItemFactory
    {
        private static IItemFactory factory = null;

        public static IItemFactory getFactory()
        {
            if (factory == null)
			    factory = new ItemFactory();
		    return factory;
        
        }

        public IItem create(ItemDTO dto)
        {
            IItem item = null;
            switch (dto.getItemType())
            {
                case "Book":
                    item = new Book();
                    item.setItemID(dto.getItemID());
                    break;
                case "Car":
                    item = new Car();
                    item.setItemID(dto.getItemID());
                    break;
            }
            return item;
        }
    }
}
