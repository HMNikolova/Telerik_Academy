using System;
using SchoolSystem.Interfaces;
namespace SchoolSystem
{

    public class Person : IPerson
    {
        private string name;

        public Person(string name, string email)
        {
            this.Name = name;
            this.EMail = email;
        }

        public string EMail { get; private set; }  

        public string Name 
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name should have some value!!!");
                }
                this.name = value;
            }    
            }  

        public void Walk()
        {
            Console.WriteLine("{0} is walking", this.Name);
        }


        public Gender Gender
        {
            get { throw new NotImplementedException(); }
        }
    }
}
