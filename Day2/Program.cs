using System.Text.Json;
using Day2;
#region Interface
//Console.WriteLine("Please Enter Student Opertaion Type [File,Excel,Db]");

//Enum.TryParse(typeof(StudentOperations), Console.ReadLine(), out var studentOprationType);

//var studentOpertaions = StudentFactory.Create((StudentOperations)studentOprationType);

//var student = studentOpertaions.GetStudentById(10);
//Console.WriteLine($"{student.Id},{student.LastName}"); 
#endregion

#region IComparable
//Person[] people = { new("Mohamed"), new("Ahmed"), new("Islam") };
//Console.WriteLine("Before Sorting By Name ");
//PrintArray(people);
//Console.WriteLine();
//Array.Sort(people);
//Console.WriteLine("After Sorting By Name ");
//PrintArray(people);
//static void PrintArray(Person[] people)
//{
//    foreach (var person in people)
//    {
//        Console.WriteLine(person.Name);
//    }
//}

///Array.Sort(people)
///people[i].CompareTo(people[i+1])

#endregion

#region IComparer
//Person[] people =
//{
//            new Person("Charlie", 25),
//            new Person("Alice", 20),
//            new Person("Bob", 30)
//        };

//Console.WriteLine("Before Sorting By Name ");
//PrintArray(people);

//Array.Sort(people);
//Console.WriteLine($"{Environment.NewLine} Sorted By Name (Deafult Compare)");
//PrintArray(people);

//Array.Sort(people, new AgeComparer());
//Console.WriteLine($"{Environment.NewLine} Sorted By Age (Age Comparer)");

//PrintArray(people);
//static void PrintArray(Person[] people)
//{
//    Console.WriteLine(JsonSerializer.Serialize(people));
//} 


//var parent1 = new Parent("Alexander");
//var parent2 = new Parent("John");

//var child1 = new Child("Emily", 12);
//var child2 = new Child("Sophia", 10);

//var parentComparer = new ParentComparer();

//Comparator.CompareParents(parentComparer, parent1, parent2);

//Comparator.CompareChildren(parentComparer, child1, child2);

#endregion



