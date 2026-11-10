public class Rectangle : Shape
{
    private double _lenght;
    private double _height;

    public Rectangle(double lenght, double height, string color) : base(color)
    {
        _lenght = lenght;
        _height = height;
    }
    public override double GetArea()
    {
        return (_lenght * _height);
    }
}