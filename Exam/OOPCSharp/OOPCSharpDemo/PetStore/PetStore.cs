//чекваме си референция AnimalKindom
namespace PetStore
{
    using AnimalKindom.Interfaces;
    using AnimalKindom.Models;
    using System;
    using System.Collections.Generic; 

    public class PetStore
    {
        static void Main()
        {
            //правим си обекта и си добавяме using AnimalKindom.Models;
            PetHamster hammy = new PetHamster();
            Console.WriteLine(hammy.ProvokeHappiness());
            
            //List<IAnimal> list = new List<IAnimal>();
            //list.Add(new Hamster());
            //list.Add(new Monster());
        }
    }
}
