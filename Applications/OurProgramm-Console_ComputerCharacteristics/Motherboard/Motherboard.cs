using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class Motherboard : IMotherboard
    {
        public MotherboardManufacturers manufacturerName { get; set; }
        public CPUPowerConnectors CPUPowerConnectors { get; set; }
        public FormFactorsMotherboard FormFactorMotherboard { get; set; }
        public TypesOfRAM TypeOfRAM { get; set; }
        public Sockets Socket { get; set; }

        private int numberOfRAMSlots;
        public int NumberOfRAMSlots
        {
            get
            {
                return numberOfRAMSlots;
            }
            set
            {
                if (value > 0) numberOfRAMSlots = value;
                else throw new NumberOfRAMSlotsException("Присвоено неверное значение для количества плашек оперативной памяти.");

            }
        }

        private int maximumMemoryFrequency;
        public int MaximumMemoryFrequency
        {
            get
            {
                return maximumMemoryFrequency;
            }
            set
            {
                if (value > 0) maximumMemoryFrequency = value;
                else throw new MaximumMemoryFrequencyException("Присвоено неверное значение для частоты оперативной памяти.");
            }
        }

        public Motherboard(MotherboardManufacturers manufacturerName, CPUPowerConnectors CPUPowerConnectors, FormFactorsMotherboard FormFactorMotherboard, TypesOfRAM TypeOfRAM, Sockets Socket, int NumberOfRAMSlots, int MaximumMemoryFrequency)
        {
            this.manufacturerName = manufacturerName;
            this.CPUPowerConnectors = CPUPowerConnectors;
            this.FormFactorMotherboard = FormFactorMotherboard;
            this.TypeOfRAM = TypeOfRAM;
            this.Socket = Socket;
            this.NumberOfRAMSlots = NumberOfRAMSlots;
            this.MaximumMemoryFrequency = MaximumMemoryFrequency;
        }
    }
}
