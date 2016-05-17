using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.entities;
using RentalFramework.dto;

namespace RentalFramework.factories
{
    public interface IItemFactory : IFactory<ItemDTO, IItem>
    {
        
         IItem create(ItemDTO dto);
    }
}
