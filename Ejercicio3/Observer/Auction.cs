using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Observer
{
    public class Auction : ISujeto
    {
        List<IOfferObserver> offerObserver;
        public string articleName { get; set; }
        public int initialAuctionPrice { get; set; }
        private List<Offer> offers = new();

        public Auction(string articleName, int initialAuctionPrice)
        {
            this.articleName = articleName;
            this.initialAuctionPrice = initialAuctionPrice;
            offerObserver = new List<IOfferObserver>();
        }

        public void subscribe(IOfferObserver vista)
        {
            offerObserver.Add(vista);
        }
        public void unSubscribe(IOfferObserver vista)
        {
            offerObserver.Remove(vista); 
        }

        public void notifyObserver(Offer oferta)
        {
            foreach (IOfferObserver obs in offerObserver)
            {
                obs.update(oferta);
            }
        }

        public void createOffeer(int price)
        {    
            Offer offer = new Offer(price, this);
            offers.Add(new Offer(price, this)); 
            notifyObserver(offer);

            if (price >= initialAuctionPrice)
            {
                offer.isDelete = true;
                notifyObserver(offer); 
            }
        }
         
        public void closeOffer(int price)
        {

            var closingOffer = new Offer(price, this)
            {
                isDelete = true
            };

            notifyObserver(closingOffer);
        }

    }
}
