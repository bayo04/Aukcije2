using Core.Offers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Automapper.BidDtos
{
    public class BidDto
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public DateTime Date { get; set; }

        public Offer Offer { get; set; }

        public int OfferId { get; set; }
    }
}
