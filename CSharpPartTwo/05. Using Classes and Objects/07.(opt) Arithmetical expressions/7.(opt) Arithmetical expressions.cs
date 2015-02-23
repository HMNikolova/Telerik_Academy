using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArithmeticalExpressions
{
        /*•	Write a program that calculates the value of given arithmetical expression.
          •	The expression can contain the following elements only:
            o	Real numbers, e.g. 5, 18.33, 3.14159, 12.6
            o	Arithmetic operators: +, -, *, / (standard priorities)
            o	Mathematical functions: ln(x), sqrt(x), pow(x,y)
            o	Brackets (for changing the default priorities): (, )*/
        static Dictionary<string, int> precedence = new Dictionary<string, int>() {
    { "pow", 4 }, { "sqrt", 4 }, { "ln", 4 }, { "*", 3 }, { "/", 3 }, { "+", 2 }, { "-", 2 }, { "(", 0 }, { ")", 999 }};
    static List<Tuple<string, string>> Tokenize(string s)
    {
        var token = new List<Tuple<string, string>>(); 

        for (int i = 0; i < s.Length; i++)
        {
            string value = String.Empty, type = String.Empty;

            if (s[i] == ' ') continue;

            else if (Char.IsDigit(s[i]) || (s[i] == '-' && Char.IsDigit(s[i + 1])))
            {
                type = "number";

                for (; i < s.Length && (Char.IsDigit(s[i]) || s[i] == '.' || s[i] == '-'); i++) value += s[i];
                i--;
            }
            else if (Char.IsLetter(s[i]))
            {
                type = "function";

                for (; i < s.Length && Char.IsLetter(s[i]); i++) value += s[i];
                i--;
            }
            else if (s[i] == ',')
            {
                type = "separator";

                value += s[i];
            }
            else value += s[i];

            token.Add(new Tuple<string, string>(value, type));
        }

        return token;
    }
    static List<string> Parse(List<Tuple<string, string>> infix)
    {
        var postfix = new List<string>();
        var operators = new Stack<string>();

        foreach (var token in infix)
        {
            string value = token.Item1, type = token.Item2;

            if (type == "number") postfix.Add(value);

            else if (type == "function") operators.Push(value);

            else if (type == "separator") while (operators.Peek() != "(") postfix.Add(operators.Pop());

            else if (value == "(") operators.Push(value);

            else if (value == ")") while ((value = operators.Pop()) != "(") postfix.Add(value); // Match left paren

            else
            {
                while (operators.Count != 0 && precedence[value] <= precedence[operators.Peek()])
                    postfix.Add(operators.Pop());

                operators.Push(value);
            }
        }

        while (operators.Count != 0) postfix.Add(operators.Pop());

        return postfix;
    }
    static double Evaluate(List<string> postfix)
    {
        var stack = new Stack<double>();

        foreach (var token in postfix)
            if (token == "+") stack.Push(stack.Pop() + stack.Pop());
            else if (token == "-") stack.Push(-stack.Pop() + stack.Pop());
            else if (token == "*") stack.Push(stack.Pop() * stack.Pop());
            else if (token == "/") stack.Push(1 / stack.Pop() * stack.Pop());
            else if (token == "ln") stack.Push(Math.Log(stack.Pop(), Math.E));
            else if (token == "sqrt") stack.Push(Math.Sqrt(stack.Pop()));
            else if (token == "pow") stack.Push(Math.Pow(y: stack.Pop(), x: stack.Pop())); // x ^ y
            else stack.Push(double.Parse(token));

        return stack.Pop();
    }

    static void Main()
    {
        Console.WriteLine(Evaluate(Parse(Tokenize("(3 + 5.3) * 2.7 - ln(22) / pow(2.2, -1.7)"))));
        Console.WriteLine(Evaluate(Parse(Tokenize("pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)"))));
        Console.WriteLine(Evaluate(Parse(Tokenize("(1 - -1) * pow(pow(1 + 1, pow(ln(2.71), 1 - 1)), 10)"))));
    }
    }


