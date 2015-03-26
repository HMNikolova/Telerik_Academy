namespace AnimalKindom.Models
{
    using AnimalKindom.Interfaces;

    public class Dolphin : Mammal, IPet
    {

        public string Owner
        {
            get { throw new System.NotImplementedException(); }
        }

        public decimal Price
        {
            get { throw new System.NotImplementedException(); }
        }

        public string ProvokeHappiness()
        {
            throw new System.NotImplementedException();
        }
        //движи си опашката
        public override void Move()
        {
            this.FlapTail();
        }

        private void FlapTail()
        {
            throw new System.NotImplementedException();
        }
    }
}
