﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class AmountOfRAMException : Exception
    {
        public AmountOfRAMException(string message) : base(message) { }
    }
}