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
using RentalFormApplication.decorator;
using RentalFormApplication.dto;

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
                    IEnumerable<IItem> items = itemDAO.getAll();

                   items.ToList().ForEach(
                        x => { 
                            CarDTO pp=null;
                            if (x is CarDecorator)
                            {
                                pp = DTOConverterUtil.getPojoFromAItemToCar((CarDecorator)x);
                            resList.Add(pp);
                            }
                            
                        }
                        );
                  
                    return resList;
                }

                public List<ItemDTO> getAllBookItems()
                {
                    List<ItemDTO> resList = new List<ItemDTO>();
                    IEnumerable<IItem> items = itemDAO.getAll();

                    items.ToList().ForEach(
                         x =>
                         {
                             BookDTO pp = null;
                             if (x is BookDecorator)
                             {
                                 pp = DTOConverterUtil.getPojoFromAItemToBook((BookDecorator)x);
                                 resList.Add(pp);
                             }
                             
                         }
                         );

                    return resList;
                }


                public IItem decorateItem(ItemDTO itemDTO)
                {
                    IItem item = ItemFactory.getFactory().create(itemDTO);
                    IItem decoratedItem = null;
                    if (item is Car)
                    {
                        CarDTO carDTO = (CarDTO)itemDTO;
                        decoratedItem = new CarDecorator(item, carDTO.getMake(), carDTO.getModel(), carDTO.getCategory(), carDTO.getPrice());
                    }
                    else if (item is Book)
                    {
                        BookDTO bookDTO = (BookDTO)itemDTO;
                        decoratedItem = new BookDecorator(item, bookDTO.getTitle(), bookDTO.getDescription(), bookDTO.getCategory(), bookDTO.getNumBorrowDays());

                    }

                    return decoratedItem;
                }

                //override
                public override bool addItem(ItemDTO itemDTO)
                {
                    IItem decoratedItem = decorateItem(itemDTO);
                    
                    return itemDAO.addItem(decoratedItem);
                }

                //override
                public override bool removeItem(ItemDTO itemDTO)
                {
                    //IItem decoratedItem = decorateItem(itemDTO);
                    IItem Item = findItem(itemDTO.getItemID());
                    return itemDAO.removeItem(Item);
                }


                public IItem findItem(String ItemID)
                {
                    return itemDAO.find(ItemID);
                }



    }
}
