namespace TestGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //няма проблем, защото Bunny е Animal
            //не може да достъпваме някои методи на Bunny, защото съм го запазила като Animal
            //ако е запазено като Bunny излиза метода
            //Bunny someBunny = new Bunny("Pesho");
            Animal someBunny = new Bunny("Pesho");
            //Т задължително трябва да ми бъде клас, ако му подам нещо, което е от референтен тип([]), работи
            //GenericClass<int[], string>generic = new GenericClass<int[], string>();
            //ако искаме да наследява Animal
            GenericClass<Bunny, string>generic = new GenericClass<Bunny, string>();
            //щом съм ограничил моя GenericClass и съм му казала искам Т да ми е Animal, няма проблем да го наяиша и така
            //GenericClass<Animal, string>generic = new GenericClass<Animal, string>();
            
            //ако имаме ограничението да ни е структура, обекта трябва да ни изглежда така
            //GenericClass<int, string>generic = new GenericClass<int, string>();
            
            //ако имам може второто ограничението да ни е структура
            //GenericClass<Bunny, int>generic = new GenericClass<Bunny, int>();
        }
    }
}
