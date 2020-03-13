using Core;
using Core.Bids;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class BidRepository : Repository<Bid>, IBidRepository
    {
        public BidRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
