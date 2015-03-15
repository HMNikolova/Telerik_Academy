namespace Classes.Models
{
    using System;

    public class ForumPost
    {
        public string Title { get; set; }
        //макс дължина на съдържание
        public static int MaxContentLength { get; set; }

        public ForumPost()
        {
            MaxContentLength = 200;
        }

        //public ForumPost()
        //{

        //}
    }
}
