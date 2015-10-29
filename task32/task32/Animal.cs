using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task32
{
    abstract class Animal
    {
        string name;
        bool breed;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public bool Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }
        public interface IAnimal
        {
            void Introduce();
            void AddPet();
        }
    }
}
