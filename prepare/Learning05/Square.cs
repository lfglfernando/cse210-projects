
public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    //date cuenta que usa la palabra clave override
    public override double GetArea()
    {
        return _side * _side;
    }
}