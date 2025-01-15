namespace Day2;
public class Person(string name, int age) : IComparable<Person>
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public int CompareTo(Person? other)
    {
        if (other == null)
            return 1;

        return string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
    }
}
