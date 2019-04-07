using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    interface ICPU
    {
        CPUManufacturers manufacturerName { get; set; }
        CPUSeries CPUSeries { get; set; }
        Sockets Socket { get; set; }
        float ProcessorСlockSpeed { get; set; }
        int NumberOfCores { get; set; }
    }

    enum CPUManufacturers
    {
        AMD,
        Intel
    }
    enum CPUSeries
    {
        AMDRyzen3,
        AMDRyzen5,
        AMDRyzen7,
        AMDRyzenThreadripper,
        IntelCorei3,
        IntelCorei5,
        IntelCorei7,
        IntelCorei9,
        IntelXeon
    }
}
