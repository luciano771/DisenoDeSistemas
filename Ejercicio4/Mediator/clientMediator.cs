using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Mediator
{
    public class clientMediator
    {
        public static void Main(string[] args)
        {
             
            AdminGroupConcreateMediator adminGroupConcreateMediator = Singleton.getInstance();
            ConcreteColleageUser1 concreteColleageUser1 = new ConcreteColleageUser1("usuario1",adminGroupConcreateMediator);  
            ConcreteColleageUser2 concreteColleageUser2 = new ConcreteColleageUser2("usuario2", adminGroupConcreateMediator); 
            ConcreteColleageUser3 concreteColleageUser3 = new ConcreteColleageUser3("usuario3", adminGroupConcreateMediator);

            adminGroupConcreateMediator.addColleage(concreteColleageUser1);
            adminGroupConcreateMediator.addColleage(concreteColleageUser2);
            adminGroupConcreateMediator.addColleage(concreteColleageUser3);


            concreteColleageUser1.postMessage("Hola grupo",null);
            concreteColleageUser1.postMessage("Hola grupo", concreteColleageUser2);

        }
    }
}
