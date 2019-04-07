using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class CPU : ICPU
    {
        public CPUManufacturers manufacturerName { get; set ; }
        public CPUSeries CPUSeries { get; set ; }
        public Sockets Socket { get; set ; }

        private float processorСlockSpeed;
        public float ProcessorСlockSpeed
        {
            get
            {
                return processorСlockSpeed;
            }
            set
            {
                if (value > 0) processorСlockSpeed = value;
                else throw new ProcessorСlockSpeedException("Присвоено неверное значение для частоты процессора.");
            }
        }

        private int numberOfCores;
        public int NumberOfCores
        {
            get
            {
                return numberOfCores;
            }
            set
            {
                if (value > 0) numberOfCores = value;
                else throw new NumberOfCoresException("Присвоено неверное значение для количества ядер.");
            }
        }

        public CPU(CPUManufacturers manufacturerName, CPUSeries CPUSeries, Sockets Socket, float ProcessorСlockSpeed, int NumberOfCores)
        {
            this.manufacturerName = manufacturerName;
            this.CPUSeries = CPUSeries;
            this.Socket = Socket;
            this.ProcessorСlockSpeed = ProcessorСlockSpeed;
            this.NumberOfCores = NumberOfCores;
        }
    }
}
