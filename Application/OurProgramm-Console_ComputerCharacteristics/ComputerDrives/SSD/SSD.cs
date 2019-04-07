using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class SSD : ISSD
    {
        public SSDManufacturers manufacturerName { get; set; }
        public FormFactorsSSD FormFactorSSD { get; set; }
        public TypesOfMemorySSD TypeOfMemory { get; set; }

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
                else throw new DriveCapacityException("Присвоено неверное значение для объема SSD.");
            }
        }

        public SSD(SSDManufacturers manufacturerName, FormFactorsSSD FormFactorSSD, TypesOfMemorySSD TypeOfMemory, int DriveCapacity)
        {
            this.manufacturerName = manufacturerName;
            this.FormFactorSSD = FormFactorSSD;
            this.TypeOfMemory = TypeOfMemory;
            this.DriveCapacity = DriveCapacity;
        }
    }
}
