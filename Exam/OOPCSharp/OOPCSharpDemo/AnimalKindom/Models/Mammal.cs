namespace AnimalKindom.Models
{
    //задаваме си въпроса: Животното вид бозайник ли е? - ако да правим наследяване
    public class Mammal : Animal
    {
        public Mammal() : base(0)
        {

        }
        public string Name { get; protected set; }

        public abstract void Move();
        //2:14:00
    }
}
