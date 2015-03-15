namespace Bunnies
{
    using System;
    using Animals;
    //в момента, в който си създадем клас да му кажем, че е public
    //искам Bunny да наследява Animal и да вземе всичко от него
    public class Bunny : Animal
    {
        public static int NumberOfLegs = 4;

        private const int InitialHealth = 200; //колко е здрав заека (const ги наричат магически числа, и се слага по време на компилация)
        private const int InitialCarrots = 0;//започваме от 0 моркови

        
        private string color;//поле
        //private ColorEnum color;//поле
        private ulong carrotsCount;
        //private int health;


        //конструктора казва какво да се случва с даден обект още при неговото създаване, 
        //конструктора трябва да има същото име като името на класа (Bunny)
        //второто нещо за конструктора има скоби като методите (Bunny())
        //трето нещо не връщат стойност, хубаво е да е public
        public Bunny(string bunnyName)//искаме заека винаги да е с име и в скобите го показваме
        {
            //всичко си създаваме в конструктора
            this.Name = bunnyName;//this сочи към текущата инстанция(обект т.е. това сочи към себе си)
            this.Health = InitialHealth;
            this.carrotsCount = InitialCarrots;
            this.IsRetire = false;//първоначално не е пенсиониран
        }
        //правиме си втори конструктор, първия приема само име
        //втория конструктор приема име и цвят
        //т.е. да мога да създавам зайци без да им знам цвета предварително
        public Bunny(string bunnyName, string playerColor) : this(bunnyName)//преизползване на конструктор
        {
            this.Color = playerColor;//color с голяма буква т.е. да минава през свойството
        }

        

        //Properties -свойствата са това, което е видимо за външния свят и ние
        //по някакъв начин изнасяме информация за този заек
       
        public string Color
        //public ColorEnum Color
        {
            get//дай ми го
            {
                return this.color;
            }
            set//смени ми го
            {//ако имаме само set се използва за пароли
                //валидация на цвят
                if (value != "Blue" && value != "Red")
                {
                    throw new ArgumentException("Color must be Blue or Red");
                }
                this.color = value;
            }
        }

        

        //метод смяна на цвят, след като някой от вън сменя цвета, значи е public
        //public void ChangeColor(string newColor)
        //{
        //    this.color = newColor;
        //}

        //метод добавяне на моркови
        public ulong AddCarrots(uint carrots)
        {
            this.carrotsCount += carrots;
            return this.carrotsCount;
        }

        public string SayName()
        {
            return this.Name;
        }

        public bool IsRetire { get; private set; }//само заека може да преценява дали е пенсиониран

        public void Retire()//пенсиониране на заека
        {
            if (this.Health < 0)
            {//на заека когато му падне кръвта го пенсионираме
                this.IsRetire = true;
            }
        }
        //колко му остава от кръвта
        public int Damage
        {
            get
            {
                
                if (this.Health < 0)
                {
                    return InitialHealth;
                }
                int damage = InitialHealth - this.Health;

                return damage;
            }
        }

        //дава ни всичко, което можем да заменим
        public override string ToString()
        {
            
            return this.Name + " " + this.Health;
        }
            
    }
}
