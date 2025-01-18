namespace SolutionItems;

public class Circle(double raduis)
{
    public double Raduis { get; set; } = raduis;

    public double GetArea()
    {
        return Math.PI * Raduis * Raduis;
    }
}
