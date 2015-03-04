using System;
using System.Text;	
using System.Collections.Generic;
public class Program
{
	private const string RevTagOpen = "<rev>";
	private const string UpperTagOpen = "<upper>";
	private const string LowerTagOpen = "<lower>";
	private const string ToggleTagOpen = "<toggle>";
	private const string DelTagOpen = "<del>";
	
	private const string RevTagClose = "</rev>";
	private const string UpperTagClose = "</upper>";
	private const string LowerTagClose = "</lower>";
	private const string ToggleTagClose = "</toggle>";
	private const string DelTagClose = "</del>";
	
	private static int openedDelTags = 0;//правим си една глобална променлива, когато срещнем openedDelTags(отварящ таг) ще увеличаваме тази променлива с 1, когато срещнем затварящ таг ще го намаляваме с 0
	//и при обработката на нашите тагове и символи ще проверяваме дали openedDelTags е равно на 0, ако е равно на 0 значи трябва да правим нещо, ако не е равен на 0 значи сме в openedDelTags
	//следователно нас не ни интересува, каквото и да има вътре е безсмислено за нас да го търсим (rev,upper,lower...) не ни пука, защото то ще се изтрие евентиално, защо да го мъчим
	private static StringBuilder output = new StringBuilder();//тук ще си трупаме входа - буфериране на изхода - не пишем в конзолата, ами си трупаме някъде и накрая изписваме всичко на веднъж
	
	private static List<string> currentOpenTag = new List<string>();//ще си бутаме всички тагове, които ни трябват
	private static List<int> revTagStarts = new List<int>();//трябва ни лист откъде започват индексите
	
	public static void Main()
	{
		int numberOfLines = int.Parse(Console.ReadLine());//колко линии ще имаме в целия вход
		for (int i = 0; i < numberOfLines; i++)
		{
			string currentLine = Console.ReadLine();//трябва ни текущата линия
			int currentSymbolIndex = 0;//ще трябва да вървим символ по символ
			while (currentSymbolIndex < currentLine.Length)//вървим символ по символ с currentSymbolIndex докато обходим currentLine
			{
				if (currentLine[currentSymbolIndex] == '<')
				{
					string tag = GetTag(currentLine, currentSymbolIndex);//взимаме тага си
					ProcessTag(tag);//обработка на тага
					//взимаме тага с tag и ще променяме от следващия индекса т.е. от края на тага продължаваме, няма смисъл да четем символите в тага
					currentSymbolIndex += tag.Length - 1;//към currentSymbolIndex прибавяме дължината на тага - 1, защото дължината на тага връща с едно по-голямо от това, което ни трябва
				}
				else
				{
					if(openedDelTags == 0)
					{
						//тук обработваме символите таговете
						char symbolToAdd = currentLine[currentSymbolIndex];//взимаме символа, който ще трябва да маниполираме
						
						//върху symbolToAdd ще трябва да изредим всички тагове, които имаме до момента
						//трябва ни обратен for защото таговете се гледат от вън на вътре
						for (int j = currentOpenTag.Count -1; j >= 0; j--)
						{
							symbolToAdd = ApplyEffects(symbolToAdd, currentOpenTag[j]);//на symbolToAdd трябва да присвоим новата стойност, която ще се генерира от метода ApplayEffects, приема symbolToAdd и тага, който искаме да аплайне ефекта
						}
						
						output.Append(symbolToAdd);//трябва да си добавим символа в StringBuilder
					}
				}
				currentSymbolIndex++;//и минаваме на следващия символ
			}
            
            output.Append('\n');//заради windows вместо output.AppendLine(); слагаме output.Append('\n');
            //output.Append('\n'); - това и output.Replace("\n", Environment.NewLine);, който е на долния ред също дават 100 точки
        }
        //output.Replace("\n", Environment.NewLine);
        Console.WriteLine(output.ToString().Trim());
	}

        private static char ApplyEffects(char symbolToAdd, string currentOpenTag)
        {
            if (char.IsLetter(symbolToAdd))//ако е буква прави това
	            {
		             if (currentOpenTag ==UpperTagOpen)
                        {
                            symbolToAdd = char.ToUpper(symbolToAdd);
                        }
                        else if (currentOpenTag == LowerTagOpen)
                        {
                            symbolToAdd = char.ToLower(symbolToAdd);
                        }
                        else if (currentOpenTag == ToggleTagOpen)
                        {
                            if (char.IsLower(symbolToAdd))//проверка дали да малки буквите
                            {
                                symbolToAdd = char.ToUpper(symbolToAdd);//ако са малки направи ги големи 
                            }
                            else
                            {
                                symbolToAdd = char.ToLower(symbolToAdd);
                            }
	                    }
                }
            return symbolToAdd;
        }

        private static void ProcessTag(string tag)
        {
		        if (tag == DelTagOpen)
		        {
			        openedDelTags++;//увеличаваме си с 1, не ни пука какво има в този openedDelTags защото то се зачиства
		        }
		        else if (tag == DelTagClose)
		        {
			        openedDelTags--;
		        }
		        else
		        {
			        if(openedDelTags == 0)//трябва да проверим дали вече сме в DelTag
			        {
				        if (tag == RevTagOpen)//тук слагаме стартовите точки
				        {
					        //до този момент имаме някакви символи в output-a и казваме от тук в output-a трябва да почнеш да обръщаш
					        revTagStarts.Add(output.Length);//от където сме в момента, output-а ни който е в момента трябва да се обърне
				        }
				        else if (tag == RevTagClose)
				        {
                            //взимаме от revTagStarts последния елемент
				            int currentRevStart = revTagStarts[revTagStarts.Count - 1];
                            int revEnd = output.Length - 1;
                            Reverse(currentRevStart, revEnd);//когато ревърснем всичко
                            revTagStarts.RemoveAt(revTagStarts.Count - 1);//трябва да махнем последната точка, от която обръщаме (заради нестнатите тагове, а ние обръщаме само от 1 точка)
				        }
				        else if (tag[1] == '/')//ако тага е затварящ, просто ще премахнем последния
				        {
					        currentOpenTag.RemoveAt(currentOpenTag.Count - 1);//как може да премахнем последния елемент от листа - с RemoveAt
				        }
				        else
				        {
					        currentOpenTag.Add(tag);////ще си бутаме всички тагове, които ни трябват в currentOpenTag
				        }
					
			        }
		        }
	
        }

        private static void Reverse(int currentRevStart, int revEnd)
        {
            int start = currentRevStart;
            int end = revEnd;
            //как може да ревърснем символите между два индекса
            while (start < end)
            {
                //като размяната при променливи
                char bufferChar = output[start];
                output[start] = output[end];
                output[end] = bufferChar;

                end--;
                start++;
                //докато старта е < енда прави ревърс
            }
            
        }

    private static string GetTag(string currentLine,int currentSymbolIndex)
    {
		//взимаме тага от нашата линия
		int tagsStart = currentSymbolIndex;//tagsStart е с инфекса, който току що сме подали - намерили сме стартиращ таг (== '<') и symbolIndex ни е старта на тага
		int tagEnd = currentLine.IndexOf('>', tagsStart + 1);//търсим края на тага ('>') и започваме от tagsStart + 1; така разбираме къде е края на тага
		string tag = currentLine.Substring(tagsStart, tagEnd - tagsStart + 1);//започваме от tagsStart и второ колко е дължината на Substring-а, която искам да вземем (tagEnd - tagsStart + 1)
		return tag;
	
    }
	
	
	
}