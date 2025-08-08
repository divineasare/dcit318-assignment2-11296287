using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 Test
            Console.WriteLine("--- Inheritance and Method Overriding ---");
            Animal animal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();
            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();

            // Task 2 Test
            Console.WriteLine("\n--- Abstract Classes and Methods ---");
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Circle Area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

            // Task 3 Test
            Console.WriteLine("\n--- Interfaces ---");
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();
            car.Move();
            bicycle.Move();
        }
    }
}
