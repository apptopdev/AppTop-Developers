using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class NumberOfCoresException : Exception
    {
        public NumberOfCoresException(string message) : base(message) { }
    }
}
