using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.builder
{
   
    public interface IBuilder<in T, out R>
    {
        R add(T value);
    }
}
