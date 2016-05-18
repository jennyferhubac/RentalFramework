﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.entities;

namespace RentalFramework.builder
{

    public interface IBuilder<T>
    {
        T create();

    }
}
