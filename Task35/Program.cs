using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

public class ShoppingCart
{
    private List<Product> products;

    public ShoppingCart()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public int GetProductCount()
    {
        return products.Count;
    }

    public void PrintProducts()
    {
        Console.WriteLine("Your products in the shopping cart:");
        foreach (var product in products)
        {
            Console.WriteLine($"- product: {product.Name} {product.Price:C}");
        }
        Console.WriteLine($"There are {GetProductCount()} products in the shopping cart.");
    }
}

[TestClass]
public class ShoppingCartTests
{
    [TestMethod]
    public void GetProductCount_WithNoProducts_ReturnsZero()
    {
        ShoppingCart cart = new ShoppingCart();

        int result = cart.GetProductCount();

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetProductCount_WithOneProduct_ReturnsOne()
    {
        ShoppingCart cart = new ShoppingCart();
        Product product = new Product("Milk", 1.4m);
        cart.AddProduct(product);

        int result = cart.GetProductCount();

        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetProductCount_WithTwoProducts_ReturnsTwo()
    {
        ShoppingCart cart = new ShoppingCart();
        Product product1 = new Product("Milk", 1.4m);
        Product product2 = new Product("Bread", 2.2m);
        cart.AddProduct(product1);
        cart.AddProduct(product2);

        int result = cart.GetProductCount();

        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetProductCount_WithFiveProducts_ReturnsFive()
    {
        ShoppingCart cart = new ShoppingCart();
        Product product1 = new Product("Milk", 1.4m);
        Product product2 = new Product("Bread", 2.2m);
        Product product3 = new Product("Butter", 3.2m);
        Product product4 = new Product("Cheese", 4.2m);
        Product product5 = new Product("Eggs", 2.0m);
        cart.AddProduct(product1);
        cart.AddProduct(product2);
        cart.AddProduct(product3);
        cart.AddProduct(product4);
        cart.AddProduct(product5);

        int result = cart.GetProductCount();

        Assert.AreEqual(5, result);
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        Product product1 = new Product("Milk", 1.4m);
        Product product2 = new Product("Bread", 2.2m);
        Product product3 = new Product("Butter", 3.2m);
        Product product4 = new Product("Cheese", 4.2m);

        cart.AddProduct(product1);
        cart.AddProduct(product2);
        cart.AddProduct(product3);
        cart.AddProduct(product4);

        cart.PrintProducts();

        Console.WriteLine("\nPress enter key to continue...");
        Console.ReadLine();
    }
}