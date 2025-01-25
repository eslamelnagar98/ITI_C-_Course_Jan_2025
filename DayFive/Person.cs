using System.Diagnostics.CodeAnalysis;

namespace DayFive;
public sealed class Person : IEquatable<Person>
{
    public required string Firstname { get; init; }
    public required string Lastname { get; init; }
    public required DateOnly DateOfBirth { get; init; }

    [SetsRequiredMembers]
    public Person(string firstName, string lastName, DateOnly dateOfBirth)
    {
        Firstname = firstName;
        Lastname = lastName;
        DateOfBirth = dateOfBirth;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Person);
    }

    public bool Equals(Person? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Firstname == other.Firstname &&
               Lastname == other.Lastname &&
               DateOfBirth == other.DateOfBirth;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Firstname, Lastname, DateOfBirth);
    }

    public static bool operator ==(Person? left, Person? right)
    {
        if (left is null) return right is null;
        return left.Equals(right);
    }

    public static bool operator !=(Person? left, Person? right)
        => !(left == right);


    public override string ToString()
        => $"Person FirstName:{Firstname}, LastName:{Lastname},DateofBirth:{DateOfBirth}";
}

//public readonly record struct Person(string Firstname, string LastName, DateOnly DateofBirth);

public readonly ref struct Point
{
    public int X { get; init; }
    public int Y { get; init; }
}