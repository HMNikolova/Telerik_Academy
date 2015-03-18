namespace TestGenerics
{
    //имаме клас, който ще приема два типа
    //може да използваме колкото искаме параметри <T, K, M, D>
    //искам да огранича Т да ми бъде задължително класове или К да ми бъде примитивен тип данни
    //правим ограничения на типовете данни с where и пишем какво искам да ни бъде Т и казваме, че искаме да ни бъде клас
    //public class GenericClass<T, K> where T : class
    //ако искам да ползвам int, bool..., трябва ограничението да ми бъде struct, защото всички примитивни типове са структури 
    //public class GenericClass<T, K> where T : struct
    public class GenericClass<T, K> 
    where T : Animal
    //Може да кажа, че К пък искам да ми е структура
    //where K : struct
    //може също освен, че искам Т да е животно, да има и празен конструктор
    //public class GenericClass<T, K> where T : Animal, new()
    //и тогава може да кажа това на долните редове, защото си гарантирам, че имам празен конструктор
    //public GenericClass()
       //{
           //someData = new T()
       //}
    
    {
       private T someData;
       private K someOtherData;
       
        public GenericClass()
       {
           
       }
       
       public GenericClass(T data, K otherData)
       {
           this.someData = data;
           this.someOtherData = otherData;
       }
    }
}
