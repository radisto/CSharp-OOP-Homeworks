using System;

class Laptop
{
    private string model;
    private double price;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private int hdd;
    private string screen;
    private Battery battery;

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value == "")
            {
                throw new Exception("String value cannot be empty!");
            }
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value == "")
            {
                throw new Exception("String value cannot be empty!");
            }
            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (value == "")
            {
                throw new Exception("String value cannot be empty!");
            }
            this.processor = value;
        }
    }

    public int Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Integer value cannot be negative!");
            }
            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (value == "")
            {
                throw new Exception("String value cannot be empty!");
            }
            this.graphicsCard = value;
        }
    }

    public int Hdd
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Integer value cannot be negative!");
            }
            this.hdd = value;
        }
    }

    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (value == "")
            {
                throw new Exception("String value cannot be empty!");
            }
            this.screen = value;
        }
    }

    public double Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Double value cannot be negative!");
            }
            this.price = value;
        }
    }

    public Battery Battery
    {
        get 
        { 
            return this.battery; 
        }
        set 
        {
            this.battery = value; 
        }
    }

    public Laptop(string model, double price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(string model, double price, string manufacturer = null, string processor = null, int ram = 0,
        string graphicsCard = null, int hdd = 0, string screen = null, Battery battery = null)
        : this(model, price)
    {
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.Hdd = hdd;
        this.GraphicsCard = graphicsCard;
        this.Battery = battery;
        this.Screen = screen;
    }

    public override string ToString()
    {
        string result = string.Format("model: {0}\nprice: {1:0.00}lv.", this.model, this.price);
        if (this.manufacturer != null)
        {
            result += string.Format("\nmanufacturer: {0}", this.manufacturer);
        }
        if (this.processor != null)
        {
            result += string.Format("\nprocessor: {0}", this.processor);
        }
        if (this.ram != 0)
        {
            result += string.Format("\nram: {0} GB", this.ram);
        }
        if (this.hdd != 0)
        {
            result += string.Format("\nhdd: {0} GB SSD", this.hdd);
        }
        if (this.graphicsCard != null)
        {
            result += string.Format("\ngraphics card: {0}", this.graphicsCard);
        }
        if (this.screen != null)
        {
            result += string.Format("\nscreen: {0}", this.screen);
        }
        if (this.battery != null)
        {
            result += string.Format("\nbattery: {0}\nbattery life: {1} hours", this.battery.BatteryModel, this.battery.BatteryLife);
        }
        return result;
    }
}