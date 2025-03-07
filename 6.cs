abstract class Shape
{
    public void display()
    {
        Console.WriteLine("Displaying shape");
    }
    public abstract  double Area();
}
class Circle : Shape{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        
        return 3.14 * radius * radius;

    }
}
class Rectangle : Shape{
    private double length;
    private double breadth;
    public Rectangle(double length,double breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }
    public override double Area()
    {
        
        return length * breadth;
    }
}
class Triangle: Shape
{
    private double height;
    private double base1;
    public Triangle(double height, double base1)
    {
        this.height = height;
        this.base1 = base1;

    }
    public override double Area()
    {
        return 0.5 * height * base1;
    }

}