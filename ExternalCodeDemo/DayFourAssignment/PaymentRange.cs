﻿using System.Numerics;
namespace ExternalCodeDemo.DayFourAssignment;
public class PaymentRange<TSelf>
    where TSelf : struct, IComparable<TSelf>, IMinMaxValue<TSelf>
{
    public TSelf Start { get; }
    public TSelf End { get; }

    public PaymentRange(TSelf start, TSelf end)
    {
        if (start.CompareTo(end) > 0)
            throw new ArgumentException("Start value cannot be greater than end value.");
        Start = start;
        End = end;
    }

    public bool Contains(TSelf value)
    {
        return value.CompareTo(Start) >= 0 && value.CompareTo(End) <= 0;
    }

    public TSelf Clamp(TSelf value)
    {
        if (value.CompareTo(Start) < 0) return Start;
        if (value.CompareTo(End) > 0) return End;
        return value;
    }

    public PaymentRange<TSelf> Intersect(PaymentRange<TSelf> other)
    {
        var newStart = Start.CompareTo(other.Start) > 0 ? Start : other.Start;
        var newEnd = End.CompareTo(other.End) < 0 ? End : other.End;

        if (newStart.CompareTo(newEnd) > 0)
            throw new InvalidOperationException("No intersection between the ranges.");

        return new PaymentRange<TSelf>(newStart, newEnd);
    }

    public override string ToString() => $"Range: {Start} to {End}";
}
