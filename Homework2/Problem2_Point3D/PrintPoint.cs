using System;

class PrintPoint
{
    static void Main()
    {
        Point3D myPoint = new Point3D(3, 6, 2);
        Console.WriteLine(myPoint);
        Console.WriteLine(Point3D.StartingPoint());
    }
}
