using System.Numerics;

namespace ExternalCodeDemo.DayFourAssignment;
public readonly struct Payment<TCurrency>(double amount) : IMinMaxValue<Payment<TCurrency>>, IComparable<Payment<TCurrency>>
    where TCurrency : ICurrency
{
    private readonly double _amount = amount;
    public double Amount => _amount;

    public static Payment<TCurrency> MaxValue => new(TCurrency.MaxValue);
    public static Payment<TCurrency> MinValue => new(TCurrency.MinValue);

    public int CompareTo(Payment<TCurrency> other) => _amount.CompareTo(other._amount);

    public override bool Equals(object? obj)
    {
        return obj is Payment<TCurrency> other && Equals(other);
    }

    private bool Equals(Payment<TCurrency> other)
    {
        const double TOLERANCE = 1e-4;
        return Math.Abs(_amount - other._amount) < TOLERANCE;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_amount, typeof(TCurrency));
    }

    public static bool operator ==(Payment<TCurrency> left, Payment<TCurrency> right)
        => left.Equals(right);
    public static bool operator !=(Payment<TCurrency> left, Payment<TCurrency> right)
        => !(left == right);

    public static bool operator <(Payment<TCurrency> left, Payment<TCurrency> right)
        => left.CompareTo(right) < 0;
    public static bool operator <=(Payment<TCurrency> left, Payment<TCurrency> right)
        => left.CompareTo(right) <= 0;
    public static bool operator >(Payment<TCurrency> left, Payment<TCurrency> right)
        => left.CompareTo(right) > 0;
    public static bool operator >=(Payment<TCurrency> left, Payment<TCurrency> right)
        => left.CompareTo(right) >= 0;

    public override string ToString()
    {
        return $"{_amount} {typeof(TCurrency).Name}";
    }
}
