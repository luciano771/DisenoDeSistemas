using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Observer
{
    public class MobileView : IOfferObserver
    {
        public void update(Offer oferta)
        {
            if (oferta.isDelete)
            {
                Console.WriteLine("Actualizacion de la aplicacion mobile subastasApp, se cerro la subasta del articulo " + oferta.Auction.articleName);
            }
            else
            {
                Console.WriteLine("Actualizacion de la aplicacion mobile subastasApp, se realizo una oferta relacionada al  articulo " + oferta.Auction.articleName + " de: $" + oferta.price);
            }
        }
    }
}
