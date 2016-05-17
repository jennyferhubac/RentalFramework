﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.commands
{
    interface IInvoker
    {
        void setCommand(ICommand command);

        void invokeCommand();
    }
}
