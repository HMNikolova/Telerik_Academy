namespace EverythingElse.Extensions
{
	//17 минута нова папка
	//22:14
	using System;
	using System.Collections.Generic;
					
	public static class LIstOfIntExtensions
	{
		//метдо, който хваща лист от интове и му добавя някаква стойност на всеки един елемент вътре в него
		//трябва да кажем какво искаме да екстендваме, лист от интове, след това числото, с което искаме да увеличаваме този лист numbers
		public static void IncreaseWithNumber(this List<int> numbers, int numberToAdd)
		{
			for (int i = 0; i < numbers.Count; i++)
			{
				numbers[i] += numberToAdd;
			}
		}
	}
}