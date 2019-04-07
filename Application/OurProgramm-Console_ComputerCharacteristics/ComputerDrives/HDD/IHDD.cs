using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    interface IHDD : IComputerDrives
    {
        HDDManufacturers manufacturerName { get; set; }
        FormFactorsHDD FormFactorHDD { get; set; }
        FrequencyOfSpindleRotations FrequencyOfSpindleRotations { get; set; }
    }

    enum HDDManufacturers
    {
        AData,
        Cisco,
        Fujitsu,
        Hitachi,
        Intenso,
        Lenovo,
        Samsung,
        Silicon,
        Power,
        Toshiba,
        Verbatim,
        Apacer,
        Dell,
        GOODRAM,
        HP,
        IBM,
        MediaMax,
        Seagate,
        Sony,
        Transcend,
        WD
    }
    enum FormFactorsHDD
    {
        TwoAndFive,
        ThreeAndFive
    }
    enum FrequencyOfSpindleRotations
    {
        HDD5400,
        HDD7200
    }
}
