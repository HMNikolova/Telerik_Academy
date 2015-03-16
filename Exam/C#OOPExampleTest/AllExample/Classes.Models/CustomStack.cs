namespace Classes.Models
{
    using Classes.Models.Interfaces;
    using System;
    //T e темплейтен тип
    //МОГА ДА ИЗРЕЖДАМ МНОГО НЕЩА НА КОИТО ТРЯБВА ДА ОТГОВАРЯ Т, ЗА ДА БЪДЕ ИЗПОЛЗВАНО ОТ МОЯТА СТРУКТУРА
    public class CustomStack<T> : IStack<T> where T : IComparable<T>, new()//CustomStack<T> наследява IStack<T>, и като натиснем върху IStack ctrl+. то ни добавя в CustomStack всички методи, които има IStack
    {
        //в който и момент да реша може Т да го направя масив от Point
        private T[] arr;
        private const int InirialLenght = 4;
        private int count;
        private int nextIndex;
        #region Constructors
        public CustomStack()
        {
            this.arr = new T[InirialLenght];
            this.nextIndex = 0;
            this.Count = 0;
        }
        #endregion


        public int Capacity 
        { 
            get { return this.arr.Length; } 
        }

        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }
        #region PublicMethods
        public void Push(T element)
        {
            if (this.nextIndex == this.arr.Length)
            {
               this.DoubleSize();
            }
            this.arr[nextIndex] = element;
            this.nextIndex++;
            this.Count++;
        }
        //да вкраваме три елемента едновременно
        //метод на който да не ме задължава да правя винаги масив(params T[] elements)
        public void Push(params T[] elements)
        {
            foreach (T element in elements)
            {
                this.Push(element);
            }
        }
        
        //индексация
        //някой ако се опита да достъпи индексатора да му каже това все още не е инплементирано
        //public T this[int index, string descrip]{
        
        //проверка, ако някой се опита да достъпи индекс, който е повече от моя акаунт
        //за да не трябва да затривам елементите, които сме Pop-нали
        public T this[int index]{
            //get{ throw new NotImplementedException();}
            //set{ throw new NotImplementedException();}
            get
            {
               if (index < 0 || index >= this.nextIndex)
               {
                   throw new ArgumentOutOfRangeException();
               }
               
               return this.arr[index];
            }
        } 
        
        //може да си преизползваме самия индекс
        //с this.[index] аз извиквам горния индексатор
        public T GetPointAtIndex(int index)
        {
            return this.arr[index];
            
        }
        
        private void DoubleSize()
        { 
            T[] newArr = new T[this.arr.Length * 2];
            for (int i = 0; i < this.arr.Length; i++)
            {
                newArr[i] = this.arr[i];
            }

            this.arr = newArr;
        }

        public T Pop()
        {
            //за да изкра най-горния трябва да има count - 1
            T element = this.arr[this.count - 1];
            this.count--;
            this.nextIndex--;
            return element;
        }

        public T Top()
        {
            //прави същото като Pop, но count и nextIndex няма да се променят
            T element = this.arr[this.count - 1];
            return element;
        }

        #endregion
        
        
        
        public T Last
        {
            get { return this.Top(); }
        }
    }
}
