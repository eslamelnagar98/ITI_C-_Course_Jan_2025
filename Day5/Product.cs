using System.Diagnostics.CodeAnalysis;
namespace Day5;
[method: SetsRequiredMembers]
public sealed class Product(string name, Category category): IEquatable<Product>
{
    public required string Name { get; init; } = name;
    public required Category Category { get; init; } = category;
    public bool Equals(Product? other)
    {
        if (other is null)
            return false;
        if (ReferenceEquals(this, other))
            return true;
        return Name == other.Name && Category == other.Category;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Product);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Category);
    }

    public static bool operator ==(Product? left, Product? right)
    {
        if (left is null)
            return right is null;
        return left.Equals(right);
    }

    public static bool operator !=(Product? left, Product? right)
        => !(left == right);

    public override string ToString()
        => $"Product Name:{Name}, Category:{Category}";


}
public enum Category
{
    Electronics,
    Grocery,
    Furniture,
    Clothing,
    Footwear
}

