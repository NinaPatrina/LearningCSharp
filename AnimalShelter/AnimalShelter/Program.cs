using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog1 = new Dog("dog.1");
            Animal cat1 = new Cat("cat.1");
            Animal dog2 = new Dog("dog.2");
            Animal cat2 = new Cat("cat.2");
            Animal dog3 = new Dog("dog.3");
            Animal cat3 = new Cat("cat.3");

            Shelter shelter = new Shelter();

            shelter.QueueAnimal(dog1);
            shelter.QueueAnimal(cat1);
            shelter.QueueAnimal(dog2);
            shelter.QueueAnimal(cat2);
            shelter.QueueAnimal(dog3);
            shelter.QueueAnimal(cat3);

            Console.WriteLine(shelter.DequeueAny().Name);
            Console.WriteLine(shelter.DequeueCat().Name);
            Console.WriteLine(shelter.DequeueDog().Name);
            Console.WriteLine(shelter.DequeueAny().Name);
            Console.WriteLine(shelter.DequeueCat().Name);
            Console.WriteLine(shelter.DequeueDog().Name);


        }
    }
    public class Shelter
    {
        Queue<Cat> cats = new Queue<Cat>();
        Queue<Dog> dogs = new Queue<Dog>();
        Queue<Animal> both = new Queue<Animal>();


        public void QueueAnimal(Animal animal)
        {
            both.Enqueue(animal);
             

            if (animal.GetType().Equals(typeof(Dog)))
            {
                dogs.Enqueue((Dog)animal);
            }

            var cat = animal as Cat;
            if (cat != null)
            {
                cats.Enqueue(cat);
            }
        }
        public Animal DequeueAny()
        {
            var animal = both.Dequeue();
            if (cats.Peek() == animal) cats.Dequeue();
            if (dogs.Peek() == animal) dogs.Dequeue();
            return animal;          
        }
        public Dog DequeueDog()
        {
            both.Dequeue();
            return dogs.Dequeue();
        }
        public Cat DequeueCat()
        {
            both.Dequeue();
            return cats.Dequeue();
        }
    }
    abstract public class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
    }
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
    }
}

