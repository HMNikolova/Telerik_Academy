using Classes.Models.Interfaces;

using System;
namespace Classes.Models
{
    public class MyStack<T> : IStack<T> 
    {
        public void Push(T element)
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public T Top()
        {
            throw new NotImplementedException();
        }

        public T Last
        {
            get { throw new NotImplementedException(); }
        }
    }
}
