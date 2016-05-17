using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.entities
{
    public interface ITransaction
    {
        ARequest getRequest();
        void setRequest(ARequest request);
        double getTotal();
        double getPenalty();
    }
}
