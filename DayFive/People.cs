using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace DayFive;
public class People(int capacity) : IEnumerable<Person>
{
    [Required]
    public int MyProperty { get; set; }
    private readonly List<Person> _people = new(capacity: capacity);
    public IEnumerator<Person> GetEnumerator()
    {
        return _people.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public static class Extensions
{
    public static void CustomeWhere(this People people, Func<Person, bool> predicate)
        => people.Where(predicate);
}


