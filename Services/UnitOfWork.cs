using Core;
using Core.Interfaces;
using Services.Repositories;

namespace Services
{
    public class UnitOfWork : IUnitOfWork
    {
        public AppDbContext _appDbContext { get; set; }
        public IOfferRepository Offers { get; set; }
        public IBidRepository Bids { get; set; }
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            Offers = new OfferRepository(_appDbContext);
            Bids = new BidRepository(_appDbContext);
        }
        public int Complete()
        {
            return _appDbContext.SaveChanges();
        }
    }
}
