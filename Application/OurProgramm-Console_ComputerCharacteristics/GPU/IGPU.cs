using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    interface IGPU
    {
        GPUManufacturers manufacturerName { get; set; }
        ModelGPU ModelGPU { get; set; }
        TypesOfMemoryGPU TypeOfMemoryGPU { get; set; }
        MemoryWidth MemoryWidth { get; set; }
        int DriveCapacity { get; set; }
    }

    enum GPUManufacturers
    {
        AFOX,
        Asus,
        EVGA,
        Gigabyte,
        HP,
        Manli,
        MSI,
        PNY,
        Sapphire,
        ZOTAC,
        ASRock,
        Dell,
        Gainward,
        HIS,
        Inno3D,
        Matrox,
        Palit,
        PowerColor,
        XFX
    }
    enum ModelGPU
    {
        RadeonRXVega56,
        RadeonRXVega64,
        GTX1050,
        GTX1050Ti,
        GTX1060,
        GTX1070,
        GTX1070Ti,
        GTX1080,
        GTX1080Ti
    }
    enum TypesOfMemoryGPU
    {
        DDR3,
        GDDR3,
        GDDR5,
        GDDR5X,
        GDDR6,
    }
    enum MemoryWidth
    {
        b128,
        b192,
        b256,
        b352,
        b384,
        b2048
    }
}
