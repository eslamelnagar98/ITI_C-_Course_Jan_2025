namespace DayThree;

public class Circle(double raduis)
{
    public double Raduis { get; set; } = raduis;

    public double GetArea() => Math.PI * Raduis * Raduis;
}
