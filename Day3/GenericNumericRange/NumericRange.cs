using System.Numerics;
namespace Day3.GenericNumericRange;
public class NumericRange<TSelf> where TSelf : struct, IComparable<TSelf>, IMinMaxValue<TSelf>
{
    public TSelf Start { get; }
    public TSelf End { get; }

    public NumericRange(TSelf start, TSelf end)
    {
        if (start.CompareTo(end) > 0)
            throw new ArgumentException("Start value must be less than or equal to end value");
        Start = start;
        End = end;
    }

    public bool Contains(TSelf value) 
    {
        return value.CompareTo(Start) >= 0 && value.CompareTo(End) <= 0;
    } 

    public TSelf Clamp(TSelf value)
    {
        if (value.CompareTo(Start) < 0)
            return Start;
        if (value.CompareTo(End) > 0)
            return End;
        return value;
    }
    override public string ToString() => $"[{Start}, {End}]";
}




