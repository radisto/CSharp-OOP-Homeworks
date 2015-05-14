using System;

class MainClass
{
    static void Main()
    {
        Point3D a = new Point3D(1, 1, 1);
        Point3D b = new Point3D(2, 2, 2);
        Console.WriteLine(DistanceCalculator.CalcDistance(a, b));
        //Returns square root of 3 which is the correct answer.
        a = new Point3D(21, 33, 18);
        b = new Point3D(42, 16, 25);
        Console.WriteLine(DistanceCalculator.CalcDistance(a, b));
    }
}
