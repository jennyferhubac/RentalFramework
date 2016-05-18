using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RentalFramework.entities;
using RentalFramework.dto;

namespace RentalFramework.service
{
    interface ItemService
    {
        bool addItem(ItemDTO itemDTO);

        bool removeItem(ItemDTO itemDTO);
    }
}
