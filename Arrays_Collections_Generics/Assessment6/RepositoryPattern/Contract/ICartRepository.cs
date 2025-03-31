using Assessment6.Entities;

namespace Assessment6.RepositoryPattern.Contract
{
    internal interface ICartRepository : IGenericRepository<Cart>
    {
        Cart FindByCustomerId(int customerId);
        void AddProduct(int id, CartItem cartItem);
    }
}
