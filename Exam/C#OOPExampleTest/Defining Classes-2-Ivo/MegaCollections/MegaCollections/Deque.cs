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
        
        //казваме, ако някой ми създаде Deque без нищо
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
    }
}
