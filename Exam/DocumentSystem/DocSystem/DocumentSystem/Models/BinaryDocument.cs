using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem.Models
{
    public class BinaryDocument : Document, IDocument
    {
        public BinaryDocument(string name, int size = 0)
            : base(name)
        {
            this.Size = size;
        }

        public int Size { get; private set; }
    }
}
//43:02