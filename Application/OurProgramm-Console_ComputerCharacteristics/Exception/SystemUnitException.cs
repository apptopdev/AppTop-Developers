using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class SystemUnitException : Exception
    {
        public SystemUnitException(string message) : base(message) { }
    }
}
