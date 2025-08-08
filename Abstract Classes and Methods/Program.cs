using System;

namespace Abstract_Classes_and_Methods;

class program
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    public class Circle : Shape
    {
         double radius;
       public  Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()

        {

             return  Math.PI * (radius * radius);
        }

    }
    public class Rectangle : Shape
    {
        double length, width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;

        }
        public override double GetArea()
        {
            return length * width;
        }
    }
        public static void Main(String[] args)
        {
        double radius,Area,Length,width;
        Console.WriteLine("Enter the radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle(radius);
        Area = circle.GetArea();
        Console.WriteLine("Area of the Circle is :" + Area);

        Console.WriteLine("Enter the Length of the Rectangle : ");
        Length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the Width of the Rectangle : ");
        width = Convert.ToDouble(Console.ReadLine());
        Rectangle reactangle = new Rectangle(Length, width);
        Console.WriteLine("Area fo the Rectangle is : " + reactangle.GetArea());

    }
    
}
    