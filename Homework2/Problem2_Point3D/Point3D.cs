using System;

class Point3D
{
    private int x;
    private int y;
    private int z;

    public int X
    {
        get
        {
            return this.x;
        }
        set
        {
            this.x = value;
        }
    }

    public int Y
    {
        get
        {
            return this.y;
        }
        set
        {
            this.y = value;
        }
    }
    
    public int Z
    {
        get
        {
            return this.z;
        }
        set
        {
            this.z = value;
        }
    }

    public Point3D(int x, int y, int z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

    public static Point3D StartingPoint()
    {
        return startingPoint;
    }

    public override string ToString()
    {
        return string.Format("Point X: {0} Point Y: {1} Point Z: {2}", this.x, this.y, this.z);
    }
}
