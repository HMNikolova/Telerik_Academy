using System;
namespace SchoolSystem
{
    public class Student : Person, IComparable<Student>
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
