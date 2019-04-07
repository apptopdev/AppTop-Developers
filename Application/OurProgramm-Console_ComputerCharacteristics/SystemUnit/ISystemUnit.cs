using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    interface ISystemUnit
    {
        IMotherboard Motherboard { get; set; }
        ICPU CPU { get; set; }
        IGPU GPU { get; set; }
        IRAM[] RAM { get; set; }
        IComputerDrives[] ComputerDrives { get; set; }
        IPowerSupply PowerSupply  { get; set; }
        ICase Case { get; set; }
        void Start();
    }

}
