using System;

class Dog
{
    public event EventHandler NameChange;
    private string name;
    private string breed;

    //public string this[string index]
    //{
    //    get
    //    {
    //        if (index == "name")//ако някой ми подаде index, чиято стойност е name
    //        {
    //            return this.name;//аз ще му връщам this.name
    //        }
    //        else if (index == "breed")
    //        {
    //            return this.breed;
    //        }
    //        else
    //        {
    //            throw new ArgumentException("index");
    //        }
    //    }
    //}
    public Dog()
    {
    }

    public Dog(string name, string breed)
    {
        this.name = name;
        this.breed = breed;
    }

    public string Name// properties
    {
        get { return this.name; }
        set
        { 
            this.name = value;
            NameChange(null, null);
        }
    }

    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }

    public void SayBau()
    {
        Console.WriteLine("{0} said: Bauuuuuu!",
            this.name ?? "[unnamed dog]");
    }

    public void Walk()
    {
        Console.WriteLine("Walk from {0}", this.name);
    }
}