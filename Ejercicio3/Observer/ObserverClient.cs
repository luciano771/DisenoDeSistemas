using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Observer
{
    public class ObserverClient
    {
        public static void Main(string[] args) 
        {
            IOfferObserver observerWeb = new WebView();
            IOfferObserver observerMobile = new MobileView();
            
            Auction auction = new Auction("Camaro",500);
            auction.subscribe(observerWeb);
            auction.subscribe(observerMobile);

            auction.createOffeer(232);
            auction.createOffeer(222);
            auction.createOffeer(334);

            auction.closeOffer(222); 

            auction.createOffeer(500);

        }
    }
}
