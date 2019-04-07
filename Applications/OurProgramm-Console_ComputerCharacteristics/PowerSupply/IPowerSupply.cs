using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    interface IPowerSupply
    {
        PowerSupplyManufacturers manufacturerName { get; set; }
        FormFactorsPowerSupply FormFactorPowerSupply { get; set; }
        BoardingMotherboard BoardingMotherboard { get; set; }
        DiameterOfFans DiameterOfFans { get; set; }
        int Power { get; set; }
    }

    enum PowerSupplyManufacturers
    {
        Aerocool,
        Asus,
        Casecom,
        CoolerMaster,
        Cougar,
        Deepcool,
        FSP,
        GoldenField,
        SilverStone,
        Zalman,
        Thermaltake,
        BeQuite,
        Chieftec,
        Corsair,
        DeLuxe,
        FractalDesign,
        Gamemax,
        GreenVision,
        Gigabyte,
        Sven,
        Xilence
    }
    enum FormFactorsPowerSupply
    {
        ATX,
        FlexATX,
        SFX,
        TFX
    }
    enum BoardingMotherboard
    {
        TwentyFourConnect,
        TwentyFourPlusFourConnect,
        TwentyFourPlusEigthConnect,
        TwentyFourPlusEigthPlusEightConnect,
    }
    enum DiameterOfFans
    {
        Eighty,
        OneHundredTwenty,
        OneHundredThirtyFive,
        OneHundredForty
    }
}
