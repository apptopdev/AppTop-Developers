using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    enum FormFactorsMotherboard
    {
        miniITX,
        ATX,
        XLATX,
        mATX,
        EATX
    }
    enum TypesOfRAM
    {
        DDR3,
        DDR3L,
        DDR4
    }
    enum Sockets
    {
        AMDAM3,
        AMDAM3Plus,
        AMDTR4,
        AM4,
        Intel1155,
        Intel2011v3,
        Intel1151,
        Intel3647,
        Intel1150,
        Intel1156,
        Intel2066,
        Intel1151v2
    }

    class SystemUnit : ISystemUnit
    {
        public IMotherboard Motherboard { get; set; }
        public ICPU CPU { get; set; }
        public IGPU GPU { get; set; }
        public IRAM[] RAM { get; set; }
        public IComputerDrives[] ComputerDrives { get; set ; }
        public IPowerSupply PowerSupply { get; set; }
        public ICase Case { get; set; }

        public SystemUnit(IMotherboard Motherboard, ICPU CPU, IGPU GPU, IRAM[] RAM, IComputerDrives[] ComputerDrives, IPowerSupply PowerSupply, ICase Case)
        {
            this.Motherboard = Motherboard;
            this.CPU = CPU;
            this.GPU = GPU;
            this.RAM = RAM;
            this.ComputerDrives = ComputerDrives;
            this.PowerSupply = PowerSupply;
            this.Case = Case;
        }

        public void Start()
        {
            if (Motherboard.Socket != CPU.Socket) throw new SocketsMismatchException($"Несоответствие сокетов: {Motherboard.Socket} и {CPU.Socket}");

            for (int i = 0; i < RAM.Length; i++)
            {
                if (Motherboard.TypeOfRAM != RAM[i].TypeOfRAM) throw new DiscrepancyOfTypesOfRAMException($"Несоответствие типов ОЗУ: {Motherboard.TypeOfRAM} и {RAM[i].TypeOfRAM}");
            }

            if (Motherboard.FormFactorMotherboard != Case.FormFactorMotherboard) throw new MismatchInSizeOfMotherboardException($"Несоответствие размера материнской платі:\nФорм фактор материнской платы: {Motherboard.FormFactorMotherboard}\nФорм фактор корпуса: {Case.FormFactorMotherboard}");
        }

        public void GetInfoAboutSystem()
        {
            Console.WriteLine($"Материнская плата: {Motherboard.manufacturerName} {Motherboard.FormFactorMotherboard} {Motherboard.Socket}");
            Console.WriteLine($"Процессор: {CPU.manufacturerName} {CPU.CPUSeries} {CPU.NumberOfCores} {CPU.ProcessorСlockSpeed}");
            Console.WriteLine($"Видеокарта: {GPU.manufacturerName} {GPU.ModelGPU} {GPU.DriveCapacity} {GPU.TypeOfMemoryGPU}");
            Console.WriteLine($"Оперативная память: {RAM.Length}x{ RAM[0].AmountOfRAM} {RAM[0].RAMManufacturers} {RAM[0].MaximumMemoryFrequency}");
            for (int i = 0; i < ComputerDrives.Length; i++)
            {
                if(ComputerDrives[i] is IHDD)
                {
                    var temp = ComputerDrives[i] as IHDD;
                    Console.WriteLine($"Накопитель: {temp.manufacturerName} {temp.DriveCapacity} {temp.FrequencyOfSpindleRotations} {temp.FormFactorHDD}");
                }
                if (ComputerDrives[i] is ISSD)
                {
                    var temp = ComputerDrives[i] as ISSD;
                    Console.WriteLine($"Накопитель: {temp.manufacturerName} {temp.DriveCapacity} {temp.FormFactorSSD} {temp.TypeOfMemory}");
                }

            }
            Console.WriteLine($"Блок питания: {PowerSupply.manufacturerName} {PowerSupply.Power} {PowerSupply.FormFactorPowerSupply} ");
        }
    }
}
