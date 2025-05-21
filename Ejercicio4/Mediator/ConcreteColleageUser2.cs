using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Mediator
{
    public class ConcreteColleageUser2 : IColleage
    {
        public string userName { get; set; }

        private IAdminGroupMediator adminGroupMediator;
        public ConcreteColleageUser2(string userName, IAdminGroupMediator adminGroupMediator)
        {
            this.userName = userName;
            this.adminGroupMediator = adminGroupMediator;
        }
        public void postMessage(string Message, IColleage? colleageDestination)
        {
            adminGroupMediator.reciveMessage(this, Message, colleageDestination);
        }
        public void takeMessage(string Message)
        {
            System.Console.WriteLine("Soy " + userName + ". Recibi el siguiente mensaje: " + Message);
             
        }
    }
}
