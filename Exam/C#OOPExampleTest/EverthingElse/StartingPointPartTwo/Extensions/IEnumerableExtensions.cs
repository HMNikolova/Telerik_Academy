namespace StartingPointPartTwo.Extensions
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableExtensions
    {
        //Extensions метод, който ми дава ForEach върху IEnumerable
        //казваме че искаме да екстенднем всяка една колекция, която е IEnumerable<T>
        //т.е. всяка една колекция, която може да се foreach-ва искаме да я екстенднем независимо от стрингове, интове и т.н
        //искаме да приемем онзи Action, който се намира в System - Action<T>
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                //изпълни ми Action-а от item-и
                action(item);
            }
        }
    }
}
