using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.service;
using RentalFormApplication.dal;
using RentalFormApplication.factories;
using RentalFramework.entities;
using RentalFramework.dal;
using RentalFramework.dto;
using RentalFormApplication.util;
using RentalFormApplication.entities;

namespace RentalFormApplication.Service
{
    //Service classes are singletones
    public class ItemServiceImp : AbstractItemService
    {
        private static ItemServiceImp instance;
       

        private ItemServiceImp()
            : base(new ItemDAOImp(), new ItemFactory())
        {
		
	    }

        public static ItemServiceImp getInstance()
        {
		if (instance == null)
            instance = new ItemServiceImp();
		return instance;
	   }


                public List<ItemDTO> getAllCarItems()
                {
                    List<ItemDTO> resList = new List<ItemDTO>();
                    IEnumerable<AItem> items = itemDAO.getAll();

                   items.ToList().ForEach(
                        x => { 
                            ItemDTO pp=null;
                            if (x is Car)
                            {
                            pp = DTOConverterUtil.getPojoFromAItemToCar((Car)x);
                            resList.Add(pp);
                            }
                            
                        }
                        );
                  
                    return resList;
                }

                public List<ItemDTO> getAllBookItems()
                {
                    List<ItemDTO> resList = new List<ItemDTO>();
                    IEnumerable<AItem> items = itemDAO.getAll();

                    items.ToList().ForEach(
                         x =>
                         {
                             ItemDTO pp = null;
                             if (x is Book)
                             {
                                 pp = DTOConverterUtil.getPojoFromAItemToBook((Book)x);
                                 resList.Add(pp);
                             }
                             
                         }
                         );

                    return resList;
                }


                //override
                public override bool addItem(AItem item)
                {
                    return itemDAO.addItem(item);
                }

                //override
                public override bool removeItem(AItem item)
                {
                    return itemDAO.removeItem(item);
                }


                public AItem findItem(String ItemID)
                {
                    return itemDAO.find(ItemID);
                }



    }
}
