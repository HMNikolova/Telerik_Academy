namespace Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Coordinates
    {
        public int X { get; set; }

        public int Y { get; set; }


        //координатите когато са празни са на 0-та
        public Coordinates() : this(0,0)
        { 
        
        }

        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
