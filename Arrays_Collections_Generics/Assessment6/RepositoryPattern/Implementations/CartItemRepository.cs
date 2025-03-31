using Assessment6.Entities;
using Assessment6.RepositoryPattern.Contract;

namespace Assessment6.RepositoryPattern.Implementations
{
    internal class CartItemRepository : GenericRepository<CartItem>, ICartItemRepository
    {
        public int CheckCartItemQuantity(int cartItemId)
        {
            return GetById(cartItemId).Quantity;
        }

        public void UpdateCartItemQuantity(int cartItemId)
        {
            var cartItem = GetById(cartItemId);
            cartItem.Quantity++;
        }
    }
}
