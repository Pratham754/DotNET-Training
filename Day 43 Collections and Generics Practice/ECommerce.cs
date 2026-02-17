using System;
using System.Linq;
using System.Collections.Generic;

// Base product interface
public interface IProduct
{
    int Id { get; }
    string Name { get; }
    decimal Price { get; }
    Category Category { get; }
}

public enum Category { Electronics, Clothing, Books, Groceries }

// 1. Create a generic repository for products
public class ProductRepository<T> where T : class, IProduct
{
    private readonly List<T> _products = [];

    // TODO: Implement method to add product with validation
    public void AddProduct(T product)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));
        // Rule: Product ID must be unique
        if (_products.Any(p => p.Id == product.Id))
            throw new InvalidOperationException("Product ID must be unique");
        // Rule: Price must be positive
        if (product.Price <= 0)
            throw new ArgumentException("Price must be positive");
        // Rule: Name cannot be null or empty
        if (string.IsNullOrEmpty(product.Name))
            throw new ArgumentException("Name cannot be null or empty");
        // Add to collection if validation passes
        _products.Add(product);
    }

    // TODO: Create method to find products by predicate
    public IEnumerable<T> FindProducts(Func<T, bool> predicate)
    {
        // Should return filtered products
        return _products.Where(predicate);
    }

    // TODO: Calculate total inventory value
    public decimal CalculateTotalValue()
    {
        // Return sum of all product prices
        return _products.Sum(p => p.Price);
    }
}

// 2. Specialized electronic product
public class ElectronicProduct : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Category Category => Category.Electronics;
    public int WarrantyMonths { get; set; }
    public string? Brand { get; set; }
}

// 3. Create a discounted product wrapper
public class DiscountedProduct<T> where T : IProduct
{
    private readonly T _product;
    private readonly decimal _discountPercentage;

    public DiscountedProduct(T product, decimal discountPercentage)
    {
        // TODO: Initialize with validation
        // Discount must be between 0 and 100
        if (product == null) throw new ArgumentNullException(nameof(product));
        if (discountPercentage < 0 || discountPercentage > 100)
            throw new ArgumentOutOfRangeException(nameof(discountPercentage), "Discount must be 0-100.");

        _product = product;
        _discountPercentage = discountPercentage;
    }

    // TODO: Implement calculated price with discount
    public decimal DiscountedPrice => _product.Price * (1 - _discountPercentage / 100);

    // TODO: Override ToString to show discount details
    public override string ToString()
    {
        return $"Product Name: {_product.Name}\tOriginal Price: {_product.Price}\tDiscounted Price: {DiscountedPrice}";
    }
}

// 4. Inventory manager with constraints
public class InventoryManager
{
    // TODO: Create method that accepts any IProduct collection
    public void ProcessProducts<T>(IEnumerable<T> products) where T : IProduct
    {
        if (products == null || !products.Any()) return;
        Console.WriteLine("Product List:");
        // a) Print all product names and prices
        foreach (var p in products)
            Console.WriteLine($"Item: {p.Name,-12} | Price: ${p.Price,8:F2}");
        // b) Find the most expensive product
        var maxProduct = products.MaxBy(p => p.Price);
        Console.WriteLine(maxProduct!.Name);
        // c) Group products by category
        var groups = products.GroupBy(p => p.Category);
        foreach (var group in groups)
        {
            Console.WriteLine($"{group.Key}: {group.Count()}");
        }
        // d) Apply 10% discount to Electronics over $500
        var expensiveItems = products.Where(p => p.Category == Category.Electronics && p.Price > 500);
        foreach (var e in expensiveItems)
        {
            var dp = new DiscountedProduct<T>(e, 10);
            Console.WriteLine(dp);
        }
    }

    // TODO: Implement bulk price update with delegate
    public void UpdatePrices<T>(List<T> products, Func<T, decimal> priceAdjuster)
        where T : IProduct
    {
        // Apply priceAdjuster to each product
        try
        {
            foreach (var product in products)
            {
                var updatedPrice = priceAdjuster(product);
                if(product is ElectronicProduct electronicProduct)
                {
                    electronicProduct.Price = updatedPrice;
                }
            }
        }
        // Handle exceptions gracefully
        catch (Exception ex)
        {
            Console.WriteLine($"Error during bulk update: {ex.Message}");
        }
    }
}

// 5. TEST SCENARIO: Your tasks:
// a) Implement all TODO methods with proper error handling
// b) Create a sample inventory with at least 5 products
// c) Demonstrate:
//    - Adding products with validation
//    - Finding products by brand (for electronics)
//    - Applying discounts
//    - Calculating total value before/after discount
//    - Handling a mixed collection of different product types

public class Program
{
    public static void Main()
    {
        try
        {
            var repo = new ProductRepository<ElectronicProduct>();
            var manager = new InventoryManager();

            // 5b) Sample Inventory
            repo.AddProduct(new ElectronicProduct { Id = 1, Name = "Laptop", Price = 1200m, Brand = "Dell" });
            repo.AddProduct(new ElectronicProduct { Id = 2, Name = "Phone", Price = 800m, Brand = "Samsung" });
            repo.AddProduct(new ElectronicProduct { Id = 3, Name = "Webcam", Price = 50m, Brand = "Logitech" });
            repo.AddProduct(new ElectronicProduct { Id = 4, Name = "Monitor", Price = 450m, Brand = "Dell" });
            repo.AddProduct(new ElectronicProduct { Id = 5, Name = "Tablet", Price = 600m, Brand = "Apple" });

            // 5c) Demonstrations
            Console.WriteLine($"Total Value: ${repo.CalculateTotalValue():F2}");

            Console.WriteLine("\nSearching for Brand 'Dell':");
            var dells = repo.FindProducts(p => p.Brand == "Dell");
            foreach(var d in dells) Console.WriteLine($"- {d.Name}");

            // Process via Manager
            var allProducts = repo.FindProducts(p => true).ToList();
            manager.ProcessProducts(allProducts);

            // Bulk Update
            Console.WriteLine("\nAdjusting prices for 5% inflation...");
            manager.UpdatePrices(allProducts, p => p.Price * 1.05m);
            Console.WriteLine($"New Total Inventory Value: ${repo.CalculateTotalValue():F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"FATAL ERROR: {ex.Message}");
        }
    }
}