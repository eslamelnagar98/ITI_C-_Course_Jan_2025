namespace ExternalCodeDemo.DayThreeAssigment;
public class Book : ICloneable
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    public string[] Genres { get; set; }

    public Book(string id, string title, string author, decimal price, string[] genres)
    {
        Id = id;
        Title = title;
        Author = author;
        Price = price;
        Genres = (string[])genres.Clone();
    }

    public object Clone()
    {
        return MemberwiseClone();
    }

    public Book DeepClone()
    {
        return new Book(Id, Title, Author, Price, (string[])Genres.Clone());
    }

    public override string ToString()
    {
        return $"Book: {Title}, Author: {Author}, Price: {Price:C}, Genres: [{string.Join(", ", Genres)}]";
    }
}


