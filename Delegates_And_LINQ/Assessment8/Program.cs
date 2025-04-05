using Assessment8;


class Program
{
    public delegate bool ProductAvailabilityDelegate(Product p);
    public delegate string ProductFormatDelegate(Product p);
    public delegate void PrintDelegate(string message);
    public delegate bool ProductCheapDelegate(Product p);
    public delegate bool ProductFilter(Product product);

    static void Main()
    {
        var products = new List<Product>
{
    new Product { Id = 1, Name = "Straight leg jeans", Category = "Denim", UniqueCode = "Z73382", Price = 70, Quantity = 10 },
    new Product { Id = 2, Name = "Cotton T-shirt", Category = "Tops", UniqueCode = "Z73383", Price = 30, Quantity = 130 },
    new Product { Id = 3, Name = "Leather belt", Category = "Accessories", UniqueCode = "Z73384", Price = 40, Quantity = 110 },
    new Product { Id = 4, Name = "Cotton shirt", Category = "Tops", UniqueCode = "Z73385", Price = 35 , Quantity = 200},
    new Product { Id = 5, Name = "Denim jacket", Category = "Denim", UniqueCode = "Z73386", Price = 120 , Quantity = 30},
    new Product { Id = 6, Name = "Leather bag", Category = "Accessories", UniqueCode = "Z73387", Price = 60 , Quantity = 40},
    new Product { Id = 7, Name = "Denim shorts", Category = "Denim", UniqueCode = "Z73388", Price = 50, Quantity = 800 },
    new Product { Id = 8, Name = "Cotton shorts", Category = "Tops", UniqueCode = "Z73389", Price = 40 , Quantity = 70},
    new Product { Id = 9, Name = "Leather wallet", Category = "Accessories", UniqueCode = "Z73390", Price = 20, Quantity = 300 },
    new Product { Id = 10, Name = "Denim skirt", Category = "Denim", UniqueCode = "Z73391", Price = 45, Quantity = 80 },
    new Product { Id = 11, Name = "Cotton dress", Category = "Dresses", UniqueCode = "Z73392", Price = 55, Quantity = 30 },
    new Product { Id = 12, Name = "Leather jacket", Category = "Outerwear", UniqueCode = "Z73393", Price = 150, Quantity = 10 },
    new Product { Id = 13, Name = "Denim shirt", Category = "Denim", UniqueCode = "Z73394", Price = 35, Quantity = 80 },
};

        DelegateExample(products);
        AnonymousFunctionExample(products);
        LambdaExpressionExample(products);
        ExtensionMethodsExample(products);
        SelectWhereExample(products);
    }

    static void DelegateExample(List<Product> products)
    {
        ProductAvailabilityDelegate isAvailable = IsAvailable;
        ProductFormatDelegate formatInfo = FormatString;
        PrintDelegate print = PrintString;
        ProductCheapDelegate isCheap = CheapProduct;

        foreach (var p in products)
        {
            if (isAvailable(p) && isCheap(p))
            {
                string result = formatInfo(p);
                print(result);
            }
        }
    }

    static bool IsAvailable(Product p) => p.Quantity > 0;
    static string FormatString(Product p) {
        return $"{p.Name} - ${p.Price} - Qty: {p.Quantity}";
    }
    static void PrintString(string s) => Console.WriteLine(s);
    static bool CheapProduct(Product p) => p.Price < 40;

    static void AnonymousFunctionExample(List<Product> products)
    {
        ProductFilter lowPriceFilter = delegate (Product p) { return p.Price < 40; };
        Console.WriteLine("Low price products:");
        products.Where(x => lowPriceFilter(x)).ToList().ForEach(x => Console.WriteLine());

        ProductFilter highStockFilter = delegate (Product p) { return p.Quantity >= 30; };
        Console.WriteLine("High stock products (Qty >= 30):");
        products.Where(p => highStockFilter(p)).ToList().ForEach(p => Console.WriteLine($"{p.Name} | Qty: {p.Quantity}"));

        ProductFilter denimMidrangeFilter = delegate (Product p)
        {
            return p.Category == "Denim" && p.Price >= 50 && p.Price <= 100;
        };
        Console.WriteLine("Denim with mid Price ($50 - $100):");
        products.Where(p => denimMidrangeFilter(p)).ToList().ForEach(p => Console.WriteLine($"{p.ToString}"));

        ProductFilter nameStartsWithAFilter = delegate (Product p) { return p.Name.StartsWith("A"); };

        Console.WriteLine("Products starting with 'A':");
        products.Where(p => nameStartsWithAFilter(p)).ToList().ForEach(p => Console.WriteLine($"{p}"));
    }

    static void LambdaExpressionExample(List<Product> products)
    {
        Console.WriteLine("Moderate-stock products:");
        products.Where(x => x.Quantity >= 10 && x.Quantity <= 20).ToList().ForEach(x => Console.WriteLine());
        Console.WriteLine("Products Priced Between $40 and $200:");
        products.Where(x => x.Price >= 40 && x.Price <= 200).ToList().ForEach(x => Console.WriteLine());
        Console.WriteLine("Product count per category:");
        products.GroupBy(x => x.Category).ToList().ForEach(x => Console.WriteLine($"{x.Key}: {x.Count()} items"));
    }

    static void ExtensionMethodsExample(List<Product> products)
    {
        Console.WriteLine("Sorted by price (Asc):");
        products.OrderBy(x => x.Price).ToList().ForEach(x => Console.WriteLine());

        Console.WriteLine("Sorted by quantity (Desc):");
        products.OrderByDescending(x => x.Quantity).ToList().ForEach(x => Console.WriteLine());

        var stockValue = products.GroupBy(x => x.Category).Select(x => new
        {
            Category = x.Key,
            TotalValue = x.Sum(x => x.Price * x.Quantity)
        }).OrderByDescending(x => x.TotalValue);

        Console.WriteLine("Total stock value per category:");
        foreach (var p in stockValue)
        {
            Console.WriteLine($"{p.Category}: ${p.TotalValue}");
        }

        var top3ExpensiveProductsForCategories = products.GroupBy(x => x.Category).Select(x => new
        {
            Category = x.Key,
            Top3 = x.OrderByDescending(p => p.Price).Take(3)
        });

        Console.WriteLine("Top 3 most expensive products per category:");
        foreach (var group in top3ExpensiveProductsForCategories)
        {
            Console.WriteLine($"Category: {group.Category}:");
            foreach (var product in group.Top3)
            {
                Console.WriteLine($"{product.ToString()}");

            }
        }
    }

    static void SelectWhereExample(List<Product> products)
    {
        var expensiveProducts = products.Where(x => x.Price > 100).Select(x => new { ProductName = x.Name, ProductPrice = x.Price });
        Console.WriteLine("Expensive products:");
        foreach (var p in expensiveProducts)
        {
            Console.WriteLine($"{p.ProductName} - ${p.ProductPrice}");
        }

        var cheapProducts = products.Where(p => p.Price <= 30).Select(p => new { p.Name, p.Price, p.UniqueCode });
        Console.WriteLine("Cheap products:");
        foreach (var p in cheapProducts)
        {
            Console.WriteLine($"{p.Name}({p.UniqueCode}) - ${p.Price}");
        }

        var denimProducts = products.Where(x => x.Category == "Denim").GroupBy(p => p.Category)
                            .Select(x => new
                            {
                                Category = x.Key,
                                Products = x.Select(p => new { p.Name, p.Price })
                            });

        Console.WriteLine("Denim products:");
        foreach (var group in denimProducts)
        {
            Console.WriteLine($"Category: {group.Category}:");
            foreach (var p in group.Products)
            {
                Console.WriteLine($"{p.Name} - ${p.Price}");
            }
        }

        var avgPricesForCategories = products.Where(x => x.Quantity > 10).GroupBy(p => p.Category)
                        .Select(x => new
                        {
                            Category = x.Key,
                            AveragePrice = x.Average(x => x.Price)
                        }).OrderByDescending(x => x.AveragePrice);

        Console.WriteLine("Average price for categories:");
        foreach (var p in avgPricesForCategories)
        {
            Console.WriteLine($"{p.Category}: ${p.AveragePrice}");
        }
    }

}







