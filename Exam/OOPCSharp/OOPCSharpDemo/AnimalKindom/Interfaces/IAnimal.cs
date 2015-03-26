
namespace AnimalKindom.Interfaces
{
    using AnimalKindom.Models;
    public interface IAnimal
    {
        bool IsAlive { get; }
        Heart Heart { get; }
        int Age { get; }

        void Eat(IEdable food);
        void Die();
    }
}
