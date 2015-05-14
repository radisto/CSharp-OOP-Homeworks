using System;

class Sale
{
    public string ProductName { get; private set; }

    public DateTime Date { get; private set; }

    public decimal Price { get; private set; }

    public Sale(string productName, DateTime date, decimal price)
    {
        this.ProductName = productName;
        this.Date = date;
        this.Price = price;
    }
}