using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Mediator
{
    public class AdminGroupConcreateMediator : IAdminGroupMediator
    {
        List<IColleage> colleages = new List<IColleage>();

        public void addColleage(IColleage colleage)
        {
            colleages.Add(colleage);
        }

        public void reciveMessage(IColleage i, string Message, IColleage? colleageDestination)
        {
            System.Console.WriteLine("Soy el administrador del grupo. Recibi el siguiente mensaje: " + Message);
            if (colleageDestination == null)
            {
                sendMessage(i, Message, null);
            }
            else
            {
                sendMessage(i, Message, colleageDestination); 
            }
        }

        public void sendMessage(IColleage i, string Message, IColleage? colleageDestination)
        {
            if (colleageDestination == null)
            {
                foreach (var colleage in colleages) { colleage.takeMessage(Message); }
            }
            else
            {
                int index = colleages.LastIndexOf(colleageDestination);
                IColleage newColleage = colleages[index];
                newColleage.takeMessage(Message);
            }
            
        }
 
    }
}
