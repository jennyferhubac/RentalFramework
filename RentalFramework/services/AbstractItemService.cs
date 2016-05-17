﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.factories;
using RentalFramework.dal;
using RentalFramework.entities;

namespace RentalFramework.service
{
    public abstract class AbstractItemService : ItemService 
    {
        protected IItemDAO itemDAO;
        private IItemFactory factory;

        public AbstractItemService(IItemDAO itemDAO, IItemFactory factory)
        {
            if (itemDAO != null && factory != null)
            {
                this.itemDAO = itemDAO;
			this.factory = factory;
		}else{
            throw new System.ArgumentException("Provided argument is null");
		}
	}

        public abstract bool addItem(AItem item);

        public abstract bool removeItem(AItem item);

        public void setFactory(IItemFactory factory)
        {
            this.factory = factory;
        }
    }
}