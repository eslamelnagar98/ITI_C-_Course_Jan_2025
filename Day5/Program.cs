Console.WriteLine("Hello from .NET 8 top-level statements!");
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
//var dateTime = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc);


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

//var song = new Song("Hello", "Adele", 2000);

//var musicPlaylist = new List<Song>() { new Song("Hello", "Adele", 2000), new Song("Natural", "Imagine Dragons", 2012) };

#region IEnumarable And List
//var musicPlaylist = new MusicPlaylist
//{
//    new Song("Hello", "Adele", 2000),
//    new Song("Hello", "Adele", 2000)
//};

//foreach (var song in musicPlaylist)
//{
//    Console.WriteLine(song.Title);
//}

//IEnumerator<Song> e = musicPlaylist.GetEnumerator();
//while (e.MoveNext())
//{
//    if (e.Current.Title.Equals("adele", StringComparison.InvariantCultureIgnoreCase))
//        break;
//    Console.WriteLine(e.Current.Title);
//} 
#endregion

#region Base Dictionary
//var dict = new Dictionary<string, int>();
//dict.Add("Islam", 100);
//dict.Add("Youssed", 101);
//dict.Add("Ahmed", 102);

//if (!dict.ContainsKey("Islam"))
//{
//    dict.Add("Islam", 150);
//}
//dict["Islam"] = 150;

//dict.TryAdd("Islam", 150);

//Console.WriteLine(dict["Islam"]);

//if (dict.ContainsKey("Mahmoud"))
//{
//    Console.WriteLine(dict["Mahmoud"]);
//}

//if (dict.TryGetValue("Mahmoud", out var value))
//{
//    Console.WriteLine(value);
//} 
#endregion

#region Product And Quantity Dictionary
//var inventory = new Dictionary<Product, int>
//{
//    {new ("Laptop",Category.Electronics),10 },
//    {new ("Headphones",Category.Electronics),5 },
//};

//var product = new Product("Laptop", Category.Electronics);

//inventory.TryAdd(product, 1000);


//foreach (var item in inventory)
//{
//    Console.WriteLine($"Product Name:{item.Key.Name}, Product Quantity:{item.Value}");
//} 
#endregion

#region hashset
//var cities = new HashSet<string>();
//Console.WriteLine($"Adding London {cities.Add("London")}");
//Console.WriteLine($"Adding Paris {cities.Add("Paris")}");
//Console.WriteLine($"Adding Berlin {cities.Add("Berlin")}");
//Console.WriteLine($"Adding London Again {cities.Add("London")}");
//Console.WriteLine();
//if (cities.TryGetValue("London", out var city))
//{
//    Console.WriteLine(city);
//}

//if (cities.TryGetValue("Cairo", out var cairo))
//{
//    Console.WriteLine(cairo);
//}

//Console.WriteLine($"Removing London {cities.Remove("London")}"); 
#endregion

#region Nullable Value Type
//int number = 10;
//int? nullableNumber = number;
//int number2 = nullableNumber ?? default;
//Console.WriteLine(number2); 
#endregion