using System.Numerics;

namespace Day3.GenericNumericRange;
public readonly struct Temperature<TUnit>(double value)
    : IMinMaxValue<Temperature<TUnit>>, IComparable<Temperature<TUnit>>
    where TUnit : ITemperatureUnit
{
    public double Value => value;
    public static Temperature<TUnit> MaxValue => new(TUnit.MaxValue);
    public static Temperature<TUnit> MinValue => new(TUnit.MinValue);

    public int CompareTo(Temperature<TUnit> other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => obj is Temperature<TUnit> other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(Value, typeof(TUnit));

    public static bool operator ==(Temperature<TUnit> left, Temperature<TUnit> right) => left.Equals(right);
    public static bool operator !=(Temperature<TUnit> left, Temperature<TUnit> right) => !(left == right);
    public static bool operator <(Temperature<TUnit> left, Temperature<TUnit> right) => left.CompareTo(right) < 0;
    public static bool operator <=(Temperature<TUnit> left, Temperature<TUnit> right) => left.CompareTo(right) <= 0;
    public static bool operator >(Temperature<TUnit> left, Temperature<TUnit> right) => left.CompareTo(right) > 0;
    public static bool operator >=(Temperature<TUnit> left, Temperature<TUnit> right) => left.CompareTo(right) >= 0;

    public override string ToString() => $"{Value}° {typeof(TUnit).Name}";

    private bool Equals(Temperature<TUnit> other)
    {
        const double Tolerance = 0.0001;
        return Math.Abs(Value - other.Value) < Tolerance;
    }
}
