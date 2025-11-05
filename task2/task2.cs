
class Circle
{
    // constant variable
    public const double PI = 3.14;

    // method to calculate area
    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    // method to calculate perimeter
    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {
        //Circle.PI = 3.15; // This line will cause a compile-time error cause pi is constant and we can change the constant value
        Circle c = new Circle();
        double radius = 5;

        Console.WriteLine("Area of Circle: " + c.CalculateArea(radius));
        Console.WriteLine("Perimeter of Circle: " + c.CalculatePerimeter(radius));
    }
}
