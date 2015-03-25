namespace SchoolSystem.Interfaces
{
    public interface IPerson
    {
        string EMail { get; }

        string Name { get; }

        Gender Gender { get; }

        void Walk();
    }
}
