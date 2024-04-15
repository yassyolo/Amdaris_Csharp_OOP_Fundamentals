using AmdarisEshop.Application.Abstract;
using System;
using System.Threading.Tasks;

namespace AmdarisEshop.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;

        public UnitOfWork(
            DataContext dataContext,
            IProductRepository productRepository,
            ICategoryRepository categoryRepository)
        {
            _dataContext = dataContext;
            ProductRepository = productRepository;
            CategoryRepository = categoryRepository;
        }

        public IProductRepository ProductRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }

        public async Task Save()
        {
            await _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dataContext.Dispose();
            }
        }
    }
}
