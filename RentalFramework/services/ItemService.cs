using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RentalFramework.entities;

namespace RentalFramework.service
{
    interface ItemService
    {
        bool addItem(AItem item);

        bool removeItem(AItem item);
    }
}
