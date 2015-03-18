namespace MegaCollections.Tests
{
    class Program
    {
        static void Main()
        {
            //първо си добавяме референция към другия обект, за да мога да си довавям класове вътре
            Deque<int> deque = new Deque<int>(40);
            ////искаме да добавяме отпред и отзад
            //deque.AddFront(5);//5
            //deque.AddFront(10);//10 5
            //deque.AddBack(20);//10 5 20
            ////дай ми колко елемента пазя вътре
            //int count = deque.Count;//3
            ////System.Console.WriteLine(count);

            ////освен, че я маха стойността, ни я връща
            //int frontElement = deque.RemoveFront();
            //System.Console.WriteLine(frontElement);
            //frontElement = deque.RemoveFront();
            //System.Console.WriteLine(frontElement);
            //frontElement = deque.RemoveFront();
            //System.Console.WriteLine(frontElement);

            //System.Console.WriteLine(deque.Count);


            //int backRemove = deque.RemoveBack();
            ////погледни и ми дай стойността, която е най-отпред на този дек(Deque), обаче не я махай
            //int frontPeek = deque.PeekFront();
            //int backPeek = deque.PeekBack();

            //int maxCapacity = deque.Capacity;
            ////може да си направим прайвит метод, който да ни проверява дали масива е празен
            ////bool isEmpty = deque.IsEmpty;
            
            //for (int i = 0; i < 20; i++)
            //{
            //    deque.AddFront(i);
            //}
            
            //for (int i = 0; i < 20; i++)
            //{
            //    deque.AddBack(i);
            //}
            ////задавам му 40 елемента и му казвам махни ми 5 отпред
            //for (int i = 0; i < 5; i++)
            //{
            //    System.Console.WriteLine(deque.RemoveFront());
            //}
            
            //for (int i = 0; i < 5; i++)
            //{
            //    System.Console.WriteLine(deque.RemoveBack());
            //}
            
            //System.Console.WriteLine(deque.Count);
            
            ////индексираме като при масивите, може да индексираме повече от един елемент
            //deque[0] = 500;
            //System.Console.WriteLine(deque[0]);
            
            //оператори

            deque.AddFront(10);
            deque.AddBack(50);//10 50

            Deque<int> anotherDeque = new Deque<int>();

            //създаваме си оператор +, който взима два дека(deque)
            anotherDeque.AddFront(5);
            anotherDeque.AddFront(10);//10 5
            //крайния резултат - ще ни вземе всички елементи от единия дек, ще ги събере и ще ги добави до всички елементи на другия дек
            //и на края ще получи един общ с първите и вторите елементи едно до друго
            Deque<int> result = deque + anotherDeque;//10 50 10 5
            
            //3:30:00
        }
    }
}
