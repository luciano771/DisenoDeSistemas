using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Mediator
{
    public class Singleton
    {
        private static AdminGroupConcreateMediator _instance;
        public static AdminGroupConcreateMediator getInstance()
        { 
                if (_instance == null)
                    _instance = new AdminGroupConcreateMediator();
                return _instance; 
        }
    }
}
