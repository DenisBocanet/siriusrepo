using System;
using System.Collections.Generic;

#nullable disable

namespace SiriusApi.Models
{
    public partial class TbDevice
    {
        public int IdDevice { get; set; }
        public string TxName { get; set; }
        public int? NmAltitude { get; set; }
        public string NmLatitude { get; set; }
        public string NmLongitude { get; set; }
        public string NmSerial { get; set; }
        public short? NmYear { get; set; }
        public string TxModel { get; set; }
        public string TxTypeSection { get; set; }
        public string TxNote { get; set; }
        public int? IdPlant { get; set; }

        public virtual TbPlant IdPlantNavigation { get; set; }
    }
}
