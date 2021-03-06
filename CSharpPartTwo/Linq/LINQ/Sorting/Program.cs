﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            students.Add(new Student { FirstName = "A", LastName = "B", Age = 2 });
            students.Add(new Student { FirstName = "B", LastName = "T", Age = 5 });
            students.Add(new Student { FirstName = "C", LastName = "C", Age = 1 });
            students.Add(new Student { FirstName = "D", LastName = "B", Age = 11 });
            //дай ми всички студенти, чиито FirstName е различен от "А", след това започни да ги подреждаш и накрая ми ги преброй, но ако ги преброяваме накрая няма да работи foreach
            //var result = students.Where(st => st.FirstName != "A").OrderByDescending(st => st.LastName).ThenByDescending(st => st.FirstName).ThenByDescending(st => st.Age).Count();
            //foreach (var student in result)
            //{
                //Console.WriteLine(student.LastName);
            //}
            
            //ще ни го подреди отзад напред
            //var result = students.OrderByDescending(st => st.LastName).ThenByDescending(st => st.FirstName).ThenByDescending(st => st.Age);
            //foreach (var student in result)
            //{
                //Console.WriteLine(student.LastName);
            //}
            
            //сортиране по lastname, ако съвпадат след това ми ги подреди 
            //по firstname и ако пак съвпадат ми ги подреди по години
            //var result = students.OrderBy(st => st.LastName).ThenBy(st => st.FirstName).ThenBy(st => st.Age);
            //foreach (var student in result)
            //{
                //Console.WriteLine(student.LastName);
            //}
            //var pets = new List<string>();
            
            //pets.Add("Lasi");
            //pets.Add("Pesho");
            //pets.Add("Sharo");
            //pets.Add("Gosho");
            //pets.Add("Balkan");
            //pets.Add("Om");
            ////подреди ми ги по дължина, и тогава по самото име
            //var result = pets.OrderBy(p => p.Length).ThenBy(p => p);
            //foreach (var pet in result)
            //{
            //    Console.WriteLine(pet);
            //}

        }
    }
}

class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }
}
