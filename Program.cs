using System;

namespace Training_ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //DefinedShape square = new Square(3);
            //DefinedShape circle = new Circle(3);

            //double resultSq = square.area();
            //Console.WriteLine($"{resultSq}");

            //double resultCr = circle.area();
            //Console.WriteLine($"{resultCr}");


            /*Inheritance*/
            //Car car = new Car();

            //car.PurchaseCar();
            //Bike bike = new Bike();
            //bike.PurchaseBike();


            /*Runtime Polymorphism*/

            //Cat cat = new Cat();
            //Dog dog = new Dog();

            //cat.MakeSound();
            //dog.MakeSound();

            /*Interface*/

            NewSquare newSquare = new NewSquare(3);
            double resultSQ= newSquare.Area();
            Console.WriteLine($"{resultSQ}");
            NewCircle newCircle = new NewCircle(4);
            double resultCr = newCircle.Area();
            Console.WriteLine($"{resultCr}");

            StaticClass.InvokeMethod();

            SealedClass sealedClass = new SealedClass();

            sealedClass.InvokeMethod();


        }
    }
}


// Abstraction
// Encapsulation
// Inheritance
// Polymorphism