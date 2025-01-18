namespace Day3;
public static class GenericShapesAreaCalculator
{
    public static double CalculateArea<T>(T shape) where T : IShape
    {
        return shape.GetArea();
    }
}
