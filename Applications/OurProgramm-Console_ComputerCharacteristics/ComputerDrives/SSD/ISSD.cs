using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    interface ISSD : IComputerDrives
    {
        SSDManufacturers manufacturerName { get; set; }
        FormFactorsSSD FormFactorSSD { get; set; }
        TypesOfMemorySSD TypeOfMemory { get; set; }
    }

    enum SSDManufacturers
    {
        AData,
        AMD,
        Corsair,
        Dell,
        Giabyte,
        Hitachi,
        Hynix,
        Kingmax,
        Micron,
        Palit,
        Samsung,
        Seagate,
        Toshiba,
        WD,
        AFOX,
        Apacer,
        Crucial,
        GOODRAM,
        Intel,
        HP,
        Kingston,
        Leven,
        OWC,
        Patriot,
        SanDisck,
        SiliconPower,
        TeamGroup,
        Transcend
    }
    enum FormFactorsSSD
    {
        OneAndEight,
        TwoAndFive,
        M2,
        mSATA
    }
    enum TypesOfMemorySSD
    {
        MLC,
        TLC,
        MLC3DNAND,
        TLC3DNAND
    }
}
