using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP
{
    class Program
    {
        public static string ReadInput()
        {
            string currentLine = Console.ReadLine().Trim();

            StringBuilder phpCode = new StringBuilder();//събираме си целия резултат

            while (currentLine != "?>")
            {
                phpCode.AppendLine(currentLine);//рабори и за едноредов коментар
                currentLine = Console.ReadLine().Trim();
            }

            return phpCode.ToString();
        }

        public static bool IsVariableSymbol(char symbol)//връща ни валидните букви в променливата
        {
            //текущия символ дали е валидна променлива
            if (char.IsLetterOrDigit(symbol) || symbol == '_')
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
        public static HashSet<string> ExtractWords(string inputCode)
        {
            HashSet<string> allVariables = new HashSet<string>();
            //в началото знаем, че не се в никакъв коментар
            bool inOneLineComment = false;//единичен коментар
            bool inMultiLineComment = false;//многоредов коментар
            bool inSingleQuoteString = false;//единични кавички
            bool inDoubleQuoteString = false;//двойни кавички
            bool inVariable = false;

            StringBuilder currentVariable = new StringBuilder();

            //стартиране на автомата
            for (int i = 0; i < inputCode.Length; i++)
            {
                char currentSymbol = inputCode[i];
                if (inOneLineComment)//ако сме в едноредов коментар
                {
                    if (currentSymbol == '\n')//и текущия символ минава на нов ред, тогава той вече не е едноредов
                    {
                        inOneLineComment = false;
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (inMultiLineComment)//ако сме в многоредов коментар
                {
                    if (currentSymbol == '*'
                        && i + 1 < inputCode.Length
                        && inputCode[i + 1] == '/')//текущия символ е звездичка, има следващ (не е извън нашия стринг) има и следващ символ '/'
                    {
                        inMultiLineComment = false;
                        i++;//проверка на следващия символ, ние не се нуждаем от него
                        continue;
                    }
                    else
                    {
                        continue;//продължавай на следващия символ, щом сме все още в коментар
                    }
                }

                if (inVariable)//в променлива
                {
                    if (IsVariableSymbol(currentSymbol))//ако текущия символ е валиден
                    {
                        currentVariable.Append(currentSymbol); //записваме го в StrinBuilder, който ни пази ни текущата променилива, която сме стигнали
                        continue;
                    }
                    else//ако текущия символ не е валиден, трябва да добавим към общия резултат, какво сме натрупали до тук в нашия StringBuilder
                    {
                        if (currentVariable.Length > 0)
                        {
                            //ако имаме само доларче някъде празно да не записваме простотии
                            //защото може в string да има бутнат коментар, който е валиден
                            //защото това: $another = "/* This is not a comment... */"; не е коментар
                            allVariables.Add(currentVariable.ToString());//добавяме във всички промениливи това, което сме натрупали досега  
                        }
                        currentVariable.Clear();//като стигнем следващата променлива, да не ни добавя предишната, зачистваме текущата
                        inVariable = false;//вече не сме в променлива
                    }
                }

                if (inSingleQuoteString)//стринг в единични кавички
                //ако сме тук: $another = "/* This is not a comment... */"; трябва да търсим затварящия му символ
                {
                    if (currentSymbol == '\'')
                    {
                        inSingleQuoteString = false;
                        continue;
                    }
                }

                //стринг в двойни кавички
                if (inDoubleQuoteString)
                {
                    if (currentSymbol == '"')
                    {
                        inDoubleQuoteString = false;
                        continue;
                    }
                    
                }

                if (!inSingleQuoteString && !inDoubleQuoteString)//стартиране на коментар
                {
                    if (currentSymbol == '#')
                    {
                        inOneLineComment = true;//в едноредов коментар с #
                        continue;
                    }

                    if (currentSymbol == '/'
                        && i + 1 < inputCode.Length
                        && inputCode[i + 1] == '/')//коментар с //
                    {
                        inOneLineComment = true;
                        i++;//защото е проверено, че имаме //, т.е. не трябва да проверяваме следващия символ
                        continue;
                    }
                    //многоредов коментар
                    if (currentSymbol == '/' 
                        && i + 1 < inputCode.Length
                        && inputCode[i + 1] == '*')
                    {
                        inMultiLineComment = true;
                        i++;
                        continue;
                    }
                }

                //ако се намираме в стринг трябва да проверяваме дали \ не ескейпва 
                //ако не сме в стринг, проверяваме да не сме в коментар
                else
                {
                    //в стринг сме и следващия символ ще бъде ескейпнат
                    if (currentSymbol == '\\')//т.е. една наклонена \
                    {
                        i++;
                        continue;
                    }
                }

                if (currentSymbol == '\'')//дали не започваме стринг с единична кавичка
                {
                    inSingleQuoteString = true;
                    continue;
                }

                if (currentSymbol == '\"')//дали не започваме стринг с двойни кавички
                {
                    inDoubleQuoteString = true;
                    continue;
                }

                if (currentSymbol == '$')//в променилива сме
                {
                    inVariable = true;
                    continue;
                }
            }
            return allVariables;
        }

        public static void PrintResult(HashSet<string> result)
        {
            Console.WriteLine(result.Count);
            foreach (var variable in result)
            {
                Console.WriteLine(variable);
            }
        } 

        static void Main(string[] args)
        {
            string inputCode = ReadInput();
            var result = ExtractWords(inputCode);
            PrintResult(result);
        }

       
    }
}
