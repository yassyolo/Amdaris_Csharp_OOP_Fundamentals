using Assessment6.Entities;
using Assessment6.RepositoryPattern.Implementations;


var productRepository = new ProductRepository();
var customerRepository = new CustomerRepository();
var cartItemRepository = new CartItemRepository();
var cartRepository = new CartRepository();

productRepository.Add(new Product { Id = 1, Name = "Straight leg jeans", UniqueCode = "Z63342", Price = 50.00m, Quantity = 110 });
productRepository.Add(new Product { Id = 2, Name = "Metallic top", UniqueCode = "Z83349", Price = 30.00m, Quantity = 25 });
productRepository.Add(new Product { Id = 3, Name = "Leather bag", UniqueCode = "Z94030", Price = 70.00m, Quantity = 150 });
productRepository.Add(new Product { Id = 4, Name = "Suede boots", UniqueCode = "Z23342", Price = 120.00m, Quantity = 75 });
productRepository.Add(new Product { Id = 5, Name = "Cotton shirt", UniqueCode = "Z63342", Price = 40.00m, Quantity = 100 });

customerRepository.Add(new Customer { Id = 1, Name = "Yoana", Address = "Sini kamani 28", Phone = "123-456-7890", Email = "email1.com" });
customerRepository.Add(new Customer { Id = 2, Name = "Mariela", Address = "Dragan Cankov 1a", Email = "email2.com" });

cartRepository.Add(new Cart {Id = 1, CustomerId = 1 });
cartRepository.Add(new Cart { Id = 2, CustomerId = 2 });

var cartItems = new List<CartItem>
{
    new CartItem { Id = 1, ProductId = 1, CartId = 1, Quantity = 2 },
    new CartItem { Id = 2, ProductId = 2, CartId = 1, Quantity = 1 },
    new CartItem { Id = 3, ProductId = 3, CartId = 1, Quantity = 3 },
    new CartItem { Id = 4, ProductId = 4, CartId = 2, Quantity = 1 },
    new CartItem { Id = 5, ProductId = 5, CartId = 2, Quantity = 2 }
};

cartItemRepository.Add(cartItems[0]);
cartItemRepository.Add(cartItems[1]);
cartItemRepository.Add(cartItems[2]);
cartItemRepository.Add(cartItems[3]);
cartItemRepository.Add(cartItems[4]);

cartRepository.AddProduct(1, cartItems[0]);
cartRepository.AddProduct(1, cartItems[1]);
cartRepository.AddProduct(2, cartItems[2]);
cartRepository.AddProduct(2, cartItems[3]);
cartRepository.AddProduct(2, cartItems[4]);


Console.WriteLine("Products in the shop:");
foreach (var product in productRepository.GetAll())
{
    Console.WriteLine(productRepository.DisplayProduct(product.Id));
}

var foundProduct = productRepository.FindByCode("Z94030");
Console.WriteLine($"Product with code Z94030: {productRepository.DisplayProduct(foundProduct.Id)} ");


var foundCustomersInBulgaria = customerRepository.FindByCountry("Bulgaria");
Console.WriteLine("Customers in Bulgaria:");
foreach (var customer in foundCustomersInBulgaria)
{
    Console.WriteLine($"{customer.Name}, {customer.Email}");
}

var cartForCustomer = cartRepository.FindByCustomerId(1);
var cartItemsInCartForCustomer = cartItemRepository.FindAll(x => x.CartId == cartForCustomer.Id);
Console.WriteLine("Cart items for customer Yoana:");
foreach (var cartItem in cartItems)
{
    Console.WriteLine($"{productRepository.DisplayProduct(cartItem.ProductId)}, Quantity: {cartItem.Quantity}");
}

cartItemRepository.Add(new CartItem {Id = 3, ProductId = 5, CartId = 1, Quantity = 2 });
cartItemRepository.UpdateCartItemQuantity(5);
var cartItemsForCart = cartItemRepository.FindAll(x => x.CartId == 1);
foreach (var cartItem in cartItemsForCart)
{
    Console.WriteLine($"{productRepository.DisplayProduct(cartItem.ProductId)}, Quantity: {cartItem.Quantity}"); 
}

Console.ReadLine();
        