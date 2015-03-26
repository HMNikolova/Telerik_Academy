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

            //откъде идва класа
            //var type = typeof(Hamster);
            //Console.WriteLine(type.BaseType);
            
            //List<IAnimal> list = new List<IAnimal>();
            //list.Add(new Hamster());
            //list.Add(new Monster());

            //2:40:00
        }
    }
}
