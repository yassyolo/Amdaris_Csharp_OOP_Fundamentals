using Assessment6.Entities;
using Assessment6.RepositoryPattern.Contract;
using System.Text;

namespace Assessment6.RepositoryPattern.Implementations
{
    internal class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public string DisplayProduct(int id)
        {
            var stringBuilder = new StringBuilder();
            var product = GetById(id);
            if (product != null)
            {
                stringBuilder.AppendLine($"Product: {product.Name}, Unique code: {product.UniqueCode}, Price: {product.Price}");
            }
            else
            {
                stringBuilder.AppendLine("Product not found");
            }

            return stringBuilder.ToString().Trim();
        }

        public Product FindByCode(string uniqueCode)
        {
            return Find(x => x.UniqueCode == uniqueCode);
        }
    }
}
