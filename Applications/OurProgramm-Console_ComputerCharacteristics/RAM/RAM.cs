using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class RAM : IRAM
    {
        public RAMManufacturers RAMManufacturers { get; set; }
        public TypesOfRAM TypeOfRAM { get; set; }

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

        private int amountOfRAM;
        public int AmountOfRAM
        {
            get
            {
                return amountOfRAM;
            }
            set
            {
                if (value > 0) amountOfRAM = value;
                else throw new AmountOfRAMException("Присвоено неверное значение для объема оперативной памяти.");

            }
        }

        public RAM(RAMManufacturers RAMManufacturers, TypesOfRAM TypeOfRAM, int MaximumMemoryFrequency, int AmountOfRAM)
        {
            this.RAMManufacturers = RAMManufacturers;
            this.TypeOfRAM = TypeOfRAM;
            this.MaximumMemoryFrequency = MaximumMemoryFrequency;
            this.AmountOfRAM = AmountOfRAM;
        }
    }
}
