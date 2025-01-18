namespace DayThree;
public class Rectangle(double width, double height)
{
    public double Width { get; set; } = width;
    public double Height { get; set; } = height;
    public double GetArea() => Width * Height;

}
