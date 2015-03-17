namespace Bunny
{
    public struct Point
    {
        //структурите приемата статични методи и т.н.
        public static decimal Calculate(Point first, Point second)
        {
            return 0.0m;
        }
        
        //структурата си има дефолтен конструктор, т.е. може да не създаваме констуктор
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public Point(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        //добавяме стойности към координатите на точката secondPoint
        public Add(int addX, intaddY, int addZ)
        {
            this.X += addX;
            this.Y += addY;
            this.Z += addZ;
        }
        
    }
}
