using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class GPU : IGPU
    {
        public GPUManufacturers manufacturerName { get; set; }
        public ModelGPU ModelGPU { get; set; }
        public TypesOfMemoryGPU TypeOfMemoryGPU { get; set; }
        public MemoryWidth MemoryWidth { get; set; }

        private int driveCapacity;
        public int DriveCapacity
        {
            get
            {
                return driveCapacity;
            }
            set
            {
                if (value > 0) driveCapacity = value;
                else throw new DriveCapacityException("Присвоено неверное значение для объема памяти GPU.");
            }
        }

        public GPU(GPUManufacturers manufacturerName, ModelGPU ModelGPU, TypesOfMemoryGPU TypeOfMemoryGPU, MemoryWidth MemoryWidth, int DriveCapacity)
        {
            this.manufacturerName = manufacturerName;
            this.ModelGPU = ModelGPU;
            this.TypeOfMemoryGPU = TypeOfMemoryGPU;
            this.MemoryWidth = MemoryWidth;
            this.DriveCapacity = DriveCapacity;
        }
    }
}
