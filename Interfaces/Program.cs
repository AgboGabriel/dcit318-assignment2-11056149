using System;


namespace Interfaces;

public class program 
{
    public interface IMovable
    {
        public string move();
    }
    public class Car : IMovable
    {
        public string move() 
        {
         return "Car is moving";
        }
    }
    public class Bicycle : IMovable 
    {
        public string move() 
        {
         return "Bicycle is moving";
        }
    }
    public static void Main(String[] args) 
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Console.WriteLine(car.move());
        Console.WriteLine(bicycle.move());
    }
}
