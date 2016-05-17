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
        public AItem create(ItemDTO dto)
        {
            AItem item = null;
            switch (dto.getItemType())
            {
                case "Book":
                    item = new Book(dto.getItemID(),String.Empty,String.Empty,String.Empty,0);
                    break;
                case "Car":
                    item = new Car(dto.getItemID(), String.Empty, String.Empty, String.Empty,0);
                    break;
            }
            return item;
        }
    }
}
