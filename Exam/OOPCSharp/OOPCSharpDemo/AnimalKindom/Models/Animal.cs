namespace AnimalKindom.Models
{
    using AnimalKindom.Interfaces;

    //задаваме си въпроса: Животното вид сърце ли е? - ако да правим наследяване
    public class Animal : IAnimal
    {
        //правим си конструктор и му казваме: когато и да направиш животно, му сетваш, че е живо
        public Animal()
        {
            this.IsAlive = true;
        }
        //с this извикваме горния конструктор, за да не се повтаря код
        public Animal(int age) : this()
        {
            this.Age = age;
        }
        //живо ли е
        public bool IsAlive { get; set; }

        //задаваме си въпроса: Животното има ли сърце? - ако да правим пропърти
        public Heart Heart { get; private set; }//private - защото животното не иска докато спи някой да отиде и да му смени сърцето

        public int Age { get; private set; }

        public void Eat(IEdable food)
        {

        }

        public void Die()
        {
            this.IsAlive = false;
        }
    }
}
