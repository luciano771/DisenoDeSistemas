using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Mediator
{
    public interface IColleage
    {
        public void postMessage(string Message, IColleage? colleageDestination);
        public void takeMessage(string Message);
    }
}
