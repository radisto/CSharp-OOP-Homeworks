using System;

public class Component
{
    private string name;
    private string detail;
    private decimal price;

    public string Name 
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Name property must be a valid string");
            }
            this.name = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Price property cannot be negative");
            }
            this.price = value;
        }
    }

    public string Detail
    {
        get
        {
            return this.detail;
        }
        set
        {
            if (value != null && value.Length < 2)
            {
                throw new Exception("Detail property must be either null or at least two letters longer");
            }
            this.detail = value;
        }
    }

    public Component(string name, decimal price, string detail = null)
    {
        this.Name = name;
        this.Price = price;
        this.Detail = detail;
    }
}
