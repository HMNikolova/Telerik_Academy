namespace MegaCollections
{
    using System;
    //ако имаме два автора в Deque, за да не ни изписва грешка, се изписва долното
    [AttributeUsange(AttributeTargets.All, AllowMultiple = true)]
    
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name)
        {
            
        }
    }
}
