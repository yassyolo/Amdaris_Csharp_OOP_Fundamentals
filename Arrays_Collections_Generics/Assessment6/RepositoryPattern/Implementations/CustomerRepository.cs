using Assessment6.Entities;
using Assessment6.RepositoryPattern.Contract;

namespace Assessment6.RepositoryPattern.Implementations
{
    internal class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public IEnumerable<Customer> FindByCountry(string country)
        {
            return FindAll(x => x.Country == country);
        }
    }
}
