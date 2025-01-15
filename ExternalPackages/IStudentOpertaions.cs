namespace ExternalPackages;
public interface IStudentOpertaions
{
    Student GetStudentById(int id);
    Student GetStudentByFirstName(string firstName);
    Student GetStudentByLastName(string lastName);
}
