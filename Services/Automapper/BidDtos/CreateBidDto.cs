using Core.Offers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Automapper.BidDtos
{
    public class CreateBidDto
    {
        public double Price { get; set; }

        public DateTime Date { get; set; }

        public int OfferId { get; set; }
    }
}
