using AnimalKindom.Interfaces;
﻿using System;
namespace AnimalKindom.Models
{
    public class Cat : Mammal, IAnimal, IPet, IComparable<IPet> 
    //IComparable<IPet> - сравнение на котката с домашен любимец
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
            return "Lay arround";
        }
        
        public int CompareTo(IPet other)
        {
            return (int)(this.Price - other.Price);
        }
    }
}
