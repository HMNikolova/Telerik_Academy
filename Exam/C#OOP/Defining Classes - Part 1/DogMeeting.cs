using System;
using System.Collections.Generic;

class DogMeeting
{
    //properties - нещо през което достъпваме данните,държът се като полета, но могат да имат логика в тях
    static void Main()
    {
        //39:45
        //var listOfInts = new Dictionary<string, int>();
        //Console.WriteLine(listOfInts["Niki"]);//ИНДЕКСАТОР - [0]

        //Console.Write("Enter first dog's name: ");
        //string dogName = Console.ReadLine();
        //Console.Write("Enter first dog's breed: ");
        //string dogBreed = Console.ReadLine();

        // Use the Dog constructor to assign name and breed
        Dog firstDog = new Dog("sharo",  "pomiar");
        firstDog.Walk();

        firstDog.NameChange += firstDog_NameChange;//+= И два пъти табулация прави метода, и казваме искам да извикаш този метод когатоимето на кучето се промени
        firstDog.Name = "Sharo2";
        firstDog.Name = "Sharo3";
        //Console.WriteLine(firstDog["breed"]);

        //// Create a new dog using the parameterless constructor
        //Dog secondDog = new Dog();

        //// Use properties to set name and breed
        //Console.Write("Enter second dog's name: ");
        //secondDog.Name = Console.ReadLine();
        //Console.Write("Enter second dog's breed: ");
        //secondDog.Breed = Console.ReadLine();

        //// Create a Dog with no name and breed
        //Dog thirdDog = new Dog();

        //// Save the dogs in an array
        //Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

        //// Ask each of the dogs to bark
        //foreach (Dog dog in dogs)
        //{
        //    dog.SayBau();
        //}
    }

    static void firstDog_NameChange(object sender, EventArgs e)
    {
        Console.WriteLine("Name changed!!!");
    }

   
}