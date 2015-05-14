using System;

public class Battery
{
    private string batteryModel;
    private double batteryLife;

    public string BatteryModel
    {
        get
        {
            return this.batteryModel;
        }
        set
        {
            if (value == "")
            {
                throw new Exception("String value cannot be empty!");
            }
            this.batteryModel = value;
        }
    }

    public double BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Double value cannot be negative!");
            }
            this.batteryLife = value;
        }
    }

    public Battery(string batteryModel, double batteryLife)
    {
        this.BatteryModel = batteryModel;
        this.BatteryLife = batteryLife;
    }
}
