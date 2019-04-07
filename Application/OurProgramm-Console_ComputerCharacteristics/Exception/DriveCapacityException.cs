using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class DriveCapacityException : Exception
    {
        public DriveCapacityException(string message) : base(message) { }
    }
}
