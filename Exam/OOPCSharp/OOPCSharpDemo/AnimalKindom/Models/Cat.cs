﻿using AnimalKindom.Interfaces;
namespace AnimalKindom.Models
{
    public class Cat : Mammal, IAnimal, IPet
    {

        public string Owner
        {
            get { throw new System.NotImplementedException(); }
        }

        public decimal Price
        {
            get { throw new System.NotImplementedException(); }
        }

        public string ProvokeHappiness()
        {
            throw new System.NotImplementedException();
        }
    }
}
