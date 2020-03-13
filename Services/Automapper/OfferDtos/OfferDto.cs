using Core.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Automapper.OfferDtos
{
    public class OfferDto
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Location { get; set; }

        public decimal Price { get; set; }

        public string CreatorUsername { get; set; }
    }
}
