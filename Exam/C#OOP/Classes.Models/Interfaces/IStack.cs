namespace Classes.Models.Interfaces
{
    public interface IStack<T>
    {
        T Last { get; }
        //искам да имам метод, който ще е void, и ще се казва Push и на него ще се подаде променлива от тип Т и се казва element
        void Push(T element);
        //метод - искам Pop да ми връща променлива от тип Т, да се казва Pop и да не му се подават никакви параметри
        T Pop();
        //метод Top, който нищо няма да приема и ще ми връща променлива от тип Т
        T Top();
    }
}
