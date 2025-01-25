//var person = new Person(10, new Address("XR"));
//if (person.Clone() is Person person2)
//{
//    person2.Address.Street = "XZ";
//    Console.WriteLine(person.Address.GetHashCode());
//    Console.WriteLine(person2.Address.GetHashCode());
//    Console.WriteLine(person.ToString());
//    Console.WriteLine(person2.ToString());
//}

#region Records
using DayFive;
var dateTime = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc);


//var firstPerson =
//    new Person("Islam", "El-naggar", DateOnly.FromDateTime(dateTime));
//var secondPerson =
//    new Person("Islam", "El-naggar", DateOnly.FromDateTime(dateTime));

//var thirdPerson = firstPerson with { Firstname = "Mohamed" };

//Console.WriteLine(firstPerson);
//Console.WriteLine(secondPerson);
//Console.WriteLine(firstPerson == secondPerson);
//Console.WriteLine(firstPerson.Equals(secondPerson));
//Console.WriteLine(firstPerson
//        .GetHashCode()
//        .CompareTo(secondPerson.GetHashCode()
//        ) == 0
//    ); 
#endregion


//var numbers = new List<int>();
//numbers.Add(1);
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}

//var people = new People(10);

//foreach (var person in people)
//{
//    Console.WriteLine(person);
//}


foreach (var item in GetNumbers().Take(3))
{
    Console.WriteLine(item);
}

static IEnumerable<int> GetNumbers()
{
    for (var i = 0; i < 10; i++)
    {
        yield return i;
    }
}