using System.Collections.Generic;
using System.Collections;
namespace LinkedList
{
    public class Program
    {
        static void Main()
        {
            //LinkedList за да стигнем до третия елемент трябва с foreach задължително да минем през 1,2 и 3 елемент
            //LinkedList знае само кой е следващия елемент
            //в LinkedList не може да искаме определен елемент 
            //LinkedList не знае точно кое къде се намира
            LinkedList<int> linkedList = new LinkedList<int>();
            var currentNode = linkedList.First;

            linkedList.AddFirst(1);
            //казваме след първия подай втория
            linkedList.AddAfter(currentNode, 2);

            //интерфейса IEnumerable<T> той си инплементира IEnumerable, 
            //който е бил преди да се появи IEnumerable<T>, направено е за да
            //може всичко старо да работи с новите неща
            //IEnumerable<T> като интерфейс само казва ти можеш да бъдеш форийчван 
            public interface IEnumerable<T> : IEnumerable
            {
                //IEnumerable<T> връща IEnumerator<T>, този IEnumerator<T>
                //е всъщност самата логика, която ни позволява ние да foreach-ваме нещо
                IEnumerator<T> GetEnumerator();
                //IEnumerator<T> има три метода
                //bool MoveNext по какъв начин да минем на следващия елемент
                //void Reset - дава ни възможност да почнем отначало
                //T Current { get; } - върни ми текущия елемент след операцията MoveNext
            }
        }
    }
}
