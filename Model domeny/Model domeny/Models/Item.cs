using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_domeny.Models
{
    public class Item
    {
        public int ItemID { get; private set; }
        public string Title { get; set; }
        public string Desctription { get; set; }
        public DateTime AuctionEndDate { get; set; }
        public IList<Bid> Bids { get; set; }
    }
}