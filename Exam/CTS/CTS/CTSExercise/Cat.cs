namespace CTSExercise
{
    using System;
    //с IComparable котките да могат да се сравняват и ще ги сравняваме по години
    public class Cat : IAnimal, ICloneable, IComparable<Cat>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        //сравняване на два обекта
        public override bool Equals(object obj)
        {
            //кастваме към Cat
            var objAsCat = obj as Cat;
            if (objAsCat == null)
            {
                return false; 
            }
            //ако тези двете са различни
            if (this.Name != objAsCat.Name)
            {
                return false;
            }
            if (this.Age != objAsCat.Age)
            {
                return false; 
            }

            return true; 
        }
        //оператора == за да работи му трябвата две котки за да ги сравни
        public static bool operator ==(Cat firstCat, Cat secondCat)
        {
            return Cat.Equals(firstCat, secondCat);
        }

        public static bool operator !=(Cat firstCat, Cat secondCat)
        {
            return !Cat.Equals(firstCat, secondCat);
        }
        //връща нещо тотално уникално за всяка една инстанция
        public override int GetHashCode()
        {
            //по всички пропъртита да направим ксор
            return this.Name.GetHashCode() ^ this.Age;
        }
        //когато някой каже tostring на този обект ще се връща това, което вие сте казали, вместо да се връща дефоутната инплементация
        public override string ToString()
        {
            return this.Name + " Miau! ";
        }

        //така котката вече се клонира
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Cat otherCat)
        {
            ////ако върнем число < 0 значи подадения обект е с по-голяма стойност, трябва да дойде след нас
            //if (this.Age < otherCat.Age)
            //{
            //    return -1;
            //}
            ////сравняваме ги по години и тези години на текущата котка са по-големи
            //else if (this.Age > otherCat.Age)
            //{
            //    return 1;
            //}
            //return 0;
            
            ////горните редове може да се запишат и така
            //return this.Age.CompareTo(otherCat.Age);

            //ако искаме да ги сравняваме по име и по години
            //т.е. ако имента са им еднакви
            if (this.Name.CompareTo(otherCat.Name) == 0)
            {
                //сравнявай(сортирай) по години
                return this.Age.CompareTo(otherCat.Age);
            }
            //ако имената не са ми еднакви сравнявай по имена
            return this.Name.CompareTo(otherCat.Name);
        }
    }
}
