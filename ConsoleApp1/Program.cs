
using System;



namespace Inheritance_and_Method_Overriding;

    class program
    {

        public class Animal()
        {
            public string Makesound()
            {
                return "some generic sound";
            }
        }
             class Dog(): Animal
             {
                public string Makesound()
                {
                   return "bark";
                }
             }
               class Cat() : Animal
               {
                 public string Makesound()
                   {
                            return "Meow";
                    }
               }
            public static void Main(String[] args)
                {
                      Animal animal = new Animal();
                      Dog dog = new Dog();
                      Cat cat = new Cat();
                      Console.WriteLine(animal.Makesound());
                      Console.WriteLine(cat.Makesound());
                      Console.WriteLine(dog.Makesound());
                  }

}


