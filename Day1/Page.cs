namespace Day1;
public class Page
{
    //private readonly string[] _names = new string[5];
    public string[] Names { get; set; } = new string[5];
    public void AddNewName(int index, string value)
    {
        if (index < 0 || index >= Names.Length)
            throw new IndexOutOfRangeException();
        Names[index] = value;
    }
}
