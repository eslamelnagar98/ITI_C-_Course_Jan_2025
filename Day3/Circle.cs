namespace Day3;

public class Circle(double raduis) : IShape
{
    public double Raduis { get; set; } = raduis;

    public double GetArea() => Math.PI * Raduis * Raduis;
}
