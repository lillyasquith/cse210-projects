using System;
class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        double areaOfCircle = Math.PI * _radius * _radius;
        return areaOfCircle;
    }
}