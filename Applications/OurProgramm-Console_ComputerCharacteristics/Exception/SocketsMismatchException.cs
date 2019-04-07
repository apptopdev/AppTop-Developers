using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class SocketsMismatchException : Exception
    {
        public SocketsMismatchException(string message) : base(message) { }
    }
}
