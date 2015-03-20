namespace EverthingElse.Extensions
{
    public static class StringExtensions
    {
        //всеки един Extension метод трябва да бъде статичен
        //следващото нещо е да сложим думата this като първи аргумент и след това да  сложим какво искаме да екстендваме
        //така казвам на C# имам static клас и static метод в него и той казва this string и той ще се сети ти искаш по този начин
        //искаш всички стрингове да може да им се извиква CountWords
        public static int CountWords(this string input)
        {
            var words = input.Split(' ');
            
            return words.Length;
        }
        //да покажем на c#, че ние искаме да екстендваме стрингове
        
    }
}
