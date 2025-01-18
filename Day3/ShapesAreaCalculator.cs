namespace Day3;
public static class ShapesAreaCalculator
{
    public static double CalculateArea(object shape)
    {
        return shape switch
        {
            Rectangle rectangle => rectangle.GetArea(),
            Circle circle => circle.GetArea(),
            _ => throw new ArgumentException("Invalid shape type"),
        };
    }
}
