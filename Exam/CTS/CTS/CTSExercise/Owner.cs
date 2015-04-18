using System;
using System.Collections;
using System.Collections.Generic;
namespace CTSExercise
{
    //искаме да го клонираме
    //лоше е че ICloneable връща object и трябва да се каства
    public class Owner : ICloneable, IEnumerable<Cat>
    {
        //List е референтен тип, т.е. ние като клонираме новия owner, shallow - ще клонираме
        //нов обект бит по бит
        //shallow клонирането не ни копира всичко на ново място, а ни копира всичките неща, 
        //но референтните типове остават същите, той ни копира адреса в паметта, т.е. този
        //лист от котки ще си остане същия

        //deep cloning трябва да си го инплементираме ние и да кажем изрично 
        //как се клонира всеки един обект
        //при deep cloning аз ако създам нов owner ще се клонират както котките и листа,
        //ще бъдат създаден на ново място, т.е. ще имам два отделни листа, ще имам 
        //и нов owner, въобще всичко ще бъде клонирано на нови места в паметта 

        private List<Cat> cats;

        public Owner(List<Cat> cats)
        {
            this.cats = cats;
        }

        public string Name { get; set; }

        public void Add(Cat cat)
        {
            this.cats.Add(cat);
        }


        public override string ToString()
        {
            return this.cats.Count.ToString();
        }

        //ICloneable ме задължава да имам метод Clone
        public object Clone()
        {
            //щом като имаме вече ICloneable, може да извикаме MemberwiseClone
            //който ще ни позволи да клонираме както биха го инплеметирали в .net
            //MemberwiseClone връща shallow копи
            //return this.MemberwiseClone();

            var copiedList = new List<Cat>();
            foreach (var cat in this.cats)
            {
                //var newCat = new Cat();
                //newCat.Name = cat.Name;
                //newCat.Age = cat.Age;
                //copiedList.Add(newCat);
                //ако в Cat.cs сме клонирали котката, може да не използваме горните 4 реда
                copiedList.Add((Cat)cat.Clone());
            }
            //MemberwiseClone ще ни копира имената така или иначе
            var clone = this.MemberwiseClone();
            //var clone = new Owner(copiedList);
            //clone.Name = this.Name;
            return clone;
        }

        public IEnumerator<Cat> GetEnumerator()
        {
            //по някакъв начин тук трябва да върнем enumerator от котка
            //затова си правим още един клас OwnerEnumerator
            //return new OwnerEnumerator(this.cats);

            //yield ни спестява писането на целия enumerator, връща една по една всички стойности
            for (int i = 0; i < this.cats.Count; i+=2)
            {
                yield return this.cats[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
