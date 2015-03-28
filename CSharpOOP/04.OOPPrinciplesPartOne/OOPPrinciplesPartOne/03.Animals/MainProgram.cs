/*
    Problem 3: Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
    Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
    Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only 
    female and tomcats can be only male. Each animal produces a specific sound.
        Create arrays of different kinds of animals and calculate the average age of each kind of animal using 
    a static method (you may use LINQ).
 */
namespace _03.Animals
{
    using System;

    public class MainProgram
    {
        static void Main()
        {
            Dog[] dogs = new Dog[]
            {
                new Dog("Paco", 6, true, "Nemska ovcharka"),
                new Dog("Remi", 3, false, "Pincher"),
                new Dog("Silvestar", 2, true, "Labrador")
            };

            Frog[] frogs = new Frog[] 
            { 
                new Frog("Zlatka", 1, false),
                new Frog("Valeri", 3, true),
                new Frog("Jeni", 5, false)
            };

            Cat[] cats = new Cat[] 
            {
                new Cat("Cati", 3, false),
                new Cat("Maci", 5, false),
                new Cat("Persio", 1, true)
            };

            Kitten[] kittens = new Kitten[]
            {
                new Kitten("Malcho", 1,true),
                new Kitten("Vachi", 2, true),
                new Kitten("Sladicho", 1, false)
            
            };

            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat("Tom", 5, true),
                new Tomcat("Tomita", 4, false),
                new Tomcat("Peni", 8, false)
            };

            double dogsAverageAge = Animal.AverageAge(dogs);
            double frogsAverageAge = Animal.AverageAge(frogs);
            double catsAverageAge = Animal.AverageAge(cats);
            double kittensAverageAge = Animal.AverageAge(kittens);
            double tomcatsAverageAge = Animal.AverageAge(tomcats);

            Console.WriteLine("Average age of the dogs: {0:F2}", dogsAverageAge);
            Console.WriteLine("Average age of the frogs: {0:F2}", frogsAverageAge);
            Console.WriteLine("Average age of the cats: {0:F2}", catsAverageAge);
            Console.WriteLine("Average age of the kittens: {0:F2}", kittensAverageAge);
            Console.WriteLine("Average age of the tomcats: {0:F2}", tomcatsAverageAge);

            Console.WriteLine(new string('-', 10));

            Console.WriteLine("Actions: ");
            Console.WriteLine(tomcats[0].Hunt());
            Console.WriteLine(cats[1].BeJovial());
            Console.WriteLine(dogs[2].Fetch());
            Console.WriteLine(frogs[1].Jump());

            Console.WriteLine(new string('-', 10));

            Console.WriteLine("Sound: ");
            cats[0].MakeSound();
            dogs[1].MakeSound();
            frogs[2].MakeSound();
        }
    }
}
