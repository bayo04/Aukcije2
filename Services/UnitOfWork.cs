using Core;
using Core.Interfaces;
using Services.Repositories;

namespace Services
{
    public class UnitOfWork : IUnitOfWork
    {
        public AppDbContext _appDbContext { get; set; }
        public IOfferRepository Offers { get; set; }
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            Offers = new OfferRepository(_appDbContext);
        }
        public int Complete()
        {
            return _appDbContext.SaveChanges();
        }
    }
}
