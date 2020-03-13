using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IUnitOfWork
    {
        IOfferRepository Offers { get; set; }
        IBidRepository Bids { get; set; }

        int Complete();
    }
}
