using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//абстрактните методи са виртуални методи (т.е. методи, на които мога да им подменя поведението), 
//но са методи, които си нямат имплементация (нямат тяло)
//Може да направим метод, който да няма поведение и да накарам насила
//всички мои наследници на моя клас да override-нат този метод искат или не искат
//ако искат да наследяват моя клас с ключовата дума abstract аз ги задължавам да
//override-нат да сложат някакво поведение на всеки един от тези методи
namespace OopExamples
{
    class Program
    {
        static void Main()
        {
           Control control = new Menu();
            control.Draw();
            control.Hide();
        }
    }
    //когато имаме австрактен метод и класа ни трябва да е абстрактен
    //и не мога да си позволя волността наследника да не го override-на
    public abstract class Control : object
    {
        //метода Hide всеки един от моите наследници ще го има, но не може да му промени 
        //поведението, понеже не е вируален, наследява го, но в този абстрактен 
        //клас аз имам комбинация от абстрактен метод, които ме задължава да го
        //имплементирам и метод, който наследявам и използвам наготово и тогава
        //съответно ще имам метода Draw и всеки мой наследник ще има съответно 
        //метода control.Hide();

        public void Hide()
        {
            Console.WriteLine("Control.Hide");
        }

        //виртуалния метод е нещо, на което позволявам да се Override-не, 
        //а абстрактния е нещо, което задължавам наследника му да го override-не
//37:04
        public abstract void Draw();
    }

    public class Button : Control
    {
        public override void Draw()
        {
            Console.WriteLine("Button.Draw");
           
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

