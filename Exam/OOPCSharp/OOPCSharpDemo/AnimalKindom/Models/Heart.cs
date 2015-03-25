using System;
namespace AnimalKindom.Models
{
    public class Heart
    {
        //кубатура
        public double Volume { get; private set; }
        //помпа
        public double FlowRate { get; private set; }
        //колко са камерите
        public int ChamberCount { get; private set; }
    }
}
