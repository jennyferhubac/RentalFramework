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
        public bool addItem(AItem item)
        {
            if (!isExist(item.getItemID()))
            {
                DBTables.ITEM_TABLE.Add(item);
                return true;
            }

            return false;
        }


        //Override
        public bool removeItem(AItem item)
        {

            if (isExist(item.getItemID()))
            {
                DBTables.ITEM_TABLE.Remove(item);
                return true;
            }

            return false;
        }

        public AItem find(String ItemID)
        { 
            if (isExist(ItemID))
            {
                return DBTables.ITEM_TABLE.Where(x => x.getItemID().Equals(ItemID)).FirstOrDefault();
            }
            return null;
        }

    

        IEnumerable<AItem> IDAO<AItem, AItem>.getAll()
        {
            return DBTables.ITEM_TABLE;
        }

        public bool add(AItem t)
        {
            throw new NotImplementedException();
        }
    }
}
