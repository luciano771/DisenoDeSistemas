using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Observer
{
    public interface ISujeto
    {
        public void subscribe(IOfferObserver observadorOferta);
        public void unSubscribe(IOfferObserver observadorOferta);
        public void notifyObserver(Offer oferta);

    }
}
