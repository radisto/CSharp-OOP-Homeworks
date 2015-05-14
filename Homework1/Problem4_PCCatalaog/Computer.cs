using System;

class Computer
{
    private string name;
    private decimal price;
    private Component processor;
    private Component graphicsCard;
    private Component motherboard;

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
            this.price = value;
        }
    }

    public Component Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            this.processor = value;
        }
    }

    public Component GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            this.graphicsCard = value;
        }
    }

    public Component Motherboard
    {
        get
        {
            return this.motherboard;
        }
        set
        {
            this.motherboard = value;
        }
    }

    public Computer(string name, decimal price = 0)
    {
        this.Name = name;
        this.Price = price;
    }

    public Computer(string name, Component processor, decimal price = 0)
        : this(name, price)
    {
        this.Processor = processor;
    }

    public Computer(string name, Component processor, Component graphicsCard, decimal price = 0)
        : this(name, processor, price)
    {
        this.GraphicsCard = graphicsCard;
    }

    public Computer(string name, Component processor, Component graphicsCard, Component motherboard, decimal price = 0)
        : this(name, processor, graphicsCard, price)
    {
        this.Motherboard = motherboard;
    }

    public override string ToString()
    {
        string result = string.Format("name: {0}\nprice: {1:0.00}lv.", this.name, this.price);
        if (this.processor != null)
        {
            result += string.Format("\nprocessor name: {0}\nprocessor price: {1:0.00}lv.", this.processor.Name, this.processor.Price);
        }
        if (this.graphicsCard != null)
        {
            result += string.Format("\ngrapgics card name: {0}\ngrapgics card price: {1:0.00}lv.", this.graphicsCard.Name, this.graphicsCard.Price);
        }
        if (this.motherboard != null)
        {
            result += string.Format("\nmotherboard name: {0}\nmotherboard price: {1:0.00}lv.", this.motherboard.Name, this.motherboard.Price);
        }
        return result;
    }
}
