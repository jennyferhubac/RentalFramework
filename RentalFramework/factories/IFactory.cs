using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.factories
{
    interface IFactory<in T, out R>
    {
        R create(T item);
    }
}
