namespace MegaCollections.Tests
{
    class Program
    {
        static void Main()
        {
            //първо си добавяме референция към другия обект, за да мога да си довавям класове вътре
            Deque<int> deque = new Deque<int>(40);
            //искаме да добавяме отпред и отзад
            deque.AddFront(5);//5
            deque.AddFront(10);//10 5
            deque.AddBack(20);//10 5 20
            //дай ми колко елемента пазя вътре
            int count = deque.Count;//3
            //System.Console.WriteLine(count);

            //освен, че я маха стойността, ни я връща
            int frontElement = deque.RemoveFront();
            System.Console.WriteLine(frontElement);
            frontElement = deque.RemoveFront();
            System.Console.WriteLine(frontElement);
            frontElement = deque.RemoveFront();
            System.Console.WriteLine(frontElement);

            System.Console.WriteLine(deque.Count);


            //int backRemove = deque.RemoveBack();
            ////погледни и ми дай стойността, която е най-отпред на този дек(Deque), обаче не я махай
            //int frontPeek = deque.PeekFront();
            //int backPeek = deque.PeekBack();

            //int maxCapacity = deque.Capacity;
            ////може да си направим прайвит метод, който да ни проверява дали масива е празен
            ////bool isEmpty = deque.IsEmpty;
            
            for (int = 0; i < 20; i++)
            {
                deque.AddFront(i);
            }
            
            for (int = 0; i < 20; i++)
            {
                deque.AddBack(i);
            }
            //задавам му 40 елемента и му казвам махни ми 5 отпред
            for (int = 0; i < 5; i++)
            {
                System.Console.WriteLine(deque.RemoveFront());
            }
            
            for (int = 0; i < 5; i++)
            {
                System.Console.WriteLine(deque.RemoveBack());
            }
            
            System.Console.WriteLine(deque.Count);
        }
    }
}
