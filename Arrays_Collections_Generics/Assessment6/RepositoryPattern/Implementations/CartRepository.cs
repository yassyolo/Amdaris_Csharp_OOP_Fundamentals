using Assessment6.Entities;
using Assessment6.RepositoryPattern.Contract;

namespace Assessment6.RepositoryPattern.Implementations
{
    internal class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public void AddProduct(int id, CartItem cartItem)
        {
            Cart cart = GetById(id);
            cart.CartItems.Add(cartItem);
        }

        public Cart FindByCustomerId(int customerId)
        {
            return Find(c => c.CustomerId == customerId);
        }
    }
}
