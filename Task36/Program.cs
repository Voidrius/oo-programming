using System;
using System.Collections.Generic;

public class InvoiceItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public double Total => Price * Quantity;

    public override string ToString()
    {
        return $"{Name} {Price:C} {Quantity} pieces {Total:C} total";
    }
}

public class Invoice
{
    public string Customer { get; set; }
    public List<InvoiceItem> Items { get; } = new List<InvoiceItem>();

    public int ItemsCount => Items.Count;

    public int ItemsTogether
    {
        get
        {
            int totalQuantity = 0;
            foreach (var item in Items)
            {
                totalQuantity += item.Quantity;
            }
            return totalQuantity;
        }
    }

    public double CountTotal()
    {
        double total = 0;
        foreach (var item in Items)
        {
            total += item.Total;
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        Invoice invoice = new Invoice
        {
            Customer = "Kirsi Kernel"
        };

        // Add items to the invoice
        invoice.Items.Add(new InvoiceItem { Name = "Milk", Price = 1.75, Quantity = 1 });
        invoice.Items.Add(new InvoiceItem { Name = "Beer", Price = 5.25, Quantity = 1 });
        invoice.Items.Add(new InvoiceItem { Name = "Butter", Price = 2.50, Quantity = 2 });

        PrintInvoice(invoice);
    }

    private static void PrintInvoice(Invoice invoice)
    {
        Console.WriteLine($"Customer {invoice.Customer}'s invoice:");
        Console.WriteLine("=================================");

        foreach (var item in invoice.Items)
        {
            Console.WriteLine(item.ToString());
        }

        Console.WriteLine("=================================");
        Console.WriteLine($"Total: {invoice.ItemsTogether} pieces {invoice.CountTotal():C}");
    }
}