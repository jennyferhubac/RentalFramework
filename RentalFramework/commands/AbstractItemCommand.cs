using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.commands
{
    abstract class AbstractItemCommand : ICommand
    {
        protected AbstractItemCommand serviceA;

        public AbstractItemCommand(AbstractItemCommand serviceA)
            : base()
        {

            this.serviceA = serviceA;
        }

        //Override
        public abstract void execute();



        public void exeute()
        {
            throw new NotImplementedException();
        }
    }
}
