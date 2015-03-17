namespace MegaCollections.Tests
{
    class Program
    {
        static void Main()
        {
            //първо си добавяме референция към другия обект, за да мога да си довавям класове вътре
            Deque<int> dequeOfIntegers = new Deque<int>();
            //искаме да добавяме отпред и отзад
            dequeOfIntegers.AddFront(5);
            dequeOfIntegers.AddBack(10);
            //освен, че я маха стойността ни я връща
            int frontRemove = dequeOfIntegers.RemoveFront();
            int backRemove = dequeOfIntegers.RemoveBack();
            //погледни и ми дай стойността, която е най-отпред на този дек(Deque), обаче не я махай
            int frontPeek = dequeOfIntegers.PeekFront();
            int backPeek = dequeOfIntegers.PeekBack();
            //дай ми колко елемента пазя вътре
            int elements = dequeOfIntegers.Count;
            int maxCapacity = dequeOfIntegers.Capacity;
            //може да си направим прайвит метод, който да ни проверява дали масива е празен
            //bool isEmpty = dequeOfIntegers.IsEmpty;
            
        }
    }
}
