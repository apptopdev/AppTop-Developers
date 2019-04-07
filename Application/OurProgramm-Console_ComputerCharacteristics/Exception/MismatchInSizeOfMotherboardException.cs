using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class MismatchInSizeOfMotherboardException : Exception
    {
        public MismatchInSizeOfMotherboardException(string message) : base(message) { }
    }
}
