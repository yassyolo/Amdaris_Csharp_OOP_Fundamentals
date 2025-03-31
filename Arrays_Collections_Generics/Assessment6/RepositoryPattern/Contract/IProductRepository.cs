using Assessment6.Entities;

namespace Assessment6.RepositoryPattern.Contract
{
    internal interface IProductRepository : IGenericRepository<Product>
    {
        Product FindByCode(string uniqueCode);
        string DisplayProduct(int id);
    }
}
