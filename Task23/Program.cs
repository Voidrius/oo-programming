using System;
using System.Collections.Generic;

public interface ICheckoutQueue
{
    void GoToQueue(string customerName);
    void ExitQueue();
    int Length { get; }
}

public class CheckoutQueue : ICheckoutQueue
{
    private Queue<string> queue = new Queue<string>();

    public void GoToQueue(string customerName)
    {
        queue.Enqueue(customerName);
        Console.WriteLine($"{customerName} joined the checkout queue.");
    }

    public void ExitQueue()
    {
        if (queue.Count > 0)
        {
            string exitingCustomer = queue.Dequeue();
            Console.WriteLine($"{exitingCustomer} got serviced and left the checkout queue.");
        }
        else
        {
            Console.WriteLine("Checkout queue is empty.");
        }
    }

    public int Length
    {
        get { return queue.Count; }
    }
}

class Program
{
    static void Main()
    {
        ICheckoutQueue checkoutQueue = new CheckoutQueue();

        checkoutQueue.GoToQueue("Matti");
        checkoutQueue.GoToQueue("Kalle");
        checkoutQueue.GoToQueue("Xehanort");
        checkoutQueue.GoToQueue("Sephiroth");
        checkoutQueue.GoToQueue("Galadriel");

        Console.WriteLine($"Queue Length: {checkoutQueue.Length}");

        checkoutQueue.ExitQueue();
        checkoutQueue.ExitQueue();
        checkoutQueue.ExitQueue();


        Console.WriteLine($"Queue Length after exit: {checkoutQueue.Length}");
    }
}