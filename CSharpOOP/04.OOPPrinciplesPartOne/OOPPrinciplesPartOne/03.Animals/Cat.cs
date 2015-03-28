namespace _03.Animals
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, bool isMale) : base(name, age, isMale)
        {
            
        }

        public string BeJovial()
        {
            return string.Format("{0} is being jovial.", this.Name);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miau Miau"); 
        }

    }
}
