﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.entities
{
    public interface IItem 
    {
        String getItemID();
        void setItemID(String ItemID);
    
    }
}
