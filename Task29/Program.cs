using System;
using System.Collections.Generic;
using System.Linq;

public interface ITransaction
{
    string ShowTransaction();
    float Money { get; set; }
}

public class PaidWithCash : ITransaction
{
    private static float totalCash = 0;

    public string ShowTransaction()
    {
        return $"Paid with cash: bill number {BillNumber} date {Date} amount {Money:C}";
    }

    public float ShowCash()
    {
        return totalCash;
    }

    public int BillNumber { get; }
    public DateTime Date { get; }

    public PaidWithCash(int billNumber, DateTime date, float money)
    {
        BillNumber = billNumber;
        Date = date;
        Money = money;
        totalCash += money;
    }

    public float Money { get; set; }
}

public class PaidWithCard : ITransaction
{
    private static float totalCardPayments = 0;

    public string ShowTransaction()
    {
        return $"Transaction to bank: charge from card {CardNumber} date {Date.ToShortDateString()} amount {Money:C}";
    }

    public float ShowTotal()
    {
        return totalCardPayments;
    }

    public string CardNumber { get; }
    public DateTime Date { get; }

    public PaidWithCard(string cardNumber, DateTime date, float money)
    {
        CardNumber = cardNumber;
        Date = date;
        Money = money;
        totalCardPayments += money;
    }

    public float Money { get; set; }
}

class Program
{
    static void Main()
    {


        List<ITransaction> transactions = new List<ITransaction>();

        transactions.Add(new PaidWithCash(1, DateTime.Parse("12.1.2023"), 100));
        transactions.Add(new PaidWithCash(2, DateTime.Parse("15.1.2023"), 50));

        transactions.Add(new PaidWithCard("0001-0002", DateTime.Parse("13.1.2023"), 78.95f));
        transactions.Add(new PaidWithCard("0003-0004", DateTime.Parse("15.1.2023"), 45.65f));

        foreach (var transaction in transactions)
        {
            Console.WriteLine(transaction.ShowTransaction());
        }

        var totalCardPayments = transactions.OfType<PaidWithCard>().Sum(t => t.Money);
        Console.WriteLine($"Total money at bank account: {totalCardPayments:C}");

        var totalCash = transactions.OfType<PaidWithCash>().Sum(t => t.Money);
        Console.WriteLine($"Total money in cash: {totalCash:C}");

        var totalSales = totalCardPayments + totalCash;
        Console.WriteLine($"Total sales today {DateTime.Now.ToLongDateString()} is {totalSales:C}");

        Console.Write($"Program completed successfully. Press any key to quit. ");
        Console.ReadKey();
    }
}