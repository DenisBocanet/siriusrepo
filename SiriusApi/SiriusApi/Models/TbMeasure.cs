using System;
using System.Collections.Generic;

#nullable disable

namespace SiriusApi.Models
{
    public partial class TbMeasure
    {
        public int IdMeasure { get; set; }
        public DateTime DtDate { get; set; }
        public double? NmActivePower { get; set; }
        public double? NmAmbientTemp { get; set; }
        public double? NmControllerHubTemp { get; set; }
        public double? NmControllerTopTemp { get; set; }
        public double? NmFrequency { get; set; }
        public double? NmGeneratorSpeed { get; set; }
        public double? NmRotorSpeed { get; set; }
        public double? NmWindSpeed { get; set; }
        public double? NmPressure { get; set; }
        public double? NmNacelleDir { get; set; }
        public double? NmNacelleTemp { get; set; }
        public double? NmProduciblePower { get; set; }
        public double? NmProduciblePowerVestas { get; set; }
        public int? IdDevice { get; set; }
        public int? IdPlant { get; set; }

        public virtual TbPlant IdPlantNavigation { get; set; }
    }
}
