using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{

    class MyProgram
    {
        static void Main(string[] args)
        {
            Motherboard motherboard = new Motherboard(MotherboardManufacturers.ASROCK, CPUPowerConnectors.EightConnect, FormFactorsMotherboard.ATX, TypesOfRAM.DDR4, Sockets.AM4, 4, 2200);
            CPU CPU = new CPU(CPUManufacturers.AMD, CPUSeries.AMDRyzenThreadripper, Sockets.AM4, 3.4f, 32);
            GPU GPU = new GPU(GPUManufacturers.Asus, ModelGPU.GTX1080Ti, TypesOfMemoryGPU.GDDR5X, MemoryWidth.b256, 4);
            RAM[] RAM = new RAM[] { new RAM(RAMManufacturers.Kingston, TypesOfRAM.DDR4, 2200, 8), new RAM(RAMManufacturers.Kingston, TypesOfRAM.DDR4, 2200, 8) };
            HDD HDD = new HDD(HDDManufacturers.WD, FormFactorsHDD.ThreeAndFive, FrequencyOfSpindleRotations.HDD7200, 1024);
            SSD SSD = new SSD(SSDManufacturers.Kingston, FormFactorsSSD.TwoAndFive, TypesOfMemorySSD.MLC3DNAND, 256);
            IComputerDrives[] computerDrives = { HDD, SSD};
            PowerSupply powerSupply = new PowerSupply(PowerSupplyManufacturers.BeQuite, FormFactorsPowerSupply.ATX, BoardingMotherboard.TwentyFourPlusEigthConnect, DiameterOfFans.OneHundredForty, 1000);
            Case @case = new Case(CaseManufacturers.CoolerMaster, FormFactorsCase.Desktop, PowerSupplyLocation.Lower, FormFactorsPowerSupply.ATX, FormFactorsMotherboard.ATX, 6, 120, 120, 2, 2);

            SystemUnit systemUnit = new SystemUnit(motherboard, CPU, GPU, RAM, computerDrives, powerSupply, @case);

            systemUnit.Start();
            systemUnit.GetInfoAboutSystem();

            Console.ReadLine();
        }
    }

   
}
