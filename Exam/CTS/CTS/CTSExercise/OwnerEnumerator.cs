using System.Collections.Generic;
namespace CTSExercise
{
    public class OwnerEnumerator : IEnumerator<Cat>
    {
        //трябва ни колекция
        private List<Cat> cats;
        //текущия елемент
        private int index;

        //OwnerEnumerator може да работи само ако някой му подаде лист от котки
        public OwnerEnumerator(List<Cat> cats)
        {
            //ще ни изкара колекцията на обратно
            cats.Reverse();
            this.cats = cats;
            //ще кажем, че когато създадем Enumerator-а текущия елемент е 0
            this.index = -1;
        }

        //нещо което връща текущата котка
        public Cat Current
        {
            //върни ми следващия елемент
            get { return this.cats[this.index]; }
        }

        public void Dispose()
        {
            
        }
        //нещо което връща текущата котка като обект
        object System.Collections.IEnumerator.Current
        {
            get { return this.Current; }
        }
        //нещо което казва по какъв начин да минем напред в колекцията
        //дали има следващ елемент и този следващ елемент кой е
        public bool MoveNext()
        {
            //ако имаме следващ елемент в тези котки
            if (this.index >= this.cats.Count - 1)
            {
                
                //трябва да върнем false
                return false;
            }
            //ако имаме следващ елемент значи минаваме на следващ елемент
            this.index++;
            return true;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }
}