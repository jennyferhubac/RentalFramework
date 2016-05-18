using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.dal
{
    public interface IDAOImpl<in T, out R> : IDAO<T, R>
    {
        bool add(T t);

        void delete(String id);

        R find(String name);

        R update(T t);

        IEnumerable<R> getAll();
    }
}
