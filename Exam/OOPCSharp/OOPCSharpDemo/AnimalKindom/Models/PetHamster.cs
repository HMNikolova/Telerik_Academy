namespace AnimalKindom.Models
{
    using AnimalKindom.Interfaces;

    public class PetHamster : Hamster, IPet
    {

        public string Owner
        {
            get { throw new System.NotImplementedException(); }
        }

        public decimal Price
        {
            get { throw new System.NotImplementedException(); }
        }

        public void ProvokeHappiness()
        {
            throw new System.NotImplementedException();
        }
    }
}
