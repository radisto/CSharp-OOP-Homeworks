using System;

class ComputerTest
{
    static void Main()
    {
        Computer pc1 = new Computer("High Speed Gaming PC", new Component("Intel", 500), new Component("NVIDIA", 200.50m), new Component("Foxconn", 299.95m));
        Computer pc2 = new Computer("High Speed Internet PC", new Component("AMD", 420.60m), new Component("ATI", 200), new Component("Gigabyte", 235.35m));
        Computer pc3 = new Computer("New Generation PC", new Component("Intel Quadcore", 620), new Component("GeForce HD", 424.20m), new Component("Apple", 335.50m));
        Console.WriteLine(pc2);
    }
}
