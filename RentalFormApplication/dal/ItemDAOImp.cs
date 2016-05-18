using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.dal;
using RentalFormApplication.database;
using RentalFramework.entities;

namespace RentalFormApplication.dal
{
    public class ItemDAOImp : IItemDAO
    {

        public bool isExist(String ItemID)
        {
            return DBTables.ITEM_TABLE.Any(item => item.getItemID().Equals(ItemID));
        }

        //Override
        public bool addItem(IItem item)
        {
            if (!isExist(item.getItemID()))
            {
                DBTables.ITEM_TABLE.Add(item);
                return true;
            }

            return false;
        }


        //Override
        public bool removeItem(IItem item)
        {

            if (isExist(item.getItemID()))
            {
                DBTables.ITEM_TABLE.Remove(item);
                return true;
            }

            return false;
        }

        public IItem find(String ItemID)
        { 
            if (isExist(ItemID))
            {
                return DBTables.ITEM_TABLE.Where(x => x.getItemID().Equals(ItemID)).FirstOrDefault();
            }
            return null;
        }

    

        IEnumerable<IItem> IDAO<IItem, IItem>.getAll()
        {
            return DBTables.ITEM_TABLE;
        }

        public bool add(IItem t)
        {
            throw new NotImplementedException();
        }


        public void delete(string id)
        {
            throw new NotImplementedException();
        }

        public IItem update(IItem t)
        {
            throw new NotImplementedException();
        }
    }
}
