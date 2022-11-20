using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asamblor
{
    internal class Attributes
    {
        public int instructionClass { get; set; }
        public ushort encoding { get; set; }

        public string bin { get; set; }

        public Attributes(int instructionClass, ushort encoding, string bin) 
        {
            this.instructionClass = instructionClass;
            this.encoding = encoding;
            this.bin = bin;
        }
    }
}
