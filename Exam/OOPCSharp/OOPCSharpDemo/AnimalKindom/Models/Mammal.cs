namespace AnimalKindom.Models
{
    using AnimalKindom.Interfaces;

    //задаваме си въпроса: Животното вид бозайник ли е? - ако да правим наследяване
    public class Mammal : Animal, IAnimal
    {
        public Mammal() : base(0)
        {

        }
        public string Name { get; protected set; }

        public virtual void Move()
        { 
        
        }
        
    }
}
