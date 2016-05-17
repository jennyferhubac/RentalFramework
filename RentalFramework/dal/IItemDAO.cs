using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.entities;

namespace RentalFramework.dal
{
    public interface IItemDAO : IDAO<IItem, IItem>
    {
        bool addItem(IItem item);
        bool removeItem(IItem item);
    }
}
