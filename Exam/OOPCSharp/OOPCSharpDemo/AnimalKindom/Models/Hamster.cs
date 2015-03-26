namespace AnimalKindom.Models
{
    public class Hamster : Mammal
    {
        public Hamster()
        {
            base.Name = "Gosho";
        }
        
        public virtual string ProvokeHappiness()
        {
            return "Your human is happy";
        }
    }
}
