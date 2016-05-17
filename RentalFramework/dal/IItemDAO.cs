using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.entities;

namespace RentalFramework.dal
{
    public interface IItemDAO : IDAO<AItem, AItem>
    {
        bool addItem(AItem item);
        bool removeItem(AItem item);
    }
}
