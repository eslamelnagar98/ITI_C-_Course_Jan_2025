namespace Day1;
public class IntIndexerExample
{
    private readonly int[] _numbers = new int[5];
    public IReadOnlyCollection<int> Numbers => _numbers.AsReadOnly();

    public void AddNewNumber(int index,int number)
    {
        if(index<0 || index >=_numbers.Length)
            throw new IndexOutOfRangeException();
        _numbers[index] = number;
    }
}
