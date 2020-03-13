using Core;
using Core.Interfaces;
using Core.Offers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class OfferRepository : Repository<Offer>, IOfferRepository
    {
        public OfferRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
