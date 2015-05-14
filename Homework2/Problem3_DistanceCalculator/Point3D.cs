using System;

public class Point3D
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
}
