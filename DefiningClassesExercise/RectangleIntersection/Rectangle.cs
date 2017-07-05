public class Rectangle
{
    public string id;
    public double widht;
    public double height;
    public double topleftCornerX;
    public double topleftCornerY;

    public Rectangle(string id, double width, double height, double topX, double topY)
    {
        this.id = id;
        this.widht = width;
        this.height = height;
        this.topleftCornerX = topX;
        this.topleftCornerY = topY;
    }

    public bool Intersect(Rectangle rectangle)
    {
        if (rectangle.topleftCornerX <= this.topleftCornerX + this.widht &&
            rectangle.topleftCornerX + rectangle.widht >= this.topleftCornerX &&
            rectangle.topleftCornerY <= this.topleftCornerY + this.height &&
            rectangle.topleftCornerY + rectangle.height >= this.topleftCornerY)
        {
            return true;
        }

        return false;
    }
}