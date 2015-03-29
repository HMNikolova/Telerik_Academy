using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Виртуален метод е метод, който се намира в някакъв базов клас, 
//и който има ключовата дума в декларацията си virtual. Тази ключова 
//дума virtual позволява на този метод от базовия клас не наследниците му 
//да задраскат кода, който е написан в метода и да го подменят(override) 
//с нов код и тогава вече метода с дума virtual ако променливата стойността 
//и е инстанция на наследника тогава метода с дума virtual ще се извиква от 
//наследника. Важно е методите, които са маркирани с virtual, са методи, 
//които можем да override-нем и да им сменим поведението. Методите ако не са 
//виртуални и не са абстрактни не може да им бъде подменяно поведението override.
namespace OopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //когато променливата е от тип базов клас аз мога да присвоя на нея като стойност всеки един от наследниците на базовия клас
            Control control = new Menu();
            control.Draw();
        }
    }
    //ако искам никой да не може да наследява класа ми го правя: public sealed class Control
    //абстрактните класове не могат да имат инстанция, а когато даден клас е абстрактен мога да правя абстрактни методи вътре в него, методи без поведение
    public abstract class Control
    {
        //казвайки че е виртуален вече всеки мой наследник може да подмени това поведение
        public virtual void Draw()
        {
            Console.WriteLine("Control.Draw");
        }
    }

    public class Button : Control
    {
        //public new void Draw()//с new и ако нямаме virtual и override избягваме грешки, но това вече не е полиморфизъм и ще се извиква базовия клас
        public override void Draw()
        {
            Console.WriteLine("Button.Draw");
            //base.Draw();
        }
         
        public void Click()
        {
            Console.WriteLine("Button.Click");
        }
    }

    public class Menu : Control
    {
        public override void Draw()
        {
            Console.WriteLine("Menu.Draw");
        }
    }
}
