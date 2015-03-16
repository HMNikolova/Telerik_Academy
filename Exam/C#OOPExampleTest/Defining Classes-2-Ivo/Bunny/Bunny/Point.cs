namespace Bunny
{
    public struct Point
    {
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
    }
}
