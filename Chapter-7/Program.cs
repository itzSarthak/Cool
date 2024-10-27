
namespace AbstractionDemo
{
    /*
        Abstraction is the process of hiding the complex implementation details
        and exposing only the necessary parts.
        In C#, this is typically done using abstract classes and interfaces.
    */
    // An abstract Class
    public abstract class Animal
    {
        // Abstract Method Can't Declare a Body
        public abstract void MakeSound();
    }
    
    public class Dog : Animal
    {
        // Overriding of Abstract Method is Mandatory 
        public override void MakeSound() 
        {
            Console.WriteLine("Woof Woof");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
    // An interface 
    public interface IMovable
    {
        void Move();
    }
    
    // A class inheriting an interface must define the methods
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car moves forward.");
        }
    }

    public static class Program
    {
        public static void Main()
        {
            // We can't have an objet for Abstract Class 
            Car car = new Car();
            car.Move();
            
            Dog dog = new Dog();
            dog.MakeSound();
            
            Cat cat = new Cat();
            cat.MakeSound();
        }
    }

}
