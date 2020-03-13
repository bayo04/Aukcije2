using Core.Offers;
using Core.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Bids
{
    public class Bid
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public DateTime Date { get; set; }

        [NotMapped]
        public User Bidder { get; set; }

        public Offer Offer { get; set; }
    }
}
