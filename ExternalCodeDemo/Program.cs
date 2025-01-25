using ExternalCodeDemo.DayFive;
using ExternalCodeDemo.DayFourAssignment;

//var tempRange = new NumericRange<Temperature<Celsius>>(
//           new Temperature<Celsius>(0),
//           new Temperature<Celsius>(100)
//       );

//var temp = new Temperature<Celsius>(50);

//Console.WriteLine(tempRange.Contains(temp)); // True
//Console.WriteLine(tempRange.Contains(new Temperature<Celsius>(150))); // False

//var anotherRange = new NumericRange<Temperature<Celsius>>(
//    new Temperature<Celsius>(50),
//    new Temperature<Celsius>(150)
//);


//var cold = new Temperature<Celsius>(-10.5);
//var hot = new Temperature<Celsius>(35.8);

//var celsiusRange = new NumericRange<Temperature<Celsius>>(cold, hot);
//Console.WriteLine(celsiusRange);

//var currentTemp = new Temperature<Celsius>(20.0);
//Console.WriteLine($"Is {currentTemp} within range? {celsiusRange.Clamp(currentTemp)}");

//// Create temperature ranges for Fahrenheit
//var freezing = new Temperature<Fahrenheit>(32.0);
//var boiling = new Temperature<Fahrenheit>(212.0);

//var fahrenheitRange = new NumericRange<Temperature<Fahrenheit>>(freezing, boiling);
//Console.WriteLine(fahrenheitRange);

//var tempF = new Temperature<Fahrenheit>(100.0);
//Console.WriteLine($"Is {tempF} within range? {fahrenheitRange.Clamp(tempF)}");


//var temp1 = new Temperature<Celsius>(20.0);
//var temp2 = new Temperature<Celsius>(25.0);

//var range = new NumericRange<Temperature<Celsius>>(temp1, temp2);

//Console.WriteLine(range.Contains(new Temperature<Celsius>(22.5))); // True
//Console.WriteLine(range); // "Range: 20°Celsius to 25°Celsius"


//var range1 = new NumericRange<int>(10, 20);
//var range2 = new NumericRange<int>(15, 25);

//var intersection = range1.Intersect(range2);
//Console.WriteLine(intersection); // Output: "Range: 15 to 20"


//var array = new Genre[2] { Genre.Biography, Genre.Mystery };
//Array.Sort(array, new GenreAvailabilityComparer());

//foreach (var item in array)
//{
//    Console.WriteLine(item.ToString());
//}



#region Classes vs. Structs vs. Records

//var personClass = new Person("Alice", "Wonder", new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc));
//var personRecordClass = new PersonRecord("John", "Record", DateTime.Now);
//var personRecordStruct = new PersonRecordStruct("Jane", "Struct", DateTime.Now);
//var personReadonlyRecordStruct = new ReadonlyPersonRecordStruct("Bob", "Immutable", DateTime.Now);

//Console.WriteLine("1. Class vs. Records:\n");
//Console.WriteLine($"   Class:         {personClass.FirstName} {personClass.LastName}, {personClass.BirthDate.ToShortDateString()}");
//Console.WriteLine($"   Record class:  {personRecordClass}");
//Console.WriteLine($"   Record struct: {personRecordStruct}");
//Console.WriteLine($"   Readonly record struct: {personReadonlyRecordStruct}\n");

//// Struct vs. Readonly Struct
//var normalPoint = new SimplePoint(10, 20);
//var readonlyPoint = new ReadonlyPoint(5, 15);
//Console.WriteLine("2. Struct vs. Readonly Struct:\n");
//Console.WriteLine($"   SimplePoint:   X={normalPoint.X}, Y={normalPoint.Y}");
//Console.WriteLine($"   ReadonlyPoint: X={readonlyPoint.X}, Y={readonlyPoint.Y}\n");

//// Equality with IEquatable<T>
//var p1 = new Person("Clone", "Test", new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc));
//var p2 = new Person("Clone", "Test", new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc));
//var p3 = new Person("Different", "Person", new DateTime(1995, 8, 25, 0, 0, 0, DateTimeKind.Utc));
//Console.WriteLine("3. Equality and IEquatable:\n");
//Console.WriteLine($"   p1 == p2? {p1 == p2}");
//Console.WriteLine($"   p1 == p3? {p1 == p3}\n");

//// ICloneable
//var clonedP1 = (Person)p1.Clone();
//Console.WriteLine("4. ICloneable:\n");
//Console.WriteLine($"   Original: {p1.FirstName}, {p1.BirthDate.ToShortDateString()}");
//Console.WriteLine($"   Cloned:   {clonedP1.FirstName}, {clonedP1.BirthDate.ToShortDateString()}\n");

//// Collections: List, Dictionary, HashSet
//var peopleList = new List<Person>();
//peopleList.Add(p1);
//peopleList.Add(p3);
//Console.WriteLine("5. Collections:\n");
//Console.WriteLine("   List (dynamic array):");
//foreach (var person in peopleList)
//{
//    Console.WriteLine($"     - {person.FirstName} {person.LastName}, {person.BirthDate.ToShortDateString()}");
//}

//var peopleDict = new Dictionary<string, Person>();
//peopleDict["first"] = p1;
//peopleDict["second"] = p3;
//Console.WriteLine("\n   Dictionary (hash table):");
//foreach (var kvp in peopleDict)
//{
//    Console.WriteLine($"     Key: {kvp.Key}, Value: {kvp.Value.FirstName} {kvp.Value.LastName}");
//}

//var peopleSet = new HashSet<Person>();
//peopleSet.Add(p1);
//peopleSet.Add(p2);
//peopleSet.Add(p3);
//Console.WriteLine("\n   HashSet (unique items):");
//foreach (var person in peopleSet)
//{
//    Console.WriteLine($"     - {person.FirstName} {person.LastName}, {person.BirthDate.ToShortDateString()}");
//}
//Console.WriteLine($"   p1 == p2? {p1 == p2} (so only one was stored)\n");

//Console.WriteLine("6. Hashing in Depth:");
//Console.WriteLine("   A hash code is an int that tries to evenly distribute objects.");
//Console.WriteLine("   In .NET, Dictionary/HashSet uses an internal array of 'buckets'.");
//Console.WriteLine("   Each bucket stores items that share the same hash code (collision).");
//Console.WriteLine("   If multiple items have the same hash code, they go into the same bucket (collision).");
//Console.WriteLine("   Then .NET calls Equals to differentiate them.\n"); 
#endregion

#region DayFourAssigment
//// 1) Array of USD payments
//Payment<USD>[] usdPayments = new Payment<USD>[]
//{
//            new(100.00), new(999999999.99), new(0.00), new(1200.50)
//};

//Console.WriteLine("USD Payments (Array):");
//for (int i = 0; i < usdPayments.Length; i++)
//{
//    Console.WriteLine($"  {usdPayments[i]}");
//}

//// 2) PaymentRange for USD: from $0 to $5000
//var usdRange = new PaymentRange<Payment<USD>>(
//    new Payment<USD>(0.0),
//    new Payment<USD>(5000.0)
//);
//Console.WriteLine($"\nRange for USD: {usdRange}");

//// 3) Manual check if payments are within range
//Console.WriteLine("Contains check (No LINQ):");
//for (int i = 0; i < usdPayments.Length; i++)
//{
//    bool inRange = usdRange.Contains(usdPayments[i]);
//    Console.WriteLine($"  {usdPayments[i]} -> inRange? {inRange}");
//}

//// 4) Clamping example
//var highUsdPayment = new Payment<USD>(10000.0);
//var clamped = usdRange.Clamp(highUsdPayment);
//Console.WriteLine($"\nClamping {highUsdPayment} to {usdRange} => {clamped}");

//// 5) Another USD range for intersection
//var usdRange2 = new PaymentRange<Payment<USD>>(
//    new Payment<USD>(1000.0),
//    new Payment<USD>(100000.0)
//);
//Console.WriteLine($"\nSecond USD range: {usdRange2}");

//// Intersect them
//try
//{
//    var intersection = usdRange.Intersect(usdRange2);
//    Console.WriteLine($"Intersection => {intersection}");
//}
//catch (InvalidOperationException ex)
//{
//    Console.WriteLine($"No intersection: {ex.Message}");
//}

//// 6) List of EUR payments
//var eurPayments = new List<Payment<EUR>>
//        {
//            new(50.5),
//            new(-999.99),
//            new(500000000.0), // near the max
//            new(-1001.0)      // below min, interesting test
//        };

//Console.WriteLine("\nEUR Payments (List):");
//for (int i = 0; i < eurPayments.Count; i++)
//{
//    Console.WriteLine($"  {eurPayments[i]}");
//}

//// Done
//Console.WriteLine("\n-- End of Currency Range Demo --");
#endregion