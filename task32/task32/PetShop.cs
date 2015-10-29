using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task32
{
    class PetShop
    {
        static void Main(string[] args)
        {
            Animal.IAnimal myDog = new Dog();
            myDog.Introduce();
            Animal.IAnimal myCat = new Cat();
            myCat.Introduce();
            Console.WriteLine();
            myDog.AddPet();
            myCat.AddPet();
            Console.ReadKey();
        }
    }
}
