namespace ExternalCodeDemo.DayThreeAssigment;
public class Repository<T>(int capacity = 10)
{
    private T[] _items = new T[capacity];
    private int _count = 0;

    public void Add(T item)
    {
        if (_count == _items.Length)
        {
            Resize();
        }
        _items[_count++] = item;
    }

    public void Remove(T item)
    {
        int index = Array.IndexOf(_items, item, 0, _count);
        if (index >= 0)
        {
            for (int i = index; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _items[--_count] = default!;
        }
    }

    public T[] GetAll()
    {
        var result = new T[_count];
        Array.Copy(_items, result, _count);
        return result;
    }

    private void Resize()
    {
        int newSize = _items.Length * 2;
        var newArray = new T[newSize];
        Array.Copy(_items, newArray, _items.Length);
        _items = newArray;
    }
}
