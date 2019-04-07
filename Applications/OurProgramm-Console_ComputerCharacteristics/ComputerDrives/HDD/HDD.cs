using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class HDD : IHDD
    {
        public HDDManufacturers manufacturerName { get; set; }
        public FormFactorsHDD FormFactorHDD { get; set; }
        public FrequencyOfSpindleRotations FrequencyOfSpindleRotations { get; set; }

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
                else throw new DriveCapacityException("Присвоено неверное значение для объема HDD.");
            }
        }

        public HDD(HDDManufacturers manufacturerName, FormFactorsHDD FormFactorHDD, FrequencyOfSpindleRotations FrequencyOfSpindleRotations, int DriveCapacity)
        {
            this.manufacturerName = manufacturerName;
            this.FormFactorHDD = FormFactorHDD;
            this.FrequencyOfSpindleRotations = FrequencyOfSpindleRotations;
            this.DriveCapacity = DriveCapacity;
        }
    }
}
