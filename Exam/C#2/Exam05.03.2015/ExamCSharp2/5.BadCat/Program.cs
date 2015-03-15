using System;

public class Program
{
    public static void Main()
    {

        //четем си входа
        var input = Console.ReadLine();
        //обръщаме го в чар масив
        var inputAsCharArray = input.ToCharArray();
        Array.Sort(inputAsCharArray);//първо сортираме и после прилагаме пермутации
        int count = 0;
        do
        {
            //правим някакви стъпки
            //ако думата отговаря на условията
            if (IsMatch(inputAsCharArray))
            {
                count++;//увеличаваме брояча с еденица
            }
        }
        while (NextPermutation(inputAsCharArray));//прилагаме пермутации докато това нещо не ни върне true

        Console.WriteLine(count);
    }
    /// <summary>
    /// Transform array of chars to next permutation.
    /// Rearranges the elements into the next lexicographically greater permutation.
    /// </summary>
    /// <param name="array">The array of elements to be sorted</param>
    /// <returns>
    /// true if the function could rearrange the object as a lexicographically greater permutation.
    /// Otherwise, the function returns false to indicate that the arrangement is not greater than the previous, but the lowest possible (sorted in ascending order).
    /// </returns>
    private static bool NextPermutation(char[] array)
    {
        for (int index = array.Length - 2; index >= 0; index--)
        {
            if (array[index] < array[index + 1])
            {
                int swapWithIndex = array.Length - 1;
                while (array[index] >= array[swapWithIndex])
                {
                    swapWithIndex--;
                }

                // Swap i-th and j-th elements
                var tmp = array[index];
                array[index] = array[swapWithIndex];
                array[swapWithIndex] = tmp;

                Array.Reverse(array, index + 1, array.Length - index - 1);
                return true;
            }
        }

        // No more permutations
        return false;
    }

    public static bool IsMatch(char[] word)//дадената дума съвпадение ли е с условията, които имаме в условието на задачата
    {
        for (int i = 1; i < word.Length; i++)//започвам от 1-вата буква не от 0-левата, до последната (word.Length)
        {
            //ако намеря буква на текуща позиция, която да е равна на буква от предишна позиция
            //защото това няма да гръмне, защото винаги работя с индекс по-голям или равен 1 - т.е. 1-1=0, ще работя с нулевия елемент тук
            //последния - 1 ще е предпоследния и така сравняваме всеки с неговия предишен, след това следващия с неговия предишен
            //ако имам abcd започвам от b и го сравнявам с a

            if (word[i] == word[i - 1])
            {
                //ако примерно имам abcdd при сравнението на d с d те се оказват равни, това за нас е невалидна дума
                //опитвам се да докажа, че думата не е вярна
                return false;
            }
        }
        //ако не е така заключението е че думата е валидна
        return true;
    }

}