namespace TestGenerics
{
    //Bunny наследява Animal
    class Bunny : Animal
    {
        public Bunny ()
        {
            
        }
        
        //и мога да използвам всичко, което има Animal
        public Bunny (string name)
        {
            //на this. вече имаме Name, защото го взима от Animal
            //по този начин не се преповтаря код
            this.Name = name;
        }
        
        public void Add()
        {
            
        }
    }
}
