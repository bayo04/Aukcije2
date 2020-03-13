using Core.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Offers
{
    public class Offer
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        //biće ovo enum abd
        public string Location { get; set; }

        public decimal Price { get; set; }

        [NotMapped] //Ukliniti!!!!!!!!
        public User Creator { get; set; }
    }
}
