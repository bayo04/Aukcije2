using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Automapper.OfferDtos
{
    public class CreateOfferDto
    {
        public string ProductName { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Location { get; set; }

        public decimal Price { get; set; }

        //public Guid CreatorId { get; set; }
    }
}
