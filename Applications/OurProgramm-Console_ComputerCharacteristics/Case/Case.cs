using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToTheJunior
{
    class Case : ICase
    {
        public CaseManufacturers ManufacturerName { get; set; }
        public FormFactorsCase FormFactor { get; set; }
        public PowerSupplyLocation PowerSupplyLocation { get; set; }
        public FormFactorsPowerSupply FormFactorsPowerSupply { get; set; }
        public FormFactorsMotherboard FormFactorMotherboard { get; set; }

        private int numberOfPlacesForFans;
        public int NumberOfPlacesForFans
        {
            get
            {
                return numberOfPlacesForFans;
            }
            set
            {
                if (value >= 0) numberOfPlacesForFans = value;
                else throw new NumberOfPlacesForFansException("Присвоено неверное значение для количества мест вентиляторов.");
            }
        }

        private int maximumFanSizeForRearInstallation;
        public int MaximumFanSizeForRearInstallation
        {
            get
            {
                return maximumFanSizeForRearInstallation;
            }
            set
            {
                if (value >= 0) maximumFanSizeForRearInstallation = value;
                else throw new MaximumFanSizeForInstallationException("Присвоено неверное значение для количества мест установки вентиляторов сзади.");
            }
        }

        private int maximumFanSizeForInstallationInFront;
        public int MaximumFanSizeForInstallationInFront
        {
            get
            {
                return maximumFanSizeForInstallationInFront;
            }
            set
            {
                if (value >= 0) maximumFanSizeForInstallationInFront = value;
                else throw new MaximumFanSizeForInstallationException("Присвоено неверное значение для количества мест установки вентиляторов спереди.");
            }
        }

        private int numberOfInternalCompartmentsThreeAndHalf;
        public int NumberOfInternalCompartmentsThreeAndHalf
        {
            get
            {
                return numberOfInternalCompartmentsThreeAndHalf;
            }
            set
            {
                if (value > 0) numberOfInternalCompartmentsThreeAndHalf = value;
                else throw new NumberOfInternalCompartmentsException("Присвоено неверное значение для количества отсеков слотов 3.5.");
            }
        }

        private int numberOfInternalCompartmentsTwoAndHalf;
        public int NumberOfInternalCompartmentsTwoAndHalf
        {
            get
            {
                return numberOfInternalCompartmentsTwoAndHalf;
            }
            set
            {
                if (value > 0) numberOfInternalCompartmentsTwoAndHalf = value;
                else throw new NumberOfInternalCompartmentsException("Присвоено неверное значение для количества отсеков слотов 2.5.");
            }
        }

        public Case(CaseManufacturers ManufacturerName, FormFactorsCase FormFactor, PowerSupplyLocation PowerSupplyLocation, FormFactorsPowerSupply FormFactorsPowerSupply, FormFactorsMotherboard FormFactorMotherboard, int NumberOfPlacesForFans, int MaximumFanSizeForRearInstallation, int MaximumFanSizeForInstallationInFront, int NumberOfInternalCompartmentsThreeAndHalf, int NumberOfInternalCompartmentsTwoAndHalf)
        {
            this.ManufacturerName = ManufacturerName;
            this.FormFactor = FormFactor;
            this.PowerSupplyLocation = PowerSupplyLocation;
            this.FormFactorsPowerSupply = FormFactorsPowerSupply;
            this.FormFactorMotherboard = FormFactorMotherboard;

            this.NumberOfPlacesForFans = numberOfPlacesForFans;
            this.MaximumFanSizeForRearInstallation = maximumFanSizeForRearInstallation;
            this.NumberOfInternalCompartmentsThreeAndHalf = NumberOfInternalCompartmentsThreeAndHalf;
            this.NumberOfInternalCompartmentsTwoAndHalf = NumberOfInternalCompartmentsTwoAndHalf;
        }
    }
}
