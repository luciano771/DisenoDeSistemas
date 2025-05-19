using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Observer
{
    public class WebView : IOfferObserver
    {  
        public void update(Offer oferta)
        {

            if (oferta.isDelete)
            {
                Console.WriteLine("Actualizacion de la pagina web subastas.com, se cerro la subasta del articulo " + oferta.Auction.articleName);
            }
            else
            {
                Console.WriteLine("Actualizacion de la pagina web subastas.com, se realizo una oferta relacionada al  articulo " + oferta.Auction.articleName + " de: $" + oferta.price);
            }
        }
    }
}
