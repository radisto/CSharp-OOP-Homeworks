using System;

class LaptopTest
{
    static void Main()
    {
        Laptop dell = new Laptop("Dell 1264e 2.5GHz", 560d);
        Console.WriteLine(dell);
        Laptop acer = new Laptop(model: "Acer 854h 2.4GHz",price: 770.50d, battery: new Battery("6-Cells Battery", 4.6d));
        Console.WriteLine(acer);
        Laptop apple = new Laptop("Apple 10c", 5000d, "Apple", "3 GHz iProcessor", 4, "2GB iVideo", 256,
            "23' Full HD Retina Display Screen", new Battery("8-Cells iBattery", 7.8d));
        Console.WriteLine(apple);
    }
}
