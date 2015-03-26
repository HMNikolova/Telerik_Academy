
namespace AnimalKindom.Models
{
    using AnimalKindom.Interfaces;
    public class Monster : IAnimal
    {
        public bool IsAlive
        {
            get { throw new System.NotImplementedException(); }
        }

        public Heart Heart
        {
            get { throw new System.NotImplementedException(); }
        }

        public int Age
        {
            get { throw new System.NotImplementedException(); }
        }

        public void Eat(IEdable food)
        {
            throw new System.NotImplementedException();
        }

        public void Die()
        {
            throw new System.NotImplementedException();
        }
    }
}
