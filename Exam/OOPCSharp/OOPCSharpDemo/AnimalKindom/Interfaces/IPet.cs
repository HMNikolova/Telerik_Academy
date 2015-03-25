namespace AnimalKindom.Interfaces
{
    public interface IPet
    {
       string Owner { get; }
       decimal Price { get; }

       void ProvokeHappiness();
    }
}
