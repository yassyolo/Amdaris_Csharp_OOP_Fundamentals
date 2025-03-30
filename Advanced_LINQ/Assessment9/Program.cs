using Assessment9.Entities;

var products = new List<Product>
{
    new Product { Id = 1, Name = "Straight leg jeans", Category = "Denim", UniqueCode = "Z73382", Price = 70 },
    new Product { Id = 2, Name = "Cotton T-shirt", Category = "Tops", UniqueCode = "Z73383", Price = 30 },
    new Product { Id = 3, Name = "Leather belt", Category = "Accessories", UniqueCode = "Z73384", Price = 40 },
    new Product { Id = 4, Name = "Cotton shirt", Category = "Tops", UniqueCode = "Z73385", Price = 35 },
    new Product { Id = 5, Name = "Denim jacket", Category = "Denim", UniqueCode = "Z73386", Price = 120 },
    new Product { Id = 6, Name = "Leather bag", Category = "Accessories", UniqueCode = "Z73387", Price = 60 },
    new Product { Id = 7, Name = "Denim shorts", Category = "Denim", UniqueCode = "Z73388", Price = 50 },
    new Product { Id = 8, Name = "Cotton shorts", Category = "Tops", UniqueCode = "Z73389", Price = 40 },
    new Product { Id = 9, Name = "Leather wallet", Category = "Accessories", UniqueCode = "Z73390", Price = 20 },
    new Product { Id = 10, Name = "Denim skirt", Category = "Denim", UniqueCode = "Z73391", Price = 45 },
    new Product { Id = 11, Name = "Cotton dress", Category = "Dresses", UniqueCode = "Z73392", Price = 55 },
    new Product { Id = 12, Name = "Leather jacket", Category = "Outerwear", UniqueCode = "Z73393", Price = 150 },
    new Product { Id = 13, Name = "Denim shirt", Category = "Denim", UniqueCode = "Z73394", Price = 35 },
};

var expensiveRangeProducts = products.Where(x => x.Price > 100).ToList();
Console.WriteLine("Products in expesinve range > $100:");
foreach (var product in expensiveRangeProducts)
{
    Console.WriteLine(product.ToString());
}

var firstExpensiveProduct = products.FirstOrDefault(x => x.Price > 100);
Console.WriteLine($"First Expensive Product > $100: {firstExpensiveProduct?.ToString()}");

var lastProduct = products.LastOrDefault();
Console.WriteLine($"Last Product: {lastProduct?.ToString()}");

var anyExpensiveProduct = products.Any(x => x.Price < 30);
Console.WriteLine($"Are there products under $30: {anyExpensiveProduct}");

var enoughQuantityProducts = products.All(x => x.Quantity > 20);
Console.WriteLine($"Is all products's quantity is > 20 {enoughQuantityProducts}");

Console.WriteLine("----:");

var productCodes = products.Select(x => x.UniqueCode).ToList();
Console.WriteLine("All products:");
foreach (var code in productCodes)
{
    Console.WriteLine(code);
}

var categories = products.SelectMany(x => new List<string> { x.Category }).Distinct().ToList();
Console.WriteLine("All categories:");
foreach (var category in categories)
{
    Console.WriteLine(category);
}

var groupedByCategory = products.GroupBy(x => x.Category).ToList();
Console.WriteLine("Products in categories:");
foreach (var group in groupedByCategory)
{
    Console.WriteLine($"{group.Key}:");
    foreach (var product in group)
    {
        Console.WriteLine($"{product.ToString()}");
    }
}

var productQuantity = products.Select(x => new { Code = x.UniqueCode, Qty = x.Quantity });
Console.WriteLine("Code-quantity:");
foreach (var pq in productQuantity)
{
    Console.WriteLine($"{pq.Code} - ${pq.Qty}");
}

var productsWithDiscount = products.Select(x => new
{
    x.Name,
    NewPrice = x.Price * 0.5m
}).ToList();
Console.WriteLine("Products 50% off:");
foreach (var product in productsWithDiscount)
{
    Console.WriteLine($"{product}");
}

Console.WriteLine("----:");

var totalQuantity = products.Sum(x => x.Quantity);
Console.WriteLine($"Total quantity of all products: ${totalQuantity}");

var productsInDenimCategory = products.Count(x => x.Category == "Denim");
Console.WriteLine($"Products in category Denim: {productsInDenimCategory}");

var averagePrice = products.Average(x => x.Price);
Console.WriteLine($"Average price of products: ${averagePrice}");

var minPrice = products.Min(x => x.Price);
Console.WriteLine($"Minimum price of products: ${minPrice}");

var maxPrice = products.Max(x => x.Price);
Console.WriteLine($"Maximum price of products: ${maxPrice}");

Console.WriteLine("---");

var sortedByPriceAsc = products.OrderBy(x => x.Price).ToList();
Console.WriteLine("Products ordered by price Asc:");
foreach (var product in sortedByPriceAsc)
{
    Console.WriteLine($"{product}");
}

var sortedByQuantityDesc = products.OrderByDescending(x => x.Quantity).ToList();
Console.WriteLine("Products ordered by quantity Desc:");
foreach (var product in sortedByQuantityDesc)
{
    Console.WriteLine($"{product}");
}

var sortedByPriceThenByQuantity = products.OrderBy(x => x.Price).ThenBy(x => x.Quantity).ToList();
Console.WriteLine("Products ordered by price then by quantity:");
foreach (var product in sortedByPriceThenByQuantity)
{
    Console.WriteLine($"{product}");
}

var uniqueCategories = products.Select(p => p.Category).Distinct().ToList();
Console.WriteLine("All categories:");
foreach (var category in uniqueCategories)
{
    Console.WriteLine(category);
}

Console.WriteLine("----:");

var lastSeasonProducts = new List<Product>
{
    new Product { Id = 1, Name = "Straight leg jeans", Category = "Denim", UniqueCode = "Z73382", Price = 65 }, // Price Change
    new Product { Id = 2, Name = "Cotton T-shirt", Category = "Tops", UniqueCode = "Z73383", Price = 25 }, // Price Change
    new Product { Id = 3, Name = "Leather belt", Category = "Accessories", UniqueCode = "Z73384", Price = 45 }, // Price Change
    new Product { Id = 5, Name = "Denim jacket", Category = "Denim", UniqueCode = "Z73386", Price = 110 }, // Price Change
    new Product { Id = 7, Name = "Denim shorts", Category = "Denim", UniqueCode = "Z73388", Price = 55 }, // Price Change
    new Product { Id = 9, Name = "Leather wallet", Category = "Accessories", UniqueCode = "Z73390", Price = 18 }, // Price Change
    new Product { Id = 10, Name = "Denim skirt", Category = "Denim", UniqueCode = "Z73391", Price = 50 }, // Price Change
    new Product { Id = 11, Name = "Cotton dress", Category = "Dresses", UniqueCode = "Z73392", Price = 60 }, // Price Change
    new Product { Id = 14, Name = "Wool coat", Category = "Outerwear", UniqueCode = "Z73395", Price = 170 }, // New Product
};

var productsCombinedInBothSeasons = products.Union(lastSeasonProducts);
Console.WriteLine("All unique products from now and last season:");
foreach (var product in productsCombinedInBothSeasons)
{
    Console.WriteLine(product);
}

var productsCommonInBothSeasons = products.Intersect(lastSeasonProducts);
Console.WriteLine("Products in both seasons:");
foreach (var product in productsCommonInBothSeasons)
{
    Console.WriteLine(product);
}

var productsNotInThisSeason = lastSeasonProducts.Except(products);
Console.WriteLine("Produucts not in this season:");
foreach (var product in productsNotInThisSeason)
{
    Console.WriteLine(product);
}

Console.WriteLine("----:");

var productsWithPriceChanges = products.Join(
               lastSeasonProducts,
               thisSeason => thisSeason.UniqueCode,
               lastSeason => lastSeason.UniqueCode,
               (thisSeason, lastSeason) => new { Name = thisSeason.Name, OldPrice = lastSeason.Price, NewPrice = thisSeason.Price });

Console.WriteLine("Price changes from last season:");
foreach (var product in productsWithPriceChanges)
{
    Console.WriteLine($"{product.Name}: this season = ${product.OldPrice}, last season = ${product.NewPrice}");
}

Console.WriteLine("----:");

var productCodeAndName = products.ToDictionary(x => x.UniqueCode, x => x.Name);
Console.WriteLine("Product code - name:");
foreach (var kvp in productCodeAndName)
{
    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
}

Console.ReadLine(); 


        