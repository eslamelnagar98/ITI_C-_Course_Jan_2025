namespace ExternalPackages;
#region Contract
public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}

#endregion
public class StudentFileOpertaions : IStudentOpertaions
{
    public Student GetStudentByFirstName(string firstName)
    {
        Console.WriteLine("helloe From File");

        return new Student { Id = 10, FirstName = firstName, LastName = "Doe" };
    }

    public Student GetStudentById(int id)
    {
        Console.WriteLine("helloe From File");

        return new Student { Id = id, FirstName = "John", LastName = "Doe" };
    }

    public Student GetStudentByLastName(string lastName)
    {
        Console.WriteLine("helloe From File");

        return new Student { Id = 10, FirstName = "islam", LastName = lastName };
    }

}

public class StudentExcelOperations : IStudentOpertaions
{
    public Student GetStudentByFirstName(string firstName)
    {
        Console.WriteLine("helloe From Excel");

        return new Student { Id = 10, FirstName = firstName, LastName = "Doe" };
    }

    public Student GetStudentById(int id)
    {
        Console.WriteLine("helloe From Excel");

        return new Student { Id = id, FirstName = "John", LastName = "Doe" };
    }

    public Student GetStudentByLastName(string lastName)
    {
        Console.WriteLine("helloe From Excel");

        return new Student { Id = 10, FirstName = "islam", LastName = lastName };
    }
}

public class StudentDbOperations : IStudentOpertaions
{
    public Student GetStudentByFirstName(string firstName)
    {
        Console.WriteLine("helloe From Database");

        return new Student { Id = 10, FirstName = firstName, LastName = "Doe" };
    }

    public Student GetStudentById(int id)
    {
        Console.WriteLine("helloe From Database");

        return new Student { Id = id, FirstName = "John", LastName = "Doe" };
    }

    public Student GetStudentByLastName(string lastName)
    {
        Console.WriteLine("helloe From Database");

        return new Student { Id = 10, FirstName = "islam", LastName = lastName };
    }
}
