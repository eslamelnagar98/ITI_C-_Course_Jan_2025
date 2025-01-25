using Day3;
using Day3.GenericNumericRange;

//ShapesAreaCalculator.CalculateArea(new Rectangle(2, 3));
//ShapesAreaCalculator.CalculateArea(new Circle(2));
//ShapesAreaCalculator.CalculateArea("Islam");

//GenericShapesAreaCalculator<Rectangle>.CalculateArea(new Rectangle(2, 3));
//GenericShapesAreaCalculator.CalculateArea(new Circle(2));
// Create temperature ranges for Celsius


//var aggregateShapes = new AggregateShapes(new Circle(0), new Rectangle(0,0));
//ShapesAreaCalculator.CalculateAggregateArea(aggregateShapes);


var numericRange = new NumericRange<XStruct>();



static class ShapesAreaCalculator
{
    public static double CalculateAggregateArea(AggregateShapes aggregateShapes)
    {
        if (aggregateShapes?.Rectangle?.Width.CompareTo(0)==0)
        {
            return aggregateShapes.Rectangle.GetArea();
        }

        return aggregateShapes?.Circle?.GetArea() ?? default;
    }
}


