using Assessment6.Entities;

namespace Assessment6.RepositoryPattern.Contract
{
    internal interface ICartItemRepository : IGenericRepository<CartItem>
    {
        int CheckCartItemQuantity(int cartItemId);
        void UpdateCartItemQuantity(int cartItemId);
    }
}
