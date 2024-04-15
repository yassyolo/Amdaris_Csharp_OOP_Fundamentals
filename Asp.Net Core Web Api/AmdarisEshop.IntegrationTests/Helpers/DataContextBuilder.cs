using AmdarisEshop.Domain.Models;
using AmdarisEshop.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace AmdarisEshop.IntegrationTests.Helpers
{
    public class DataContextBuilder : IDisposable
    {
        private readonly DataContext _dataContext;

        public DataContextBuilder(string dbName = "TestDatabase")
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            var context = new DataContext(options);

            _dataContext = context;
        }

        public DataContext GetContext()
        {
            _dataContext.Database.EnsureCreated();
            return _dataContext;
        }

        public void SeedCategories(int number = 1)
        {
            var categories = new List<Category>();

            for (int i = 0; i < number; i++)
            {
                var id = i + 1;

                categories.Add(new Category
                {
                    CategoryId = id,
                    CategoryName = $"category-{id}",
                    CategoryDescription = $"category-description-{id}"
                });
            }

            _dataContext.AddRange(categories);
            _dataContext.SaveChanges();
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
