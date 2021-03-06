namespace MegaCollections
{
    using System;
    //атрибутите са чисто за девелопера
    [Author("Ivailo Kenov")]
    [Author("Nikolai Kostov")]
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
            //най-малката стойност е 2(this.Capacity) и го / 2 - 1
            if (InitialSize < 2)
            {
                throw new IndexOutOfRangeException("Initial size of Deque must be bigger than 2.");
            }
            this.data = new T[InitialSize];
            //инициализираме си началото и края на масива
            this.frontIndex = this.Capacity / 2 - 1;
            this.backIndex = this.Capacity / 2;
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
        
        public void AddFront(T element)
        {
            //проверяваме дали текущия елемент не е извън масива, защото, ако текущия елемент е на масива може спокойно да го добавим
            //ако имаме Deque с 16 елемента и напълни точно 16, няма нужда да го resize-ваме
            if (this.frontIndex < 0)
            {
                this.ResizeData();
            }
            //след като го увеличиш или и да не го увеличиш, може да запишеш някаква стойност
            this.data[this.frontIndex] = element;
            this.frontIndex--;
        }
        
        public void AddBack(T element)
        {
            //ако е равно на капацитета трябва да увеличавам
            if (this.backIndex == this.Capacity)
            {
                this.ResizeData();
            }

            this.data[this.backIndex] = element;
            this.backIndex++;
        }
        
        public T RemoveFront()
        {
            //проверка дали има какво да извади
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty.");
            }
            //за да изкарам индекс от масиваа и да върнем числото от него като резултат
            //ако имаме масив с 4 елемента, започваме от средата наляво и примерно имаме 3(на първия индекс) и нулевия индекс, който е празен
            //първо увеличаваме frontIndex, той(индекса) става равен на 1
            this.frontIndex++;
            //връщаме резултата-тройката, и следващия път ще записвам на индекс 1
            return this.data[frontIndex];
        }
        
        public T RemoveBack()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty.");
            }
            this.backIndex--;
            return this.data[backIndex];
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
        
        //индексатор - връща ни Т
        public T this[int index]
        {
            get 
            {
                //първо си правим проверка дали има индекс въобще
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                return this.data[frontIndex + index + 1];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                
                this.data[this.frontIndex + index + 1] = value;
            }
        }

        //създаваме си оператор +, който взима два дека(deque)
        public static Deque<T> operator +(Deque<T> first, Deque<T> second)
        {
            //throw new NotImplementedException();
            //първо трябва да си създам нов дек от Т, след това трябва в тозии резултат да сложа всички стойности на първия и да добавя след това всички стойности на втория
            Deque<T> result = new Deque<T>();

            //хващам първия и ги добавям на крайния резултат всичките му елементи
            for (int i = 0; i < first.Count; i++)
            {
                result.AddBack(first[i]);
            }
            //хващам втория добавям ги и тях
            for (int i = 0; i < second.Count; i++)
            {
                result.AddBack(second[i]);
            }
            return result;
        }
        
        //ресайзваме когато трябва да добавим елемент и няма място за него
        private void ResizeData()
        {
            //ако сме били на 8 ще стане на 16
            int newSize = this.Capacity * 2;
            T[] newData = new T[newSize];//новия масив 

            //стария индекс (намираме се в средата на стария масив)
            //тръгваме от средата и един по един трябва да копираме елементите
            int currentFrontIndex = this.Capacity / 2 - 1;
            int currentBackIndex = this.Capacity / 2;
            
            //пазиме къде ще записваме данните
            int newFrontIndex = newSize / 2 - 1;
            int newBackIndex = newSize / 2;
            
            //имаме цикъл, който върви и копира
            while (true)
            {
                //прекъсване на цикъла
                if (currentFrontIndex <= this.frontIndex &&
                    currentBackIndex >= this.backIndex)
                    {
                        break;
                    }
                
                if (currentFrontIndex > this.frontIndex)
                //копиране
                {
                    newData[newFrontIndex] = this.data[currentFrontIndex];
                    newFrontIndex--;
                    
                }
                
                if (currentBackIndex > this.backIndex)
                //копиране
                {
                    newData[newBackIndex] = this.data[currentBackIndex];
                    newBackIndex++;
                    
                }
                currentBackIndex++;
                currentFrontIndex--;
            }
            
            this.data = newData;
            //трябва да сетнем новите индекси
            this.frontIndex = newFrontIndex;
            this.backIndex = newBackIndex;
            
            
        }
    }
}
