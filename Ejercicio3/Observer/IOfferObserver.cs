using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Observer {  
    public interface IOfferObserver
    {
        public void update(Offer oferta);
    }
}
