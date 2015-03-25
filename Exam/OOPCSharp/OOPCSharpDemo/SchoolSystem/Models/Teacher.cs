using SchoolSystem.Interfaces;
namespace SchoolSystem
{
    using System;
    public class Teacher : Person, IPerson
    {
        public Teacher(string name, string email, string subject)
            : base(name, email)
        {
            this.Subject = subject;
        }

        public string Subject { get; set; }  
    }
}
