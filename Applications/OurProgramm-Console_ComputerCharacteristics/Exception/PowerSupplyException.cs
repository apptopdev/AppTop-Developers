using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class PowerSupplyException : Exception
    {
        public PowerSupplyException (string message) : base(message) { }
    }
}
