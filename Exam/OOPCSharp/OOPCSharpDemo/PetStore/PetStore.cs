//чекваме си референция AnimalKindom
namespace PetStore
{
    using AnimalKindom.Interfaces;
    using AnimalKindom.Models;
    using System;
    using System.Collections.Generic; 

    public class PetStore
    {
        static IList<IPet> pets = new IList<IPet>();
        //List<Dolphin> dolphins = new List<Dolphin>();
        //List<Cat> cats = new List<Cat>();
        //List<Parrot> parrots = new List<Parrot>();
        static void Main()
        {
            //правим си обекта и си добавяме using AnimalKindom.Models;
            PetHamster hammy = new PetHamster();
            Console.WriteLine(hammy.ProvokeHappiness());

            pets.Add(new Dolphin());
            pets.Add(new PetHamster());
            pets.Add(new Cat());
            
            ProntToConsole(pets);
            //ограничавам го че ще работя само с животни, за да мога да достъпя ProvokeHappiness
            private static void ProntToConsole<T>(ICollection<T> collection) where T : IPet
        {
            foreach (var pet in collection)
            {
                Console.WriteLine(pet.ProvokeHappiness());
            }
            
            //откъде идва класа
            //var type = typeof(Hamster);
            //Console.WriteLine(type.BaseType);
            
            //List<IAnimal> list = new List<IAnimal>();
            //list.Add(new Hamster());
            //list.Add(new Monster());

            //List<int> nums = new List<int> {1,2,3,4,5,6};
            //ProntToConsole(nums);
            
            //string[] otherNums = new string[] {"10", "20", "30"};
            //ProntToConsole(otherNums);
        }
        
         //private static void ProntToConsole<T>(ICollection<T> collection)
        //{
            //foreach (var num in collection)
            //{
                //Console.WriteLine(num);
            //}
        //}
        
        ////private static void ProntToConsole(List<int> collection)
        ////{
            ////foreach (var num in collection)
            ////{
                ////Console.WriteLine(num);
            ////}
        ////}
        
       
    }
}
