using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    interface IRAM
    {
        RAMManufacturers RAMManufacturers { get; set; }
        TypesOfRAM TypeOfRAM { get; set; }
        int MaximumMemoryFrequency { get; set; }
        int AmountOfRAM { get; set; }
    }

    enum RAMManufacturers
    {
        ADATA,
        AMD,
        Cisco,
        Crucial,
        Exceleram,
        GSkill,
        GoldenMemory,
        GOODRAM,
        Hynix,
        Inno3D,
        Lenovo,
        NCP,
        Qumo,
        SiliconPower,
        Transend,
        AFOX,
        Apacer,
        Corsair,
        Dell,
        Fujitsu,
        Geil,
        HP,
        IBM,
        Kingston,
        Leven,
        Patriot,
        Samsung,
        TeamGroup,
        VColor
    }
}
