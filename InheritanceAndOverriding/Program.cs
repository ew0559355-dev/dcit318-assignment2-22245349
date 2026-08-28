using System;

namespace InheritanceAndOverriding
{
    // Base class
    class Animal
    {
        // Virtual method that can be overridden by derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class overriding MakeSound
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class overriding MakeSound
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances
            Animal baseAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            // Call MakeSound on each
            baseAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}
