using System;
﻿using SchoolSystem.Interfaces;
namespace SchoolSystem
{
    public class Student : Person, IComparable<Student>, IPerson
    {
         public Student(string name, string email, int studentId) : base(name, email)
        {
            this.StudentId = StudentId;
        }

        public int StudentId { get; private set; }

        //сравняваме ги по ID
        public int CompareTo(Student other)
        {
            return this.StudentId - other.StudentId;
        }
    }
}
