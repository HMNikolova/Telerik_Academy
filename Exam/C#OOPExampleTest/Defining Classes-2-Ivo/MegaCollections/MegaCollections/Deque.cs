namespace MegaCollections
{
    using System;
    //първо трябва да кажа на класа да бъде шаблонен с <T>
    public class Deque<T>
    {
        private const int InitialSize = 16;
        //като за начало искам масив, който да ми съдържа данните на този deque
        private T[] data;
        private int frontIndex;
        private int backIndex;
        
        //казваме, ако някой ми създаде Deque без нищо, какво се случва от този конструктор 
        //извиквам другия конструктор, който ни създава InitialSize, който взима първоначалната стойност 16
        public Deque() : this(InitialSize)
        {
            //в момента, в който му създам празен Deque, вътре му се създава масив от 16 елемента
            //за да не преизползваме код като долния ред ползваме горе в конструктура this
            //this.data = new T[InitialSize];
        }
        
        public Deque(uint InitialSize)
        {
            //най-малката стойност е 2(this.data.Length) и го / 2 - 1
            if (InitialSize < 2)
            {
                throw new IndexOutOfRangeException("Initial size of Deque must be bigger than 2.");
            }
            this.data = new T[InitialSize];
            //инициализираме си началото и края на масива
            this.frontIndex = this.data.Length / 2 - 1;
            this.backIndex = this.data.Length / 2;
        }
        //глупаво е да може да set-вам count
        public int Count 
         {
            get 
            {
                //ако имаме масив с 8 индекса и четири запълнени, например от 4 индекс нататък
                //формулата ще ни бъде 8(индекса)-3(празни отпред) - 1 = 4(и получаваме четирите запълнени)
                return this.backIndex - this.frontIndex - 1;
            }
        }
        
        //Capacity по същия начин
        public int Capacity 
        {
            get 
            {
                return this.data.Length;
            }
        }
        
        public void AddFront(Т element)
        {
            throw new NotImplementedException();
        }
        
        public void AddBack(Т element)
        {
            throw new NotImplementedException();
        }
        
        public T RemoveFront()
        {
             throw new NotImplementedException();
        }
        
        public T RemoveBack()
        {
             throw new NotImplementedException();
        }
        
        public T PeekFront()
        {
            //ако няма нищо вътре гръмни
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty.");
                
            }
            //понеже вървим от средата назад и ако имаме един елемент(примерно числото 5) в frontIndex, а масива е с 4 елемента
            // за да ни го покаже трябва да напишем това, което е на долния ред
             return this.data[frontIndex + 1];
        }
        
        public T PeekBack()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty.");
                
            }
            //и ето го пък обратиня вариант, ако сме от средата надясно
            return this.data[backIndex - 1];
        }
         //1:55:10
    }
}
