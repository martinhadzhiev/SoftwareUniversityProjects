using System;

public class Box
{
    private double lenght;
    private double width;
    private double height;

    public Box(double lenght, double width, double height)
    {
        this.Lenght = lenght;
        this.Width = width;
        this.Height = height;
    }

    private double Lenght
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            else
            {
                this.lenght = value;
            }
        }
    }

    private double Width
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            else
            {
                this.width = value;
            }
        }
    }

    private double Height
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            else
            {
                this.height = value;
            }
        }
    }

    public void GetAreaAndVolume()
    {
        var l = this.lenght;
        var w = this.width;
        var h = this.height;

        Console.WriteLine($"Surface Area - {(2 * l * w) + (2 * l * h) + (2 * w * h):F2}");
        Console.WriteLine($"Lateral Surface Area - {(2 * l * h) + (2 * w * h):F2}");
        Console.WriteLine($"Volume - {l * w * h:F2}");
    }
}