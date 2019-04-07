using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    interface ICase
    {
        CaseManufacturers ManufacturerName { get; set; }
        FormFactorsCase FormFactor { get; set; }
        PowerSupplyLocation PowerSupplyLocation { get; set; }
        FormFactorsPowerSupply FormFactorsPowerSupply { get; set; }
        FormFactorsMotherboard FormFactorMotherboard { get; set; }
        int NumberOfPlacesForFans { get; set; }
        int MaximumFanSizeForRearInstallation { get; set; }
        int MaximumFanSizeForInstallationInFront { get; set; }
        int NumberOfInternalCompartmentsThreeAndHalf { get; set; }
        int NumberOfInternalCompartmentsTwoAndHalf { get; set; }
    }

    enum CaseManufacturers
    {
        Aerocool,
        AZZA,
        Chieftec,
        Corsair,
        DeLuxe,
        FractalDesign,
        FrimeCom,
        FSP,
        Gigabyte,
        GreenVision,
        InWin,
        Logic,
        Maxxter,
        Norica,
        Phanteks,
        QUBE,
        RAIJINTEK,
        SATA,
        SilentiumPC,
        Spire,
        Thermaltake,
        Vinga,
        Zalman,
        Aksline,
        Asus,
        BeQuiet,
        Casecom,
        CoolerMaster,
        Cougar,
        Deepcool,
        Foxline,
        Frime,
        Frontier,
        Gamemax,
        GoldenField,
        GTL,
        LianLi,
        Logicpower,
        NODECOM,
        NZXT,
        PrologiX,
        Rampage,
        Sharkoon,
        SilverStone,
        Supermicro,
        Tracer,
        Xigmatek
    }
    enum FormFactorsCase
    {
        Desktop,
        MidiTower,
        UltraTower,
        MiniTower,
        FullTower,
        CubeCase
    }
    enum PowerSupplyLocation
    {
        Upper,
        Lower
    }
}
