namespace Day2;
public enum Genre
{
    Fiction = 1,
    NonFiction = 2,
    Mystery = 3,
    ScienceFiction = 4,
    Biography = 5
}

[Flags]
public enum BookAvailability
{
    Borrowable = 1,
    Reserved = 2,
    OutOfStock = 4
}

public interface IBorrowable
{
    void Borrow();
    void Return();
}

public class Book : IBorrowable, IComparable<Book>
{
    public string Id { get; init; }
    public string Title { get; set; }
    public Genre Genre { get; set; }
    public BookAvailability Availability { get; set; }

    public int CompareTo(Book? other)
    {
        return string.Compare(this.Title, other?.Title, StringComparison.Ordinal);
    }

    public void Borrow()
    {
        if (Availability.HasFlag(BookAvailability.Borrowable))
        {
            Availability &= ~BookAvailability.Borrowable;
            Availability |= BookAvailability.Reserved;
        }
        else
        {
            Console.WriteLine("Book cannot be borrowed.");
        }
    }

    public void Return()
    {
        Availability |= BookAvailability.Borrowable;
        Availability &= ~BookAvailability.Reserved;
    }
}

public class Library
{
    private readonly Book[] _books;
    private int _currentIndex;

    public Library(int capacity)
    {
        _books = new Book[capacity];
        _currentIndex = 0;
    }

    public Book? this[string id]
    {
        get => Array.Find(_books, book => book?.Id == id);
    }

    public void AddBook(Book book)
    {
        if (_currentIndex < _books.Length)
        {
            _books[_currentIndex++] = book;
        }
        else
        {
            Console.WriteLine("Library is at full capacity.");
        }
    }
}

public class GenreComparer : IComparer<Book>
{
    public int Compare(Book? x, Book? y)
    {
        return x?.Genre.CompareTo(y?.Genre) ?? 0;
    }
}