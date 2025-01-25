namespace Day3;
public static class GenericShapesAreaCalculator<TShape> where TShape : IShape
{
    public static double CalculateArea(TShape shape)
    {
        return shape.GetArea();
    }
}
