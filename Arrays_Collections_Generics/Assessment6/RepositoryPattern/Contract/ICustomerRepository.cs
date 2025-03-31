using Assessment6.Entities;

namespace Assessment6.RepositoryPattern.Contract
{
    internal interface ICustomerRepository : IGenericRepository<Customer>
    {
        IEnumerable<Customer> FindByCountry(string country);  
    }
}
