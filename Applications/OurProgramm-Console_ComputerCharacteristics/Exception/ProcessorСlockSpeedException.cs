using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class ProcessorСlockSpeedException : Exception
    {
        public ProcessorСlockSpeedException (string message) : base(message) { }
    }
}
