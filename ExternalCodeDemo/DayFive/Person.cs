using System.Diagnostics.CodeAnalysis;
namespace ExternalCodeDemo.DayFive;
public sealed class Person : IEquatable<Person>, ICloneable
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required DateTime BirthDate { get; init; }

    [SetsRequiredMembers]
    public Person(string firstName, string lastName, DateTime birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
    }

    public bool Equals(Person? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return FirstName == other.FirstName &&
               LastName == other.LastName &&
               BirthDate == other.BirthDate;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Person);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName, BirthDate);
    }

    // ICloneable implementation
    public object Clone()
    {
        return new Person(FirstName, LastName, BirthDate);
    }

    public static bool operator ==(Person? left, Person? right)
    {
        if (left is null) return right is null;
        return left.Equals(right);
    }

    public static bool operator !=(Person? left, Person? right)
    {
        return !(left == right);
    }
}


// 2. Records (reference and value types)
public record PersonRecord(string FirstName, string LastName, DateTime BirthDate);
public record struct PersonRecordStruct(string FirstName, string LastName, DateTime BirthDate);
public readonly record struct ReadonlyPersonRecordStruct(string FirstName, string LastName, DateTime BirthDate);

// 3. Struct vs. Readonly Struct
public struct SimplePoint
{
    public int X;
    public int Y;
    public SimplePoint(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public readonly struct ReadonlyPoint
{
    public readonly int X;
    public readonly int Y;
    public ReadonlyPoint(int x, int y)
    {
        X = x;
        Y = y;
    }
}

