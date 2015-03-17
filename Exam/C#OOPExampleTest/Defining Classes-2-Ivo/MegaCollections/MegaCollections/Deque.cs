namespace MegaCollections
{
    using System;
    //първо трябва да кажа на класа да бъде шаблонен с <T>
    public class Deque<T>
    {
        private const int InitialSize = 16;
        //като за начало искам масив, който да ми съдържа данните на този deque
        private T[] data;
        private int frontIndexer;
        private int backIndexer;
        
        public Deque()
        {
            //в момента, в който му създам празен Deque, вътре му се създава масив от 16 елемента
            this.data = new T[InitialSize];
        }
        
        public Deque(int InitialSize)
        {
            if (InitialSize < 2)
            {
                throw new IndexOutOfRangeException()
            }
            this.data = new T[InitialSize];
        }
    }
}
