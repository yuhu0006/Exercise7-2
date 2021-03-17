using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6_1
{
    public class PriceOffer
    {
        public int PriceOfferId { get; set; }
        public string BookTsbn { get; set; }

        public double NewPrice { get; set; }

        public string PromotionText { get; set; }
    }
}
