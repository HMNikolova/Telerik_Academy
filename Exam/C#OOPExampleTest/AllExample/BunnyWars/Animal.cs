namespace Animals
{
    //1:22:45
    using System;
    public abstract class Animal//не може да се инициализира, може да инициализира само наследниците си
    {
        //internal - всичко, което е в namespace Animals може да се вижда, останалите не могат да виждат, валидно е само за текущия namespace 
        //private readonly string name;//readonly изпълнява се runtume; като дадем първа стойност повече не се променя
        private string name;

        public string Name
        {
            get
            { //публично свойство, което ни дава информация отвътре(която информация е private)
                return this.name;
            }
            //protected - достъп имат всички наследници + себе си
            protected set
            {
                if (string.IsNullOrEmpty(value))//ако ми подават празно име
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                //имена под 6 символа да не ги признаваме
                if (value.Length < 6)
                {
                    throw new ArgumentOutOfRangeException("Name must be longer than 6 symbols");
                }

                this.name = value;
            }
        }

        //автоматично свойство (прави поле, което ние не виждаме), ако нямаме валидация е излишно
        public int Health { get; set; }

    }
}
