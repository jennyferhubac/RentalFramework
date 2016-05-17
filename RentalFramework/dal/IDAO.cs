using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.dal
{
    public interface IDAO<in T, out R>
    {
        bool add(T t);

        R find(String name);

        IEnumerable<R> getAll();
    }
}
