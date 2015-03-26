namespace AnimalKindom.Models
{
    using AnimalKindom.Interfaces;

    public class PetHamster : Hamster, IPet
    {
        public PetHamster()
        {
            this.Owner = "Pesho";
        }

        public string Owner { get; private set; }

        public decimal Price
        {
            get { throw new System.NotImplementedException(); }
        }

        public override string ProvokeHappiness()
        {
            //извиква от базовия клас ProvokeHappiness
           return base.ProvokeHappiness() + "his name is" + this.Owner;
        }
        //{
            //System.Console.WriteLine("{0} is happy", this.Owner);
        //}
    }
}
