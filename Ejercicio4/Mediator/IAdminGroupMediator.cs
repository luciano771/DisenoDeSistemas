using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Mediator
{
    public interface IAdminGroupMediator
    {
        public void addColleage(IColleage colleage);
        public void reciveMessage(IColleage colleage, string Message, IColleage? colleageDestination);
        public void sendMessage(IColleage colleage, string Message, IColleage? colleageDestination);

    }
}
