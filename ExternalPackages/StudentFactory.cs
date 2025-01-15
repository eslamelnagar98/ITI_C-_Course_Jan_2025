namespace ExternalPackages;
public static class StudentFactory
{
    public static IStudentOpertaions Create(StudentOperations studentOperations)
    {
        switch (studentOperations)
        {
            case StudentOperations.File:
                return new StudentFileOpertaions();
            case StudentOperations.Excel:
                return new StudentExcelOperations();
            case StudentOperations.Db:
                return new StudentDbOperations();
            default:
                throw new ArgumentOutOfRangeException(nameof(studentOperations));
        }
    }
}

public enum StudentOperations
{
    File,
    Excel,
    Db
}
