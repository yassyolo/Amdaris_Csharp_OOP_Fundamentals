﻿namespace Assessment15.Entities;

public class Product
{
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public string Name { get; }
    public decimal Price { get; }
}
