namespace Day2;
public class Animal
{
    public int Id { get; set; }
}
public class Dog : Animal, IComparable<Animal>
{
    public string Name { get; set; }

    public int CompareTo(Animal? other)
    {
        throw new NotImplementedException();
    }
}

public class Monkey : Animal, IComparable<Animal>
{
    public string Name { get; set; }
    public int CompareTo(Animal? other)
    {
        throw new NotImplementedException();
    }
}


public class Monkey2 : Monkey, IComparer<Animal>
{
    public string Name { get; set; }

    public int Compare(Animal? x, Animal? y)
    {
        throw new NotImplementedException();
    }
}

public class Parent
{
    public string Name { get; set; }
    public Parent(string name)
    {
        Name = name;
    }
    public override string ToString() => $"Parent: {Name}";
}

public class Child : Parent
{
    public int Age { get; set; }
    public Child(string name, int age) : base(name)
    {
        Age = age;
    }
    public override string ToString() => $"Child: {Name}, Age: {Age}";
}

public class ParentComparer : IComparer<Parent>
{
    public int Compare(Parent? x, Parent? y)
    {
        if (x == null || y == null)
            throw new ArgumentNullException(nameof(x), "Both objects must be non-null.");

        return x.Name.Length.CompareTo(y.Name.Length);
    }
}

public class ChildComparer : IComparer<Child>
{
    public int Compare(Child? x, Child? y)
    {
        if (x == null || y == null)
            throw new ArgumentNullException(nameof(x),"Both objects must be non-null.");

        var nameComparison = x.Name.Length.CompareTo(y.Name.Length);
        return nameComparison == 0 ? x.Age.CompareTo(y.Age) : nameComparison;
    }
}

public static class Comparator
{
    public static void CompareParents(IComparer<Parent> comparer, Parent obj1, Parent obj2)
    {
        int result = comparer.Compare(obj1, obj2);
        PrintComparisonResult(result, obj1, obj2);
    }

    public static void CompareChildren(IComparer<Child> comparer, Child obj1, Child obj2)
    {
        int result = comparer.Compare(obj1, obj2);
        PrintComparisonResult(result, obj1, obj2);
    }

    private static void PrintComparisonResult(int result, object obj1, object obj2)
    {
        Console.WriteLine(result switch
        {
            < 0 => $"{obj1} precedes {obj2}.",
            0 => $"{obj1} is equal to {obj2}.",
            > 0 => $"{obj1} follows {obj2}.",
        });
    }
}



