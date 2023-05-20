using System;
using System.Collections.Generic;

#nullable disable

namespace SiriusApi.Models
{
    public partial class TbPlant
    {
        public TbPlant()
        {
            TbDevices = new HashSet<TbDevice>();
            TbMeasures = new HashSet<TbMeasure>();
        }

        public int IdPlants { get; set; }
        public string TxPlants { get; set; }
        public string TxUp { get; set; }
        public string TxEcName { get; set; }
        public string TxSse { get; set; }
        public string TxSubSystem { get; set; }
        public int IdVenditori { get; set; }

        public virtual TbVendor IdVenditoriNavigation { get; set; }
        public virtual ICollection<TbDevice> TbDevices { get; set; }
        public virtual ICollection<TbMeasure> TbMeasures { get; set; }
    }
}
