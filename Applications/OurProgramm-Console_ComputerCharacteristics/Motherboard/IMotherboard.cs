using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{

    interface IMotherboard 
    {
        MotherboardManufacturers manufacturerName { get; set; }
        CPUPowerConnectors CPUPowerConnectors { get; set; }
        int NumberOfRAMSlots { get; set; }
        int MaximumMemoryFrequency { get; set; }

        FormFactorsMotherboard FormFactorMotherboard { get; set; }
        TypesOfRAM TypeOfRAM { get; set; }
        Sockets Socket { get; set; }
    }

    enum MotherboardManufacturers
    {
        AFOX,
        ASROCK,
        Biostar,
        Carbon,
        Esonic,
        Gigabyte,
        Intel,
        MSI,
        Supermicro,
        Alcatel,
        Asus,
        BTC,
        Colorful,
        EVGA,
        Grenade,
        MPM,
        Qoltec,
        Tomahawk
    }
    enum CPUPowerConnectors
    {
        TwoConnect,
        FourConnect,
        EightConnect,
        EigthPlusFourConnect,
        EightPlusEightConnect,
        EightPlusEightPlusSixConnect,
    }
}
