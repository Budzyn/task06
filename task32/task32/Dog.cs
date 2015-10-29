using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task32
{
    class Dog:Animal,task32.Animal.IAnimal
    {
        void Animal.IAnimal.Introduce()
        {
            Console.WriteLine("I am a {0} of breed {1}", Name = "dog", Breed = true);
        }
        void Animal.IAnimal.AddPet()
        {
            Console.WriteLine("I am new pet {0}", Name = "new dog");
        }
    }
}
