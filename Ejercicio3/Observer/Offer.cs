using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Observer
{
    public class Offer
    {
        public int price {  get; set; }
        public bool isDelete { get; set; } = false;
        public Auction Auction { get; set; }
        public Offer(int _price, Auction _auction)
        {
            price = _price;
            Auction = _auction; 
        }
    }
}
