using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class PowerSupply : IPowerSupply
    {
        public PowerSupplyManufacturers manufacturerName { get; set; }
        public FormFactorsPowerSupply FormFactorPowerSupply { get; set; }
        public BoardingMotherboard BoardingMotherboard { get; set; }
        public DiameterOfFans DiameterOfFans { get; set ; }

        private int power;
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                if (value > 0) power = value;
                else throw new PowerSupplyException("Присвоено неверное значение для мощности БП.");

            }
        }

        public PowerSupply(PowerSupplyManufacturers manufacturerName, FormFactorsPowerSupply FormFactorPowerSupply, BoardingMotherboard BoardingMotherboard, DiameterOfFans DiameterOfFans, int Power)
        {
            this.manufacturerName = manufacturerName;
            this.FormFactorPowerSupply = FormFactorPowerSupply;
            this.BoardingMotherboard = BoardingMotherboard;
            this.DiameterOfFans = DiameterOfFans;
            this.Power = Power;
        }
    }
}
